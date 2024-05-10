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

            //new IPEndPoint(IPAddress.Parse(tbM1.Text), int.Parse(tbPort.Text));
            //new IPEndPoint(IPAddress.Parse(tbM`2.Text), int.Parse(tbPort.Text));

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
                    btnStop.Enabled = false;
                    btnJogPlus.Enabled = false;
                    btnJogMinus.Enabled = false;
                    btnGoHome.Enabled = false;
                    btnMove1.Enabled = false;
                    btnMove2.Enabled = false;
                    btnMove1Terminate.Enabled = false;

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
                //IEG_MODE, enable
                modbusTcpClient1.WriteSingleRegister(0x00, 4317, 2);
                modbusTcpClient2.WriteSingleRegister(0x00, 4317, 2);


                //IEG_MODE, Fault reset
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
                btnMove2.Enabled = true;
                btnMove1Terminate.Enabled = true;

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
                    lbClientStatus.Text = "Write succesful!";

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
                    lbClientStatus.Text = "Write succesful, stopping Jog motion!";

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
                    lbClientStatus.Text = "Write succesful!";

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
                    lbClientStatus.Text = "Write succesful, stopping Jog motion!";

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "Error when writing! " + ex.ToString();
                }
            }
        }

        //MOVE
        //It uses different channel (4318) and it calls out the mapped movements in the Tritex (Move 0 - 15).

        //IEG_MOVE_LEVEL = move to Move 2 parameter.
        private void btnMove1_Click(object sender, EventArgs e)
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

                //Possibille IEG_MOTION command? Comment stuff above when testing this
                //modbusTcpClient1.WriteSingleRegister(0x00, 4317, 2048);
                //modbusTcpClient2.WriteSingleRegister(0x00, 4317, 2048);

            }
            catch (Exception ex)
            {

                lbClientStatus.Text = "Error when writing! " + ex.ToString();
            }
        }

        //IEG_MOVE_SWITCH
        //This function terminate the Move command in IEG_LEVEL
        private void btnMove1Terminate_Click(object sender, EventArgs e)
        {
            try
            {
                ////Does not terminate the move - why?
                //modbusTcpClient1.WriteSingleRegister(0x00, 4322, 2);
                //modbusTcpClient2.WriteSingleRegister(0x00, 4322, 2);
                ////For move 2
                //modbusTcpClient1.WriteSingleRegister(0x00, 4322, 4);
                //modbusTcpClient2.WriteSingleRegister(0x00, 4322, 4);
                //How about if we make it as a 0?
                modbusTcpClient1.WriteSingleRegister(0x00, 4322, 0);
                modbusTcpClient2.WriteSingleRegister(0x00, 4322, 0);
                lbClientStatus.Text = "Write succesful!";

            }
            catch (Exception ex)
            {

                lbClientStatus.Text = "Error when writing! " + ex.ToString();
            }
        }

        //This is only available when the actuator is se to Momentary (channel 4316?)
        //Move to the edge
        private void btnMove2_Click(object sender, EventArgs e)
        {
            try
            {

                modbusTcpClient1.WriteSingleRegister(0x00, 4317, 4096);
                modbusTcpClient2.WriteSingleRegister(0x00, 4317, 4096);
                lbClientStatus.Text = "Write succesful!";

            }
            catch (Exception ex)
            {

                lbClientStatus.Text = "Error when writing! " + ex.ToString();
            }
        }

       
        private void btnReadRegister_Click(object sender, EventArgs e)
        {
            var uniqIdent = 0x00;
            var startingAddress = int.Parse(tbRegisterVal.Text);
            //var registers = ModbusTcpServer.GetHoldingRegisters();
            //registers.SetBigEndian<int>(address: 1, value: 99);
            //Console.WriteLine(registers.ToString());
            //Span<short> registers.GetBigEndian<T>();

            try
            {
                var shortDataResult = modbusTcpClient.ReadHoldingRegisters<short>(uniqIdent, startingAddress, 2);

                Console.WriteLine("Haettu tulos: ");
                foreach (var item in shortDataResult) { 
                
                    Console.WriteLine(item.ToString());

                }
                //Console.WriteLine(shortDataResult[0]);

                lbClientStatus.Text = "Read succesful!";
                tbShowRegVal.Text = shortDataResult[0].ToString();
            }
            catch (Exception ex)
            {
                lbClientStatus.Text = "Error when writing! " + ex.ToString();
            }
           
        }

    }
}
