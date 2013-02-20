========================
  DaveBot version 1.0
========================

DaveBot is a minor modification to an application called "SkyDuino," written by Hari Waguna.
See his SkyDuino blog post: http://g33k.blogspot.com/2010_02_01_archive.html#1585005824177729856

The following general description, like the Davebot code itself, is a minor embellishment to the
description Hari Waguna provided with his SkyDuino project. If you are successful in using any or
all of this code to make your own telepresence robot, the lion's share of the credit should go to
Hari Waguna. And if you have trouble getting things to work, Dave Schneider probably deserves
the blame.


DaveBot combines Skype and Arduino to stream live video with remote robot control and remote camera
pan and tilt capability. Skype is free and has an API that allows you to send data in two directions,
along with audio and video.

The advantages of using Skype include:

- You don't need a Webserver.
- No need to mess with dynamic IP, port routing, or firewall issues.

The disadvantages of using Skype include:

- Skype can be pretty laggy, perhaps as a function of how busy their servers are.
- If Skype drops the call (which is common), you have to restart the software to re-establish connection
with the robot, which is a big pain.


DaveBot is written in Visual Studio 2008 C#, which is available for free from Microsoft.

==================
  Skype Accounts
==================

You will need two Skype accounts--one for the robot and another for the operator. You can use your existing
Skype account if you already have one to operate the robot.

You create an account at the login screen of the Skype application (instead of registering at the Skype Website).

====================
  Robot Skype Setup
====================

-Install the Arduino IDE on the robot's netbook and use it to program the robot's Arduino with the DaveBot sketch.
(Note that we're calling both pieces of code "DaveBot"--the Arduino sketch and the C# application that runs on
the robot's netbook.)

- On the robot's netbook, install Skype and start the Skype application.

- To make life easier, enable auto-answer. But because you don't want unauthorized people operating your
telepresence robot, limit access to just those on the robot's contact list.(Make sure the operator is the only contact
on the robot's contact list, of course.)

- Run the C# application "Davebot," then switch to Skype to allow DaveBot to access Skype.(You'll only need to do this
once.)

- Return to DaveBot. In the Robot tab, set the Arduino comm port using the drop-down list at the upper left and open the
com port with the button marked. This is the same port you use in Arduino IDE to upload the Davebot sketch
to your Arduino.

--Power on the robot's Arduino. IMPORTANT NOTE: If you have wired your robot so that powering on the Arduino also
powers the Parallax encoder boards, be careful not to move your robot by hand. Because the encoders are now live, they will
track any such movements. Then the first thing that the robot will do when you power the motors is to
return to its original position, which can cause an unexpected lurch.


==================
  Operator Setup
==================

- Run Skype.

- Run DaveBot, then switch to Skype to allow DaveBot to access Skype. (Again, you'll only need to do this step once.)

- Return to DaveBot. Enter the robot's Skype ID in the connection box at the upper left.

- Check with the robot's local helper that the Arduino is running and that Skype and the DaveBot app are running.

- At your end, click Start in the connection box. DaveBot will send a command to Skype to start a video call with your robot.

- Your robot should automatically answer the call. First test that the pan-tilt commands are working properly. If so,
ask your robot's human helper to turn on power to the robot's motors. At this point, you should be able to control the robot
with the robot-motion buttons and move the Webcam using the pan and tilt buttons.

===================
  Troubleshooting
===================

If Skype drops the call or you otherwise have trouble with the Skype connection, start over, launch Skype again, then
launch the DaveBot app again. Open the com port on the robot and re-establish the Skype connection with it.


===================
  Developer notes
===================

Note that the robot tab has buttons marked "Send Test Message to Operator" and "Send Test Command to Arduino."
You don't need to touch these. They were used for testing during development and it's even possible that the
first one is no longer working.

Note that this code departs from the SkyDuino code in how the com port is opened. The Skyduino code opened and closed
the com port for each character sent, which created havoc with the Arduino board DaveBot used (because it resets
each time the com port is opened). Manually opening and closing the com port at the start and end of the
session solved this problem, although it could probably be done more elegantly that it is done here.

For information about the Skype API, see: https://developer.skype.com/

For information about Arduino, see: http://arduino.cc


