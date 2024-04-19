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

// https://apollo3zehn.github.io/FluentModbus/

namespace Tritex_ModBus
{
    public partial class Modbus_Client : Form
    {
        EasyModbus.ModbusClient modbusClient;
        //ModbusTcpClient modbusClient;

        public Modbus_Client()
        {
            InitializeComponent();
        }

        //Connection button functionality
        private void btnConnect_Click(object sender, EventArgs e)
        {
            //modbusClient = new ModbusTcpClient();

            ////new IPEndPoint(IPAddress.Parse(cbEngines.Text), 502);
            ////new IPEndPoint(IPAddress.Parse("192.168.0.254"), 502); //Tritex IP?
            ////Console.WriteLine(cbEngines.Text);
            //new IPEndPoint(IPAddress.Parse("127.0.0.1"), 502);


            //if (btnConnect.Text ==  "Connect")
            //{
            //    try
            //    {
            //        modbusClient.Connect(ModbusEndianness.BigEndian);
            //        lbClientStatus.Text = "Client Connection: Connected!";
            //        btnConnect.Text = "Disconnect";
            //        btnConnect.BackColor = Color.Red;

            //        //Enable jogs after succesfull connection
            //        btnJogPlus.Enabled = true;
            //        btnJobMinus.Enabled = true;
            //        btnGoHome.Enabled = true;

            //    }
            //    catch (Exception ex)
            //    {
            //        lbClientStatus.Text = "ERROR! " + ex.ToString();
            //    }
            //}

            //else if (btnConnect.Text == "Disconnect")
            //{

            //    try
            //    {
            //        modbusClient.Disconnect();
            //        modbusClient = null;
            //        lbClientStatus.Text = "Client Connection: Disconnected!";
            //        btnConnect.Text = "Connect";
            //        btnConnect.BackColor = Color.White;

            //    }
            //    catch (Exception ex)
            //    {

            //        lbClientStatus.Text = "ERROR! " + ex.ToString();
            //    }
            //}

            modbusClient = new EasyModbus.ModbusClient();
            //modbusClient.IPAddress = tbIP.Text;
            //modbusClient.IPAddress = cbEngines.Text;
            //modbusClient.IPAddress = "192.168.0.1";
            modbusClient.IPAddress = "192.168.0.212";   //Tritex IP?
            //Console.WriteLine(cbEngines.Text);
            //modbusClient.IPAddress = "127.0.0.1";
            modbusClient.IPAddress = "127.0.0.1";
            modbusClient.Port = int.Parse(tbPort.Text);
            Console.WriteLine(modbusClient.IPAddress);
            Console.WriteLine(modbusClient.Port);
            if (btnConnect.Text == "Connect")
            {
                try
                {
                    modbusClient.Available(500);
                    modbusClient.Connect();
                    lbClientStatus.Text = "Client Connection: Connected!";
                    btnConnect.Text = "Disconnect";
                    btnConnect.BackColor = Color.Red;
                    //Enable jogs after succesfull connection
                    btnJogPlus.Enabled = true;
                    btnJobMinus.Enabled = true;
                    btnGoHome.Enabled = true;
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
                    modbusClient.Disconnect();
                    modbusClient = null;
                    lbClientStatus.Text = "Client Connection: Disconnected!";
                    btnConnect.Text = "Connect";
                    btnConnect.BackColor = Color.White;
                }
                catch (Exception ex)
                {
                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }
        }

        //Jog movement forward
        private void btnJogPlus_Click(object sender, EventArgs e)
        {
            ////Addressess
            //var ADD_IEG_MOTION = 4317;  //0x10DD
            //var ADD_JOG = 6020; //0x1784
            //var ADD_FASTVEL = 6024;  // 0x1788, UVEL32
            //var ADD_SLOWVELO = 6022; // 0x1786, UVEL32
            //var ADD_ACCELERATION = 6026; // 0x178A, UACC32

            ////Identifier
            //var IEG_MOTION_ID = 0x10DD;
            //short ADD_JOG_ID = 0x1784;

            ////Default values to be used:
            //int VAL_JOG = 65533; //# Max int value 65535. -1 if Alternate mode (AMO), -2 if default mode is on (DMO)
            //int VAL_FASTVEL = 8;
            //int VAL_SLOWVEL = 8;
            //int VAL_ACCELERATION = 8;

            //try
            //{
            //    modbusClient.WriteSingleRegister(ADD_JOG, VAL_JOG, ADD_JOG_ID);

            //   // modbusClient.WriteSingleRegister(ADD_FASTVEL, VAL_FASTVEL);
            //    //modbusClient.WriteSingleRegister(ADD_SLOWVELO, VAL_SLOWVEL);
            //    //modbusClient.WriteSingleRegister(ADD_ACCELERATION, VAL_ACCELERATION);
            //}
            //catch (Exception ex)
            //{

            //    lbClientStatus.Text = "Error when writing! " + ex.ToString();
            //}

            //Addressess
            UInt16 ADD_IEG_MOTION = 4317;  //0x10DD
            UInt16 ADD_JOG = 6020; //0x1784
            UInt16 ADD_FASTVEL = 6024;  // 0x1788, UVEL32
            UInt16 ADD_SLOWVELO = 6022; // 0x1786, UVEL32
            UInt16 ADD_ACCELERATION = 6026; // 0x178A, UACC32
            //Default values to be used:
            int VAL_JOG = 65533; //# Max int value 65535. -1 if Alternate mode (AMO), -2 if default mode is on (DMO)
            int VAL_FASTVEL = 8;
            int VAL_SLOWVEL = 8;
            int VAL_ACCELERATION = 8;
            try
            {
                modbusClient.WriteSingleRegister(ADD_JOG, VAL_JOG);
                modbusClient.WriteSingleRegister(ADD_FASTVEL, VAL_FASTVEL);
                modbusClient.WriteSingleRegister(ADD_SLOWVELO, VAL_SLOWVEL);
                modbusClient.WriteSingleRegister(ADD_ACCELERATION, VAL_ACCELERATION);
            }
            catch (Exception ex)
            {
                lbClientStatus.Text = "Error when writing! " + ex.ToString();
            }

        }
    }
}
