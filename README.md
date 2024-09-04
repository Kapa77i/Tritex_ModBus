# Tritex_ModBus

Thesis project of controlling Tritex Actuators with the help of Tritex Expert Software. This is a prototype code to showcase remote connection to the actuators and being able to send commands via Modbus TCP/IP Protocol.

Build uses FluentModbus nugget. 

<b>Current code withholds:</b>
- Connection to actuators
- Enable maintained inputs
- Alternative Movement
- Jog +/- inputs
- Home input
- Stop Input
- Move 1 Input
- Move 2 Input

There is also hidden server code/form to debug whenever you cannot access the simulator to test out simple read/write commands. 

To run this prototype code successfully, you also need to:
- Install Expert Tritex Software

<b>Here is short guidance to test the code:</b>
- Download the needed software and this repository as described above
- Connect your laptop via RJ-45 cable to the switch (there should be one cable already, dedicated to this purpose available near the switch)
- Run through the start procedure on the Simulator (main PC and the simulator)
      -> Let it run through the movement sequence and everything, before moving on to the next step.
- Close all the Mevea apps in the Main PC (ctrl + alt + del and then from the processes close MeveaMotionpPlatformUIApp + watchdog)
- Open the Expert Tritex app (Tritex Drive Setup) <b>on your laptop</b>
- If you need guidance to setup the TCP connection, please check the following documentation for more in depth setup (this guide assumes that you have setup everything correctly or know how to do it already)
- Read the Drive file from the drivers by choosing Drive -> Read Parameters From the Drive
  -> by now you should see your tritex app connected (status on the lower part of the software "Enabled"
- Open the Tritex_Modbus client
- Click Connect
  -> Status message should show you if it is connected or not and the buttons will became abled once the connection is established.


**Trouble shooting**

If not connected check:
- Firewall settings (port 502 needs to be open)
- is the cable fully in place
- can you ping any of the motors from your laptop? (_**win+R,**_ type _**cmd**_, then _**ping** _+ the IP address of the motor)
