using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SKYPE4COMLib;
using System.IO.Ports;
using System.Diagnostics;

namespace DaveBot
{
    public partial class Form1 : Form
    {
        const string APPLICATION_NAME = "DaveBot";

        //-- Globals --
        Skype skype;
        SKYPE4COMLib.Application app = null;
        ApplicationStream stream = null;
        Call call = null;
        String portName;
        SerialPort serialPort;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetupSkypeApplication();
        }

        private void SetupSkypeApplication()
        {
            //-- DaveBot require Skype to be already running --
            Process[] processes = Process.GetProcessesByName("Skype");
            if (processes.Length != 1)
            {
                MessageBox.Show("DaveBot require Skype to be running. Launch Skype and try again.");
                this.Close();
            }

            try
            {
                //-- Instantiate Skype's API --
                skype = new Skype();

                //-- Can we attach to Skype? --
                ISkype iskype = skype as ISkype;
                if (iskype.AttachmentStatus == TAttachmentStatus.apiAttachAvailable || iskype.AttachmentStatus == TAttachmentStatus.apiAttachUnknown)
                {
                    PrintDebug("Attaching to Skype...");
                    const int SKYPE_ATTACH_PROTOCOL = 5;
                    const bool SKYPE_ATTACH_WAIT = false;
                    skype.Attach(SKYPE_ATTACH_PROTOCOL, SKYPE_ATTACH_WAIT);

                    PrintDebug("Creating Skype application: " + APPLICATION_NAME + "...");
                    app = skype.get_Application(APPLICATION_NAME);
                    if (app != null) app.Create();

                    PrintDebug(app.Name + " created!");

                    PrintDebug("Subscribing to Skype events...");
                    skype.ApplicationStreams += new _ISkypeEvents_ApplicationStreamsEventHandler(skype_ApplicationStreams);
                    skype.ApplicationReceiving += new _ISkypeEvents_ApplicationReceivingEventHandler(skype_ApplicationReceiving);

                    PrintDebug(APPLICATION_NAME + " is ready!");
                }
                else
                    PrintDebug("ERROR: cannot attach to Skype: " + iskype.AttachmentStatus.ToString() + "\r\nPlease launch Skype then relaunch DaveBot");
            }
            catch (Exception ex)
            {
                PrintDebug("ERROR: cannot attach to Skype: " + ex.Message + "\r\nPlease launch Skype then relaunch DaveBot");
            }
        }

        private void PrintDebug(string msg)
        {
            debugTxt.Text += msg + "\r\n";
            debugTxt.SelectionStart = debugTxt.Text.Length;
            debugTxt.ScrollToCaret();
            debugTxt.Refresh();
        }

        //-- Event Handlers --
        void skype_ApplicationStreams(SKYPE4COMLib.Application pApp, ApplicationStreamCollection pStreams)
        {
            //PrintDebug("Received ApplicationStreams event for " + pApp.Name);
            if (pApp.Name == APPLICATION_NAME)
            {
                foreach (ApplicationStream astream in pStreams)
                    if (stream == null) stream = astream;
            }
        }

        void skype_ApplicationReceiving(SKYPE4COMLib.Application pApp, ApplicationStreamCollection pStreams)
        {
            //PrintDebug("Received ApplicationReceiving event for " + pApp.Name);
            if (pApp.Name == APPLICATION_NAME)
            {
                foreach (ApplicationStream aStream in pStreams)
                {
                    string msg = aStream.Read();
                    //PrintDebug(string.Format("DATA: '{0}'\r\n", msg));

                    if (msg.Substring(0, 1) == "*") //Must be robot-status message
                    {
                        PrintDebug(msg);
                    }
                    else
                    {
                        TellArduino(msg);                       //Netbook has command, pass to Arduino
                        Sleep(100);                             //Give some time for Arduino to respond
                        msg = serialPort.ReadLine();            //Read status message from robot
                        SendViaSkype(msg);                      //Send it back to operator
                    }
                }
            }
        }

