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
        ModbusTcpServer ModbusTcpServer = new ModbusTcpServer();

        int SLAVE_ID = 1; 
        

        public Modbus_Client()
        {
            InitializeComponent();
        }

        //Connection button functionality
        private void btnConnect_Click(object sender, EventArgs e)
        {
            modbusTcpClient = new ModbusTcpClient();
            var registers = ModbusTcpServer.GetHoldingRegisters();

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
            var registers = ModbusTcpServer.GetHoldingRegisters();

            //Addressess
            int ADD_IEG_MOTION = 4317;  //0x10DD
            int ADD_JOG = 6020; //0x1784
            int ADD_SLOWVELO = 6022; // 0x1786, UVEL32
            int ADD_SLOWVELOHIGH = 6023; // 0x1786, UVEL32
            int ADD_FASTVEL = 6024;  // 0x1788, UVEL32
            int ADD_FASTVELHIGH = 6025;  // 0x1788, UVEL32
            int ADD_ACCELERATION = 6026; // 0x178A, UACC32
            int ADD_ACCELERATIONHIGH = 6027; // 0x178A, UACC32
            var uniqIdent = 0x00;

            //Identifier
            int IEG_MOTION_ID = 0x10DD;
            int ADD_JOG_ID = 0x1784;

            //Default values to be used:
            int VAL_JOG = 65533; //# Max int value 65535. -1 if Alternate mode (AMO), -2 if default mode is on (DMO)
            int VAL_FASTVEL = 8;
            int VAL_FASTVELHIGH = 8;
            int VAL_SLOWVEL = 8;
            int VAL_SLOWVELHIGH = 8;
            int VAL_ACCELERATION = 8;
            int VAL_ACCELERATIONHIGH = 8;

            ////int[] jog_values = {    6022,        8,            6023,                8         6024,         8,            6025                8              6026,               8,                    6027,                 8 };
            //int[] jog_values = { ADD_SLOWVELO, VAL_SLOWVEL, ADD_SLOWVELOHIGH, VAL_SLOWVELHIGH,  ADD_FASTVEL, VAL_FASTVEL, ADD_FASTVELHIGH, VAL_FASTVELHIGH, ADD_ACCELERATION, VAL_ACCELERATION, ADD_ACCELERATIONHIGH, VAL_ACCELERATIONHIGH };

            int[] jog_values = { VAL_JOG, /*ADD_SLOWVELO,*/ VAL_SLOWVEL, /*ADD_FASTVEL,*/ VAL_FASTVEL, /*ADD_ACCELERATION,*/ VAL_ACCELERATION}; 
            int[] jog_values_array = jog_values.ToArray();

            //int[] jog_values_Big = { VAL_SLOWVEL, VAL_SLOWVELHIGH, VAL_FASTVEL, VAL_FASTVELHIGH, VAL_ACCELERATION, VAL_ACCELERATIONHIGH };
            //int[] jog_values_Address = { ADD_SLOWVELO, ADD_SLOWVELOHIGH, ADD_FASTVEL, ADD_FASTVELHIGH, ADD_ACCELERATION, ADD_ACCELERATIONHIGH };
            

            //foreach (int i in jog_values)
            //{
            //    Console.WriteLine(i.ToString());
            //}

            try
            {
                Console.WriteLine("Ennen kirjoitusta: ");
                foreach (int i in jog_values)
                {
                    Console.WriteLine(i.ToString());
                }
                modbusTcpClient.WriteMultipleRegisters(uniqIdent, ADD_JOG, jog_values_array);
                //modbusTcpClient.WriteMultipleRegisters<int>(uniqIdent, ADD_JOG, jog_values);
                Console.WriteLine("Kirjoituksen jälkeen: ");
                foreach (int i in jog_values)
                {
                    Console.WriteLine(i.ToString());
                }
                Console.WriteLine("Kirjoitus onnistui!");

                //int j = 0;
                //foreach (var item in jog_values_Address)
                //{
                //    registers.SetBigEndian<int>(address: item, value: jog_values_Big[j]);
                //    j++;
                //}

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

            var shortDataResult = modbusTcpClient.ReadHoldingRegisters<int>(uniqIdent, startingAddress, 1);
            Console.WriteLine("Haettu tulos: " + shortDataResult[0]);
            //Console.WriteLine(shortDataResult[0]);


            tbShowRegVal.Text = shortDataResult[0].ToString();
        }

    }
}
