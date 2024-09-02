using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentModbus;
using EasyModbus;
using System.Runtime.InteropServices;
using System.Diagnostics.Eventing.Reader;
using System.Data.SqlTypes;

// https://apollo3zehn.github.io/FluentModbus/

namespace Tritex_ModBus
{
    public partial class Modbus_Client : Form
    {
        ModbusTcpClient modbusTcpClient1;
        ModbusTcpClient modbusTcpClient2;

        public Modbus_Client()
        {
            InitializeComponent();
        }

        //Connection button functionality
        private void btnConnect_Click(object sender, EventArgs e)
        {
            modbusTcpClient1 = new ModbusTcpClient();
            modbusTcpClient2 = new ModbusTcpClient();

            if (btnConnect.Text == "Connect")
            {
                try
                {
                    modbusTcpClient1.Connect(IPAddress.Parse(tbM1.Text), ModbusEndianness.BigEndian);
                    modbusTcpClient2.Connect(IPAddress.Parse(tbM2.Text), ModbusEndianness.BigEndian);


                    Console.WriteLine("Both engines connected");
                    lbClientStatus.Text = "Client Connection: Connected!";
                    btnConnect.Text = "Disconnect";
                    btnConnect.BackColor = Color.Red;

                    //Enable Movement command button available after succesful connection
                    btnEnable.Enabled = true;
                    btnIEG_MOD.Enabled = true;
                    btnAlt.Enabled = true;
             
                }
                catch (Exception ex)
                {
                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }

            else if (btnConnect.Text == "Disconnect")
            {

                try
                {
                    modbusTcpClient1.Disconnect();
                    modbusTcpClient1 = null;
                    modbusTcpClient2.Disconnect();
                    modbusTcpClient2 = null;
                    lbClientStatus.Text = "Client Connection: Disconnected!";
                    btnConnect.Text = "Connect";
                    btnConnect.BackColor = Color.White;

                    //Make buttons unavailable
                    if(btnEnable.Text == "Move Enabled!")
                    {
                        btnEnable.Text = "Enable IEG_MOT";
                        btnEnable.BackColor = Color.White;
                    }

                    if (btnAlt.Text == "STOP Alt Mode")
                    {
                        btnAlt.BackColor = Color.White;
                        btnAlt.Text = "Alternate Mode";
                    }

                    if (btnIEG_MOD.Text == "Move Enabled!")
                    {
                        btnIEG_MOD.Text = "Enable IEG_MOD";
                        btnIEG_MOD.BackColor = Color.White;
                    }


                    btnEnable.Enabled = false;
                    btnIEG_MOD.Enabled= false;
                    btnAlt.Enabled = false;
                    btnStop.Enabled = false;
                    btnJogPlus.Enabled = false;
                    btnJogMinus.Enabled = false;
                    btnGoHome.Enabled = false;
                    btnMove2.Enabled = false;
                    btnMove3.Enabled = false;
                    btnPosition.Enabled = false;
                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }
        }

        //Enable the movement first, always!
        private void btnEnable_Click(object sender, EventArgs e)
        {
            if (btnEnable.Text == "Enable IEG_MOT")
            {
                try
                {
                    //IEG_MOTIION, Fault reset
                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 65535);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 65535);

                    //IEG_MOTION, enable
                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 2);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 2);
                    lbClientStatus.Text = "Enable (Maintained) activated!";
                    btnEnable.Text = "Move Enabled!";
                    btnEnable.BackColor = Color.DarkOrange;

                    //Allow the Stop, Home, Jogs and Move command buttons
                    btnStop.Enabled = true;
                    btnJogPlus.Enabled = true;
                    btnJogMinus.Enabled = true;
                    btnGoHome.Enabled = true;
                    btnMove2.Enabled = true;
                    btnMove3.Enabled = true;

                    //Disable Alt mode & Momentary mode?
                    btnIEG_MOD.Enabled = false;

                }
                catch (Exception ex)
                {
                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }


            else if (btnEnable.Text == "Move Enabled!")
            {
                try
                {
                    //IEG_MOTION, Fault reset
                     modbusTcpClient1.WriteSingleRegister(0x00, 4317, 65535);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 65535);

                    //IEG_MOTION, enable
                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 0);

                    lbClientStatus.Text = "Disabled Enable Move!";
                    btnEnable.Text = "Enable IEG_MOT";
                    btnEnable.BackColor = Color.White;

                    //Allow the Stop, Home, Jogs and Move command buttons
                    btnStop.Enabled = false;
                    btnJogPlus.Enabled = false;
                    btnJogMinus.Enabled = false;
                   btnGoHome.Enabled = false;
                    btnMove2.Enabled = false;
                    btnMove3.Enabled = false;

