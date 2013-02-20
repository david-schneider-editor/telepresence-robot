namespace DaveBot
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.skypeIdTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connectBtn = new System.Windows.Forms.Button();
            this.panLeftBtn = new System.Windows.Forms.Button();
            this.panRightBtn = new System.Windows.Forms.Button();
            this.debugTxt = new System.Windows.Forms.TextBox();
            this.tiltUp = new System.Windows.Forms.Button();
            this.tiltDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.stopVideoBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.moveToCenterBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.LF45_button = new System.Windows.Forms.Button();
            this.RT45_button = new System.Windows.Forms.Button();
            this.LeftFace_button = new System.Windows.Forms.Button();
            this.RightFace_button = new System.Windows.Forms.Button();
            this.JOG_right_button = new System.Windows.Forms.Button();
            this.JOG_left_button = new System.Windows.Forms.Button();
            this.FWD3_button = new System.Windows.Forms.Button();
            this.REV_button = new System.Windows.Forms.Button();
            this.FWD2_button = new System.Windows.Forms.Button();
            this.FWD1_button = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.commPortList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skypeIdTxt
            // 
            this.skypeIdTxt.Location = new System.Drawing.Point(9, 35);
            this.skypeIdTxt.Name = "skypeIdTxt";
            this.skypeIdTxt.Size = new System.Drawing.Size(183, 20);
            this.skypeIdTxt.TabIndex = 0;
            this.skypeIdTxt.Text = "specbot.telepresence.robot";
            this.skypeIdTxt.TextChanged += new System.EventHandler(this.skypeIdTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Skype ID to connect to:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(9, 69);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(94, 23);
            this.connectBtn.TabIndex = 2;
            this.connectBtn.Text = "Start";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // panLeftBtn
            // 
            this.panLeftBtn.Location = new System.Drawing.Point(6, 48);
            this.panLeftBtn.Name = "panLeftBtn";
            this.panLeftBtn.Size = new System.Drawing.Size(30, 23);
            this.panLeftBtn.TabIndex = 3;
            this.panLeftBtn.Text = "<";
            this.panLeftBtn.UseVisualStyleBackColor = true;
            this.panLeftBtn.Click += new System.EventHandler(this.panLeftBtn_Click);
            // 
            // panRightBtn
            // 
            this.panRightBtn.Location = new System.Drawing.Point(78, 48);
            this.panRightBtn.Name = "panRightBtn";
            this.panRightBtn.Size = new System.Drawing.Size(30, 23);
            this.panRightBtn.TabIndex = 4;
            this.panRightBtn.Text = ">";
            this.panRightBtn.UseVisualStyleBackColor = true;
            this.panRightBtn.Click += new System.EventHandler(this.panRightBtn_Click);
            // 
            // debugTxt
            // 
            this.debugTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.debugTxt.HideSelection = false;
            this.debugTxt.Location = new System.Drawing.Point(17, 419);
            this.debugTxt.Multiline = true;
            this.debugTxt.Name = "debugTxt";
            this.debugTxt.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.debugTxt.Size = new System.Drawing.Size(331, 104);
            this.debugTxt.TabIndex = 5;
            // 
            // tiltUp
            // 
            this.tiltUp.Location = new System.Drawing.Point(42, 19);
            this.tiltUp.Name = "tiltUp";
            this.tiltUp.Size = new System.Drawing.Size(30, 23);
            this.tiltUp.TabIndex = 8;
            this.tiltUp.Text = "^";
            this.tiltUp.UseVisualStyleBackColor = true;
            this.tiltUp.Click += new System.EventHandler(this.tiltUp_Click);
            // 
            // tiltDown
            // 
            this.tiltDown.Location = new System.Drawing.Point(42, 77);
            this.tiltDown.Name = "tiltDown";
            this.tiltDown.Size = new System.Drawing.Size(30, 23);
            this.tiltDown.TabIndex = 9;
            this.tiltDown.Text = "v";
            this.tiltDown.UseVisualStyleBackColor = true;
            this.tiltDown.Click += new System.EventHandler(this.tiltDown_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.stopVideoBtn);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.skypeIdTxt);
            this.groupBox1.Controls.Add(this.connectBtn);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(198, 144);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // stopVideoBtn
            // 
            this.stopVideoBtn.Location = new System.Drawing.Point(109, 69);
            this.stopVideoBtn.Name = "stopVideoBtn";
            this.stopVideoBtn.Size = new System.Drawing.Size(83, 23);
            this.stopVideoBtn.TabIndex = 3;
            this.stopVideoBtn.Text = "Stop";
            this.stopVideoBtn.UseVisualStyleBackColor = true;
            this.stopVideoBtn.Click += new System.EventHandler(this.stopVideoBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.moveToCenterBtn);
            this.groupBox2.Controls.Add(this.panLeftBtn);
            this.groupBox2.Controls.Add(this.panRightBtn);
            this.groupBox2.Controls.Add(this.tiltDown);
            this.groupBox2.Controls.Add(this.tiltUp);
            this.groupBox2.Location = new System.Drawing.Point(210, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(115, 144);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camera Pan/Tilt";
            // 
            // moveToCenterBtn
            // 
            this.moveToCenterBtn.Location = new System.Drawing.Point(42, 48);
            this.moveToCenterBtn.Name = "moveToCenterBtn";
            this.moveToCenterBtn.Size = new System.Drawing.Size(30, 23);
            this.moveToCenterBtn.TabIndex = 10;
            this.moveToCenterBtn.Text = "ctr";
            this.moveToCenterBtn.UseVisualStyleBackColor = true;
            this.moveToCenterBtn.Click += new System.EventHandler(this.moveToCenterBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(339, 365);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(331, 339);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Operator";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.LF45_button);
            this.groupBox3.Controls.Add(this.RT45_button);
            this.groupBox3.Controls.Add(this.LeftFace_button);
            this.groupBox3.Controls.Add(this.RightFace_button);
            this.groupBox3.Controls.Add(this.JOG_right_button);
            this.groupBox3.Controls.Add(this.JOG_left_button);
            this.groupBox3.Controls.Add(this.FWD3_button);
            this.groupBox3.Controls.Add(this.REV_button);
            this.groupBox3.Controls.Add(this.FWD2_button);
            this.groupBox3.Controls.Add(this.FWD1_button);
            this.groupBox3.Controls.Add(this.StopButton);
            this.groupBox3.Location = new System.Drawing.Point(6, 156);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(319, 167);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Robot Motion";
            // 
            // LF45_button
            // 
            this.LF45_button.Location = new System.Drawing.Point(47, 107);
            this.LF45_button.Name = "LF45_button";
            this.LF45_button.Size = new System.Drawing.Size(38, 23);
            this.LF45_button.TabIndex = 10;
            this.LF45_button.Text = "45";
            this.LF45_button.UseVisualStyleBackColor = true;
            this.LF45_button.Click += new System.EventHandler(this.LF45_button_Click);
            // 
            // RT45_button
            // 
            this.RT45_button.Location = new System.Drawing.Point(231, 107);
            this.RT45_button.Name = "RT45_button";
            this.RT45_button.Size = new System.Drawing.Size(38, 23);
            this.RT45_button.TabIndex = 9;
            this.RT45_button.Text = "45";
            this.RT45_button.UseVisualStyleBackColor = true;
            this.RT45_button.Click += new System.EventHandler(this.RT45_button_Click);
            // 
            // LeftFace_button
            // 
            this.LeftFace_button.Location = new System.Drawing.Point(6, 107);
            this.LeftFace_button.Name = "LeftFace_button";
            this.LeftFace_button.Size = new System.Drawing.Size(38, 23);
            this.LeftFace_button.TabIndex = 8;
            this.LeftFace_button.Text = "90";
            this.LeftFace_button.UseVisualStyleBackColor = true;
            this.LeftFace_button.Click += new System.EventHandler(this.LeftFace_button_Click);
            // 
            // RightFace_button
            // 
            this.RightFace_button.Location = new System.Drawing.Point(274, 107);
            this.RightFace_button.Name = "RightFace_button";
            this.RightFace_button.Size = new System.Drawing.Size(38, 23);
            this.RightFace_button.TabIndex = 7;
            this.RightFace_button.Text = "90";
            this.RightFace_button.UseVisualStyleBackColor = true;
            this.RightFace_button.Click += new System.EventHandler(this.RightFace_button_Click);
            // 
            // JOG_right_button
            // 
            this.JOG_right_button.Location = new System.Drawing.Point(188, 107);
            this.JOG_right_button.Name = "JOG_right_button";
            this.JOG_right_button.Size = new System.Drawing.Size(38, 23);
            this.JOG_right_button.TabIndex = 6;
            this.JOG_right_button.Text = "Jog";
            this.JOG_right_button.UseVisualStyleBackColor = true;
            this.JOG_right_button.Click += new System.EventHandler(this.JOG_right_button_Click);
            // 
            // JOG_left_button
            // 
            this.JOG_left_button.Location = new System.Drawing.Point(90, 107);
            this.JOG_left_button.Name = "JOG_left_button";
            this.JOG_left_button.Size = new System.Drawing.Size(38, 23);
            this.JOG_left_button.TabIndex = 5;
            this.JOG_left_button.Text = "Jog";
            this.JOG_left_button.UseVisualStyleBackColor = true;
            this.JOG_left_button.Click += new System.EventHandler(this.JOG_left_button_Click);
            // 
            // FWD3_button
            // 
            this.FWD3_button.Location = new System.Drawing.Point(135, 19);
            this.FWD3_button.Name = "FWD3_button";
            this.FWD3_button.Size = new System.Drawing.Size(48, 23);
            this.FWD3_button.TabIndex = 4;
            this.FWD3_button.Tag = "3";
            this.FWD3_button.Text = "3\' fwd";
            this.FWD3_button.UseVisualStyleBackColor = true;
            this.FWD3_button.Click += new System.EventHandler(this.FWD3_button_Click);
            // 
            // REV_button
            // 
            this.REV_button.Location = new System.Drawing.Point(135, 136);
            this.REV_button.Name = "REV_button";
            this.REV_button.Size = new System.Drawing.Size(48, 23);
            this.REV_button.TabIndex = 3;
            this.REV_button.Text = "1\' rev";
            this.REV_button.UseVisualStyleBackColor = true;
            this.REV_button.Click += new System.EventHandler(this.REV_button_Click);
            // 
            // FWD2_button
            // 
            this.FWD2_button.Location = new System.Drawing.Point(135, 49);
            this.FWD2_button.Name = "FWD2_button";
            this.FWD2_button.Size = new System.Drawing.Size(48, 23);
            this.FWD2_button.TabIndex = 2;
            this.FWD2_button.Text = "2\' fwd";
            this.FWD2_button.UseVisualStyleBackColor = true;
            this.FWD2_button.Click += new System.EventHandler(this.FWD2_button_Click);
            // 
            // FWD1_button
            // 
            this.FWD1_button.Location = new System.Drawing.Point(135, 78);
            this.FWD1_button.Name = "FWD1_button";
            this.FWD1_button.Size = new System.Drawing.Size(48, 23);
            this.FWD1_button.TabIndex = 1;
            this.FWD1_button.Text = "1\' fwd";
            this.FWD1_button.UseVisualStyleBackColor = true;
            this.FWD1_button.Click += new System.EventHandler(this.FWD1_button_Click);
            // 
            // StopButton
            // 
            this.StopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopButton.Location = new System.Drawing.Point(134, 107);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(48, 23);
            this.StopButton.TabIndex = 0;
            this.StopButton.Text = "STOP";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.commPortList);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(331, 339);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Robot";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(76, 201);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(174, 32);
            this.button4.TabIndex = 18;
            this.button4.Text = "Send Test Command to Arduino";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(76, 130);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(173, 30);
            this.button3.TabIndex = 17;
            this.button3.Text = "Close COM port";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(76, 166);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 29);
            this.button2.TabIndex = 16;
            this.button2.Text = "Send Test Message to Operator";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Open COM Port (required)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // commPortList
            // 
            this.commPortList.FormattingEnabled = true;
            this.commPortList.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7"});
            this.commPortList.Location = new System.Drawing.Point(6, 6);
            this.commPortList.Name = "commPortList";
            this.commPortList.Size = new System.Drawing.Size(59, 21);
            this.commPortList.TabIndex = 14;
            this.commPortList.Text = "COM3";
            this.commPortList.SelectedIndexChanged += new System.EventHandler(this.commPortList_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(286, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Use this tab to control how the netbook communicates with\r\nthe Arduino.";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 403);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Log:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(161, 381);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(27, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "help";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 535);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.debugTxt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DaveBot 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox skypeIdTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Button panLeftBtn;
        private System.Windows.Forms.Button panRightBtn;
        private System.Windows.Forms.TextBox debugTxt;
        private System.Windows.Forms.Button tiltUp;
        private System.Windows.Forms.Button tiltDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button stopVideoBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox commPortList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button moveToCenterBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button FWD3_button;
        private System.Windows.Forms.Button REV_button;
        private System.Windows.Forms.Button FWD2_button;
        private System.Windows.Forms.Button FWD1_button;
        private System.Windows.Forms.Button LeftFace_button;
        private System.Windows.Forms.Button RightFace_button;
        private System.Windows.Forms.Button JOG_right_button;
        private System.Windows.Forms.Button JOG_left_button;
        private System.Windows.Forms.Button LF45_button;
        private System.Windows.Forms.Button RT45_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

