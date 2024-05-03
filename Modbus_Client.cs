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
    ////Addressess listing
    //int ADD_IEG_MOTION = 4317;  //0x10DD
    //int ADD_JOG = 6020; //0x1784
    //int ADD_SLOWVELO = 6022; // 0x1786, UVEL32
    //int ADD_SLOWVELOHIGH = 6023; // 0x1786, UVEL32
    //int ADD_FASTVEL = 6024;  // 0x1788, UVEL32
    //int ADD_FASTVELHIGH = 6025;  // 0x1788, UVEL32
    //int ADD_ACCELERATION = 6026; // 0x178A, UACC32
    //int ADD_ACCELERATIONHIGH = 6027; // 0x178A, UACC32
    //var uniqIdent = 0x00;

    ////Identifier
    //int IEG_MOTION_ID = 0x10DD;
    //int ADD_JOG_ID = 0x1784;

    ////Default values to be used:
    //int VAL_JOG = 1; //# Max int value 65535. -1 if Alternate mode (AMO), -2 if default mode is on (DMO)
    //int VAL_FASTVEL = 100;
    //int VAL_FASTVELHIGH = 8;
    //int VAL_SLOWVEL = 100;
    //int VAL_SLOWVELHIGH = 8;
    //int VAL_ACCELERATION = 50;
    //int VAL_ACCELERATIONHIGH = 8;
    public partial class Modbus_Client : Form
    {
        //EasyModbus.ModbusClient modbusClient;
        ModbusTcpClient modbusTcpClient;
        ModbusTcpClient modbusTcpClient1;
        ModbusTcpClient modbusTcpClient2;
        ModbusTcpServer ModbusTcpServer = new ModbusTcpServer();

        int SLAVE_ID = 1; 
        

        public Modbus_Client()
        {
            InitializeComponent();
           
        }

        //Connection button functionality
        private void btnConnect_Click(object sender, EventArgs e)
        {
            modbusTcpClient1 = new ModbusTcpClient();
            modbusTcpClient2 = new ModbusTcpClient();
            var registers = ModbusTcpServer.GetHoldingRegisters();
            var uniqIdent = 0x00;

            //new IPEndPoint(IPAddress.Parse(cbEngines.Text), int.Parse(tbPort.Text));
     
           // Console.WriteLine(IPAddress.Parse(cbEngines.Text));
            //Console.WriteLine(int.Parse(tbPort.Text));

            if (btnConnect.Text == "Connect")
            {
                try
                {
                    modbusTcpClient1.Connect((IPAddress.Parse(tbM1.Text)), ModbusEndianness.BigEndian);
                    modbusTcpClient2.Connect((IPAddress.Parse(tbM2.Text)), ModbusEndianness.BigEndian);
                    Console.WriteLine("Both engines connected");
                    lbClientStatus.Text = "Client Connection: Connected!";
                    btnConnect.Text = "Disconnect";
                    btnConnect.BackColor = Color.Red;

                    //Enable jogs after succesfull connection
                    btnEnable.Enabled = true;
                    btnStop.Enabled = true;
     
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
                    btnJobMinus.Enabled = false;
                    btnGoHome.Enabled = false;

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
                modbusTcpClient1.WriteSingleRegister(0x00, 4317, 65535);
                modbusTcpClient2.WriteSingleRegister(0x00, 4317, 65535);
                lbClientStatus.Text = "Write succesful!";

                btnEnable.Text = "Move Enabled!";

                //Allow the jogs
                btnJogPlus.Enabled = true;
                btnJobMinus.Enabled = true;
                btnGoHome.Enabled = true;
                btnMove1.Enabled = true;
                btnMove2.Enabled = true;

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

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            try
            {
                //STOP movement, IEG_MOTION
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
            try
            {
                
                modbusTcpClient1.WriteSingleRegister(0x00, 4317, 16);
                modbusTcpClient2.WriteSingleRegister(0x00, 4317, 16);
                lbClientStatus.Text = "Write succesful!";

            }
            catch (Exception ex)
            {

                lbClientStatus.Text = "Error when writing! " + ex.ToString();
            }

        }

        //Write jog-
        private void btnJobMinus_Click(object sender, EventArgs e)
        {
            try
            {

                modbusTcpClient1.WriteSingleRegister(0x00, 4317, 32);
                modbusTcpClient2.WriteSingleRegister(0x00, 4317, 32);
                lbClientStatus.Text = "Write succesful!";

            }
            catch (Exception ex)
            {

                lbClientStatus.Text = "Error when writing! " + ex.ToString();
            }
        }

        //MOVEMENT 
        //It uses different channel (4318) and it calls out the mapped movements in the Tritex (Move 0 - 15).

        //IEG_MOVE_LEVEL = move to Move 1 parameter.
        private void btnMove1_Click(object sender, EventArgs e)
        {
            try
            {

                modbusTcpClient1.WriteSingleRegister(0x00, 4318, 2);
                modbusTcpClient2.WriteSingleRegister(0x00, 4318, 2);
                lbClientStatus.Text = "Write succesful!";
                modbusTcpClient1.WriteSingleRegister(0x00, 4318, 16);
                modbusTcpClient2.WriteSingleRegister(0x00, 4318, 16);

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

                modbusTcpClient1.WriteSingleRegister(0x00, 4317, 2048);
                modbusTcpClient2.WriteSingleRegister(0x00, 4317, 2048);
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
                //var data = modbusTcpClient.ReadI
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
