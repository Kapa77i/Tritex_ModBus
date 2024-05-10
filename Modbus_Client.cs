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

// https://apollo3zehn.github.io/FluentModbus/

namespace Tritex_ModBus
{
    public partial class Modbus_Client : Form
    {
        //EasyModbus.ModbusClient modbusClient;
        ModbusTcpClient modbusTcpClient;
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
                    //Changed this from BigEndian to Little (CHECK THIS IF THERE IS ANY ISSUES!!)
                    modbusTcpClient1.Connect((IPAddress.Parse(tbM1.Text)), ModbusEndianness.BigEndian);
                    modbusTcpClient2.Connect((IPAddress.Parse(tbM2.Text)), ModbusEndianness.BigEndian);
                    Console.WriteLine("Both engines connected");
                    lbClientStatus.Text = "Client Connection: Connected!";
                    btnConnect.Text = "Disconnect";
                    btnConnect.BackColor = Color.Red;

                    //Enable Movement command button available after succesful connection
                    btnEnable.Enabled = true;
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
                    btnEnable.Enabled = false;
                    btnAlt.Enabled = false;
                    btnStop.Enabled = false;
                    btnJogPlus.Enabled = false;
                    btnJogMinus.Enabled = false;
                    btnGoHome.Enabled = false;
                    btnMove1.Enabled = false;
                    btnPosition.Enabled = false;
                    btnTorque.Enabled = false;
                    btnVelocity.Enabled = false;
                    

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
            //modbusTcpClient1.Connect(new IPEndPoint(IPAddress.Parse(tbM1.Text), int.Parse(tbPort.Text)), ModbusEndianness.BigEndian);
            //modbusTcpClient2.Connect(new IPEndPoint(IPAddress.Parse(tbM2.Text), int.Parse(tbPort.Text)), ModbusEndianness.BigEndian);
            try
            {
                Console.WriteLine(modbusTcpClient1.IsConnected.ToString());
                Console.WriteLine(modbusTcpClient2.IsConnected.ToString());
                //IEG_MOTION, enable
                modbusTcpClient1.WriteSingleRegister(0x00, 4317, 2);
                modbusTcpClient2.WriteSingleRegister(0x00, 4317, 2);


                //IEG_MOTIION, Fault reset
               // modbusTcpClient1.WriteSingleRegister(0x00, 4317, 65535);
               // modbusTcpClient2.WriteSingleRegister(0x00, 4317, 65535);
                lbClientStatus.Text = "Write succesful!";

                btnEnable.Text = "Move Enabled!";

                //Allow the Stop, Home, Jogs and Move command buttons
                btnStop.Enabled = true;
                btnJogPlus.Enabled = true;
                btnJogMinus.Enabled = true;
                btnGoHome.Enabled = true;
                btnMove1.Enabled = true;

            }
            catch (Exception ex)
            {
                lbClientStatus.Text = "ERROR! " + ex.ToString();
            }       
           
        }

        //Stop any and all movement
        private void btnStop_Click(object sender, EventArgs e)
        {
            try
            {
                //STOP movement, IEG_MOTION
                modbusTcpClient1.WriteSingleRegister(0x00, 4317, 4);
                modbusTcpClient2.WriteSingleRegister(0x00, 4317, 4);
                lbClientStatus.Text = "Write succesful!";
            }
            catch (Exception ex)
            {
                lbClientStatus.Text = "ERROR! " + ex.ToString();
            }
        }


