using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FluentModbus;
using EasyModbus;

namespace Tritex_ModBus
{
    public partial class Tritex_Modbus : Form
    {
        ModbusTcpServer modbusServer;
      
        //EasyModbus.ModbusServer modbusServer;

        public Tritex_Modbus()
        {
            InitializeComponent();
            //modbusServer = new EasyModbus.ModbusServer();
            modbusServer = new ModbusTcpServer();

            //Show the second form (client)
            Modbus_Client client = new Modbus_Client();
            client.Show();

        }

        //Hide the test server in normal situations
        //Here if need to test some codes without the simulator
        //Then just remove this code for testing purposes
        private void Tritex_Modbus_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                modbusServer.Start();
                lbStatus.Text = "Status of the Connection: Connected!";
                btnStart.Text = "Stop";
                btnStart.BackColor = Color.Red;
            }
            else if (btnStart.Text == "Stop")
            {
                //modbusServer = new ModbusServer();
                modbusServer.Dispose();
                modbusServer = null;
                lbStatus.Text = "Status of the Connection: Connection lost!";
                btnStart.Text = "Start";
                btnStart.BackColor = Color.White;
            }
        }

    
    }

}