        //-- Button Handlers --
        private void connectBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Client client = skype.Client;
                if (client.IsRunning)
                {
                    call = skype.PlaceCall(skypeIdTxt.Text, null, null, null);
                    bool getOut = false;
                    for (int i = 0; i < 10; i++)
                    {
                        PrintDebug(call.Status.ToString().Substring(3));

                        switch (call.Status)
                        {
                            case TCallStatus.clsBusy:
                                getOut = true;
                                break;
                            case TCallStatus.clsInProgress:
                                PrintDebug("Connected."); getOut = true;
                                break;
                            case TCallStatus.clsRefused:
                                debugTxt.Text += "Refused"; getOut = true;
                                break;
                            case TCallStatus.clsRinging:
                                debugTxt.Text += "Ringing...";
                                break;
                        } //switch

                        if (getOut) break;

                        Sleep(1000);
                    } //for
                }
            }
            catch (Exception ex)
            {
                PrintDebug("ERROR: Unable to connect. Launch Skype and sign-in. Click connect again, then switch to Skype to allow access.  " + ex.Message);
            }
        }

        private static void Sleep(int mS)
        {
            System.Threading.Thread.Sleep(mS);
        }

        private void SendViaSkype(string message)
        {
            if (stream == null)
            {
                PrintDebug("Reconnecting app...");
                app.Connect(skypeIdTxt.Text, true);
                Sleep(2000);    // Give skype time to connect us and fire the ApplicationStreams event.
            }

            if (stream == null)
                PrintDebug("Unable to send command via Skype.  Is DaveBot running on the PC that you're trying to connect to?");
            else
            {
                try
                {
                    stream.Write(message);
                }
                catch (Exception ex)
                {
                    PrintDebug("Unable to send command via Skype.  " + ex.Message);
                }
            }
        }

        private void panLeftBtn_Click(object sender, EventArgs e)
        {
            SendViaSkype("p");
           
        }


        private void panRightBtn_Click(object sender, EventArgs e)
        {
            SendViaSkype("P");
        }

        private void tiltUp_Click(object sender, EventArgs e)
        {
            SendViaSkype("T");
        }
        
        private void tiltDown_Click(object sender, EventArgs e)
        {
            SendViaSkype("t");
        }

        private void moveToCenterBtn_Click(object sender, EventArgs e)
        {
            SendViaSkype("C");
        }

        private void stopVideoBtn_Click(object sender, EventArgs e)
        {
            //-- if DaveBot is relaunched after call was already established, grab active call --
            if (call == null && skype != null && skype.ActiveCalls.Count > 0) call = skype.ActiveCalls[1];

            if (call != null && call.Status != TCallStatus.clsFinished)
            {
                call.Finish();
            }
        }

        public void TellArduino(string message)
        {
            try
            {
                serialPort.Write(message);
                PrintDebug(message); 
            }
            catch (Exception ex)
            {
                PrintDebug("Serial communication glitch" + ex.Message + "\r\nPlease launch Skype then relaunch DaveBot");
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DaveBot.help help = new DaveBot.help();
            help.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void skypeIdTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            SendViaSkype("S");
        }

        private void FWD1_button_Click(object sender, EventArgs e)
        {
            SendViaSkype("1");
        }

        private void FWD2_button_Click(object sender, EventArgs e)
        {
            SendViaSkype("2");
        }

        private void FWD3_button_Click(object sender, EventArgs e)
        {
            SendViaSkype("3");
        }

        private void REV_button_Click(object sender, EventArgs e)
        {
            SendViaSkype("b");
        }

        private void JOG_right_button_Click(object sender, EventArgs e)
        {
            SendViaSkype("r");
        }

        private void JOG_left_button_Click(object sender, EventArgs e)
        {
            SendViaSkype("l");
        }

        private void RT45_button_Click(object sender, EventArgs e)
        {
            SendViaSkype("d");
        }

        private void LF45_button_Click(object sender, EventArgs e)
        {
            SendViaSkype("g");
        }

        private void RightFace_button_Click(object sender, EventArgs e)
        {
            SendViaSkype("R");
        }

        private void LeftFace_button_Click(object sender, EventArgs e)
        {
            SendViaSkype("L");
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void commPortList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            portName = commPortList.Text;
            int baudRate = 9600;
            serialPort = new SerialPort(portName, baudRate);

            serialPort.DtrEnable = true;    //Not sure if this is necessary (but doesn't hurt!)

            try
            {
                serialPort.Open();
                Sleep(1000);                  //Give Arduino time to reset from port-open operation
                PrintDebug("COM port opened. Arduino reset.");
                this.button1.Enabled = false;
                this.button3.Enabled = true;
                this.button4.Enabled = true;
            }
            catch (Exception ex)
            {
                    MessageBox.Show ("Unable to open COM port. Is the correct COM port chosen? " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SendViaSkype("*TestStatusMessage");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            try
            {
                serialPort.Close();
                PrintDebug("COM port closed.");
                this.button1.Enabled = true;
                this.button3.Enabled = false;
                this.button4.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to close COM port. Was the COM port open?" + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TellArduino("P");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }        
    }
}
       