        //Go to Home position, IEG_MOTION
        private void btnGoHome_Click(object sender, EventArgs e)
        {
            try
            {
                modbusTcpClient1.WriteSingleRegister(0x00, 4317, 256);
                modbusTcpClient2.WriteSingleRegister(0x00, 4317, 256);
                lbClientStatus.Text = "Write succesful!";
            }
            catch (Exception ex)
            {
                lbClientStatus.Text = "ERROR! " + ex.ToString();
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

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
        }

        //MOVE
        //It uses different channel (4318) and it calls out the mapped movements in the Tritex (Move 0 - 15).
        //You can map these commands in Tritex beforehand, set all the needed parameters for upper and lower limits
        //and then just call the channel to execute the command.
        /*You can also use the Modbus Mapping tool, map the neede parameters beforehand and then just call them, but 
         by the time of writing this code, I have not yet checked that closely. Checking from the manual, it should follow
        the same procedure as above. If you want to set the parameters outside Tritex, you need to call separate channels before hand
        to set the parameters and then send the execution command of the wanted movement. */

        //IEG_MOVE_LEVEL = move to Move 2 parameter.
        private void btnMove1_Click(object sender, EventArgs e)
        {
            if (btnMove1.Text == "Move Lvl Initiate")
            {
                try
                {
                    //Activates the move
                    modbusTcpClient1.WriteSingleRegister(0x00, 4318, 2);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4318, 2);
                    lbClientStatus.Text = "IEG_MOTION_LEVEL succesful!";
                    modbusTcpClient1.WriteSingleRegister(0x00, 4318, 4);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4318, 4);
                    lbClientStatus.Text = "Write succesful to Move2!";
                    btnMove1.BackColor = Color.DarkOrange;
                    btnMove1.Text = "STOP Move";

                    //Possibille IEG_MOTION command? Comment stuff above when testing this
                    //modbusTcpClient1.WriteSingleRegister(0x00, 4317, 2048);
                    //modbusTcpClient2.WriteSingleRegister(0x00, 4317, 2048);

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
            else if (btnMove1.Text == "STOP Move")
            {
                try
                {
                    //Stop the move?
                    modbusTcpClient1.WriteSingleRegister(0x00, 4318, 0);
                    modbusTcpClient2.WriteSingleRegister(0x00, 4318, 0);
                    lbClientStatus.Text = "Write the 'stop the move' succesfully";
                    btnMove1.BackColor = Color.White;
                    btnMove1.Text = "Move Lvl Initiate";

                    //Possibille IEG_MOTION command? Comment stuff above when testing this
                    //modbusTcpClient1.WriteSingleRegister(0x00, 4317, 2048);
                    //modbusTcpClient2.WriteSingleRegister(0x00, 4317, 2048);

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
        //Enables it, but also puts the machine on break (disabled) - why? 
        private void btnAlt_Click(object sender, EventArgs e)
        {
            if (btnAlt.Text == "Alternate Mode")
            {
                try
                {
                    //IED_MODE Reset Value 65535
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 65535);
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 65535);

                    //IED_MODE Enable Maintained value 2
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 2);
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 2);

                    //IEG_MODE Alt Mode value 128
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 128);
                    modbusTcpClient1.WriteSingleRegister(0x00, 4316, 128);
                    lbClientStatus.Text = "Write succesful, Alternate Mode Engaged";
                    btnAlt.BackColor = Color.DarkOrange;
                    btnAlt.Text = "STOP Alt Mode";

                    //Enable Alt Buttons
                    btnBreak.Enabled = true;
                    btnPosition.Enabled = true;
                    btnVelocity.Enabled = true;
                    btnTorque.Enabled = true;

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

                    //Unable Alt Buttons
                    btnBreak.Enabled = false;
                    btnPosition.Enabled = false;
                    btnVelocity.Enabled = false;
                    btnTorque.Enabled = false;

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

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
        }

        //REad register code, needs to add the handler if used.
        //private void btnReadRegister_Click(object sender, EventArgs e)
        //{
        //    var uniqIdent = 0x00;
        //    var startingAddress = int.Parse(tbRegisterVal.Text);
        //    //var registers = ModbusTcpServer.GetHoldingRegisters();
        //    //registers.SetBigEndian<int>(address: 1, value: 99);
        //    //Console.WriteLine(registers.ToString());
        //    //Span<short> registers.GetBigEndian<T>();

        //    try
        //    {
        //        var shortDataResult = modbusTcpClient.ReadHoldingRegisters<short>(uniqIdent, startingAddress, 2);

        //        Console.WriteLine("Haettu tulos: ");
        //        foreach (var item in shortDataResult) { 

        //            Console.WriteLine(item.ToString());

        //        }
        //        //Console.WriteLine(shortDataResult[0]);

        //        lbClientStatus.Text = "Read succesful!";
        //        tbShowRegVal.Text = shortDataResult[0].ToString();
        //    }
        //    catch (Exception ex)
        //    {
        //        lbClientStatus.Text = "Error when writing! " + ex.ToString();
        //    }

        //}

    }
}
