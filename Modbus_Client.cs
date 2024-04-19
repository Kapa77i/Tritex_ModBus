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
        int SLAVE_ID = 1; 
        

        public Modbus_Client()
        {
            InitializeComponent();
        }

        //Connection button functionality
        private void btnConnect_Click(object sender, EventArgs e)
        {
            modbusTcpClient = new ModbusTcpClient();

            new IPEndPoint(IPAddress.Parse(cbEngines.Text), int.Parse(tbPort.Text));
     
            Console.WriteLine(IPAddress.Parse(cbEngines.Text));
            Console.WriteLine(int.Parse(tbPort.Text));

            if (btnConnect.Text == "Connect")
            {
                try
                {
                    modbusTcpClient.Connect(ModbusEndianness.BigEndian);
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
                    modbusTcpClient.Disconnect();
                    modbusTcpClient = null;
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
            //Addressess
            int ADD_IEG_MOTION = 4317;  //0x10DD
            int ADD_JOG = 6020; //0x1784
            int ADD_FASTVEL = 6024;  // 0x1788, UVEL32
            int ADD_SLOWVELO = 6022; // 0x1786, UVEL32
            int ADD_ACCELERATION = 6026; // 0x178A, UACC32
            var uniqIdent = 0x0000;

            //Identifier
            int IEG_MOTION_ID = 0x10DD;
            int ADD_JOG_ID = 0x1784;

            //Default values to be used:
            int VAL_JOG = 65533; //# Max int value 65535. -1 if Alternate mode (AMO), -2 if default mode is on (DMO)
            int VAL_FASTVEL = 8;
            int VAL_SLOWVEL = 8;
            int VAL_ACCELERATION = 8;

            ////int[] jog_values = { 65533,       6022,        8,          6024,         8,          6026,               8 };
            int[] jog_values = { VAL_JOG, ADD_SLOWVELO, VAL_SLOWVEL, ADD_FASTVEL, VAL_FASTVEL, ADD_ACCELERATION, VAL_ACCELERATION };
            foreach (int i in jog_values)
            {
                Console.WriteLine(i.ToString());
            }

            try
            {
                Console.WriteLine("Ennen kirjoitusta: ");
                foreach (int i in jog_values)
                {
                    Console.WriteLine(i.ToString());
                }
                modbusTcpClient.WriteMultipleRegisters(uniqIdent, ADD_JOG, jog_values);
                //modbusTcpClient.WriteMultipleRegisters<int>(uniqIdent, ADD_JOG, jog_values);
                Console.WriteLine("Kirjoituksen jälkeen: ");
                foreach (int i in jog_values)
                {
                    Console.WriteLine(i.ToString());
                }
            }
            catch (Exception ex)
            {

                lbClientStatus.Text = "Error when writing! " + ex.ToString();
            }

        }

        private void btnReadRegister_Click(object sender, EventArgs e)
        {
            Span<byte> data;

            var uniqIdent = 0x00;
            data = modbusTcpClient.ReadHoldingRegisters<byte>(uniqIdent, int.Parse(tbRegisterVal.Text), 10);
            tbShowRegVal.Text = data[0].ToString();
        }
    }
}