                    //Able Alt mode
                    btnIEG_MOD.Enabled = true;

                }

                catch (Exception ex)
                {
                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }  
        }

        private void btnIEG_MOD_Click(object sender, EventArgs e)
        {
            if (btnIEG_MOD.Text == "Enable IEG_MOD")
            {
                try
                {
                    //IEG_MODE, Fault reset
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 65535);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4316, 65535);

                    //IEG_MODE, enable
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 1);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4316, 1);
                    lbClientStatus.Text = "Enable (Momentary) activated!";
                    btnIEG_MOD.Text = "Move Enabled!";
                    btnIEG_MOD.BackColor = Color.DarkOrange;

                    //Allow the Stop, Home, Jogs and Move command buttons
                    btnStop.Enabled = true;
                    btnJogPlus.Enabled = true;
                    btnJogMinus.Enabled = true;
                    btnGoHome.Enabled = true;
                    btnMove2.Enabled = true;
                    btnMove3.Enabled = true;

                    //Disable
                    btnEnable.Enabled = false;


                }
                catch (Exception ex)
                {
                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }


            else if (btnIEG_MOD.Text == "Move Enabled!")
            {
                try
                {
                    //IEG_MOTION, Fault reset
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 65535);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4316, 65535);

                    //IEG_MOTION, enable
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4316, 0);

                    lbClientStatus.Text = "Disabled Enable Move!";
                    btnIEG_MOD.Text = "Enable IEG_MOD";
                    btnIEG_MOD.BackColor = Color.White;

                    //Allow the Stop, Home, Jogs and Move command buttons
                    btnStop.Enabled = false;
                    btnJogPlus.Enabled = false;
                    btnJogMinus.Enabled = false;
                    btnGoHome.Enabled = false;
                    btnMove2.Enabled = false;
                    btnMove3.Enabled = false;

                    //Able
                    btnEnable.Enabled = true;

                }

                catch (Exception ex)
                {
                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }
        }


        //Stop any and all movement
        private void btnStop_Click(object sender, EventArgs e)
        {
            if (btnStop.Text == "STOP Move")
            {
                try
                {
                    //STOP movement, IEG_MOTION
                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 4);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 4);
                    lbClientStatus.Text = "Write succesful!";
                    btnStop.Text = "STOPPED";
                    btnStop.BackColor = Color.DarkOrange;
                }
                catch (Exception ex)
                {
                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }

            }

            else if (btnStop.Text == "STOPPED")
            {
                try
                {
                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 0);
                    lbClientStatus.Text = "Write succesful!";
                    btnStop.Text = "STOP Move";
                    btnStop.BackColor = Color.White;
                }
                catch (Exception ex)
                {
                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }
          
        }


        //Go to Home position, IEG_MOTION
        private void btnGoHome_Click(object sender, EventArgs e)
        {
            if (btnGoHome.Text == "Go Home")
            {
                try
                {
                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 256);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 256);
                    lbClientStatus.Text = "Write succesful!";
                    btnGoHome.Text = "Homing";
                    btnGoHome.BackColor = Color.DarkOrange;
                    var isHoming = modbusTcpClient2.ReadInputRegisters<Int16>(0x00, 104, 15);
                    foreach (var item in isHoming)
                    {
                        Console.WriteLine("Status Homing Start: " + item.ToString());
                    }

                }
                catch (Exception ex)
                {
                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }
            else if (btnGoHome.Text == "Homing")
            {
                try
                {
                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 0);
                    lbClientStatus.Text = "Write succesful!";
                    btnGoHome.Text = "Go Home";
                    btnGoHome.BackColor = Color.White;
                }
                catch (Exception ex)
                {
                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }

           
        }

        /*FOLLOWING CODE IS TO JUST SHOWCASE THAT THE JOGS AND MOVEMENT COMMANDS WORK*/

        //Jog+ movement
        private void btnJogPlus_Click(object sender, EventArgs e)
        {
            if (btnJogPlus.BackColor == Color.White)
            {
                try
                {

                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 16);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 16);
                    btnJogPlus.BackColor = Color.DarkOrange;
                    lbClientStatus.Text = "Jogging!";
                    btnJogPlus.Text = "STOP Jog";
                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
            else if (btnJogPlus.BackColor == Color.DarkOrange)
            {
                try
                {
                    //Works
                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 0);
                    btnJogPlus.BackColor = Color.White;
                    btnJogPlus.Text = "Jog+";
                    lbClientStatus.Text = "Stopped Jog motion!";
                    var isHoming = modbusTcpClient2.ReadInputRegisters<Int16>(0x00, 104, 15);
                    foreach (var item in isHoming)
                    {
                        Console.WriteLine("Status Jogging+ END: " + item.ToString());
                    }

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }

        }

        //Jog- movement
        private void btnJogMinus_Click(object sender, EventArgs e)
        {
            if (btnJogMinus.BackColor == Color.White)
            {
                try
                {

                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 32);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 32);
                    btnJogMinus.BackColor = Color.DarkOrange;
                    lbClientStatus.Text = "Jogging!";
                    btnJogMinus.Text = "STOP Jog";
                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
            else if (btnJogMinus.BackColor == Color.DarkOrange)
            {
                try
                {
                    modbusTcpClient1.WriteSingleRegister(0x00, 4317, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4317, 0);
                    btnJogMinus.BackColor = Color.White;
                    btnJogMinus.Text = "Jog-";
                    lbClientStatus.Text = "Stopped Jog motion!";
                    var isHoming = modbusTcpClient2.ReadInputRegisters<Int16>(0x00, 104, 15);
                    foreach (var item in isHoming)
                    {
                        Console.WriteLine("Status Jogging- END: " + item.ToString());
                    }

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
        }


        //MOVE
        //Move commands uses different channel (4318) and it calls out the mapped movements in the Tritex (Move 0 - 15).
        /*You can map these commands in Tritex beforehand, set all the needed parameters for upper and lower limits
        and then just call the channel to execute the command.*/
        /*CTo initiate different Move functions you need to sent the following 
         value to the Channel 4318: Move 0 = 1, Move 1 = 2, Move 2 = 4, Move 3 = 8, Move 4 = 16, Move 5 = 32, etc. */
        /*You can also use the Modbus Mapping tool, map the needde parameters beforehand and then just call them, but 
         by the time of writing this code, I have not yet checked that closely. Checking from the manual, it should follow
        the same procedure as above. If you want to set the parameters outside Tritex, you need to call separate channels before hand
        to set the parameters and then send the execution command of the wanted movement. */

        //IEG_MOVE_LEVEL = move to Move 2 parameter.
        //Channel 4318, send value 4. 
        private void btnMove2_Click(object sender, EventArgs e)
        {
            if (btnMove2.Text == "Move 2")
            {
                try
                {
                    modbusTcpClient1.WriteSingleRegister(0x00, 4318, 4);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4318, 4);
                    lbClientStatus.Text = "Wrote succesful to Move2!";
                    btnMove2.BackColor = Color.DarkOrange;
                    btnMove2.Text = "STOP Move";
                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
            else if (btnMove2.Text == "STOP Move")
            {
                try
                {
                    modbusTcpClient1.WriteSingleRegister(0x00, 4318, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4318, 0);
                    lbClientStatus.Text = "Wrote the 'stop the move' succesfully";
                    btnMove2.BackColor = Color.White;
                    btnMove2.Text = "Move 2";
                    var isHoming = modbusTcpClient2.ReadInputRegisters<Int16>(0x00, 104, 15);
                    foreach (var item in isHoming)
                    {
                        Console.WriteLine("Status Move1 END: " + item.ToString());
                    }

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
          
        }



        private void btnMove3_Click(object sender, EventArgs e)
        {
            if (btnMove3.Text == "Move 3")
            {
                try
                {
                    modbusTcpClient1.WriteSingleRegister(0x00, 4318, 8);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4318, 8);
                    lbClientStatus.Text = "Write succesful to Move2!";
                    btnMove3.BackColor = Color.DarkOrange;
                    btnMove3.Text = "STOP Move";

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
            else if (btnMove3.Text == "STOP Move")
            {
                try
                {
                    modbusTcpClient1.WriteSingleRegister(0x00, 4318, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4318, 0);
                    lbClientStatus.Text = "Wrote the 'stop the move' succesfully";
                    btnMove3.BackColor = Color.White;
                    btnMove3.Text = "Move 3";
                }
                catch (Exception ex)
                {
                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
        }


        /*FOLLOWING CODE IS FOR THE ALTERNATE MODE OF THE INTERFACE WITH LIMITS ALREADY SET IN THE TRITEX SOFTWARE DIRECTLY*/
        //You can set the primary parameters (Position, Velocity, Torque) either on the Tritex Expert Software
        //or you can sent them in separate command before excecuting these in the same way, as the code is executed. 
        /*´Reading from the documentation if you would like to set all the parameters by yourself: basically you would pick the correct register from the Tritex listing (e.g., Analog Position, Channel 7100)
         send the needed parameters in one single Write Register command (e.g., for Channel 7100 you need to sent information for 
        minimmum, maximum, velocity, acceleration, current limit plus and minus) with correct parameters before executing 
        the actual position command*/
        /*For this code, I have used the Tritex software to set these basic limits and I am only sending the execute commands 
         via this code using the Generic Driver profile that I have set up directly on the Tritex software.*/

        //Enabling Alternate Mode with IEG_MODE by sending channel 4316 value 128 (Tritex parameter manual page 77)
        //Added manual override
        private void btnAlt_Click(object sender, EventArgs e)
        {
            if (btnAlt.Text == "Alternate Mode")
            {
                try
                {
                    //IEG_MODE Alt Mode value 128
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 128);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4316, 128);
                    lbClientStatus.Text = "Write succesful, Alternate Mode Engaged";
                    btnAlt.BackColor = Color.DarkOrange;
                    btnAlt.Text = "STOP Alt Mode";

                    //Enable Alt Buttons
                    btnBreak.Enabled = true;
                    btnPosition.Enabled = true;

                    //Disable Homing and those parameters (since those do not work here)
                    btnGoHome.Enabled = false;
                    btnJogMinus.Enabled = false;
                    btnJogPlus.Enabled = false;
                    btnMove2.Enabled = false;
                    btnMove3.Enabled = false;


                    var isHoming = modbusTcpClient2.ReadInputRegisters<Int16>(0x00, 104, 15);
                    foreach (var item in isHoming)
                    {
                        Console.WriteLine("Status ALT START OEG: " + item.ToString());
                    }

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
            else if (btnAlt.Text == "STOP Alt Mode")
            {
                try
                {
                    //Stop the alternate mode
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4316, 0);
                    lbClientStatus.Text = "Alt mode turned off succesfully";
                    btnAlt.BackColor = Color.White;
                    btnAlt.Text = "Alternate Mode";

                    //Disable Alt Buttons
                    btnBreak.Enabled = false;
                    btnPosition.Enabled = false;

                    //Enable Homing etc
                    btnGoHome.Enabled = true;
                    btnJogMinus.Enabled = true;
                    btnJogPlus.Enabled = true;
                    btnMove2.Enabled = true;
                    btnMove3.Enabled = true;

                    var isHoming = modbusTcpClient2.ReadInputRegisters<Int16>(0x00, 104, 15);
                    foreach (var item in isHoming)
                    {
                        Console.WriteLine("Status ALT END OEG: " + item.ToString());
                    }

                }
                catch (Exception ex)
                {
                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
        }


        //Override breaks
        private void btnBreak_Click(object sender, EventArgs e)
        {
            if (btnBreak.Text == "Override Breaks")
            {
                try
                {
                    //IEG_MODE Break Override
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 32768);
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 32768);
                    btnBreak.BackColor = Color.White;
                    btnBreak.Text = "STOP";

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
            else if (btnBreak.Text == "STOP")
            {
                try
                {
                    //Stop the alternate mode
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4316, 0);
                    lbClientStatus.Text = "Break Override turned off succesfully";
                    btnBreak.BackColor = Color.White;
                    btnBreak.Text = "Override Breaks";

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
         
        }


        //Activate movement
        //Register no. 5107, Name: AltCommandMode, Value 2 (Analog Position), Tritex Parameter Manual page 95
        //Another option?
        //Register no. 7188, Name: Alt_Position, Value ??? 2 ??? (Analog Position), Tritex Parameter Manual page 
        /*This works in away that you set the amount og movement EITHER in the Tritex Software Directely or by the separate commands.
         When you have stated the limits of the movement (E.g. Minimum 0.00 REVS and Maximum 6.00 REVS) you will send the activation
        signal here, the movement will continue until you click the button again, which will signal end of the movement. */
        private void btnPosition_Click(object sender, EventArgs e)
        {
            if (btnPosition.Text == "Position")
            {
                try
                {
                    //Activates the move
                    modbusTcpClient1.WriteSingleRegister(0x00, 5107, 2);
                    modbusTcpClient1.WriteSingleRegister(0x00, 5107, 2);
                    lbClientStatus.Text = "Writing Position!";
                    btnPosition.BackColor = Color.DarkOrange;
                    btnPosition.Text = "STOP";
                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
            else if (btnPosition.Text == "STOP")
            {
                try
                {
                    //Stop the alternate mode
                    modbusTcpClient1.WriteSingleRegister(0x00, 5107, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 5107, 0);
                    lbClientStatus.Text = "Stopped writing position";
                    btnPosition.BackColor = Color.White;
                    btnPosition.Text = "Position";

                    var isHoming = modbusTcpClient2.ReadInputRegisters<Int16>(0x00, 104, 15);
                    foreach (var item in isHoming)
                    {
                        Console.WriteLine("Status Alt Position END: " + item.ToString());
                    }

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
        }

    }
}
