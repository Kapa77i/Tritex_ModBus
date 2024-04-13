using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyModbus;

namespace Tritex_ModBus
{
    public partial class Modbus_Client : Form
    {
        ModbusClient modbusClient;

        public Modbus_Client()
        {
            InitializeComponent();
        }

        //Connection button functionality
        private void btnConnect_Click(object sender, EventArgs e)
        {
            modbusClient = new ModbusClient();
            modbusClient.IPAddress = tbIP.Text;
            modbusClient.Port = int.Parse(tbPort.Text);

            if (btnConnect.Text ==  "Connect")
            {
                try
                {
                    modbusClient.Connect();
                    lbClientStatus.Text = "Client Connection: Connected!";
                    btnConnect.Text = "Disconnect";
                    btnConnect.BackColor = Color.Red;

                }
                catch (Exception ex)
                {

                    lbClientStatus.Text = "ERROR! " + ex.ToString();
                }
            }

            else if (btnConnect.Text == "Disconnect")
            {

                modbusClient = null;
                lbClientStatus.Text = "Client Connection: Disconnected!";
                btnConnect.Text = "Connect";
                btnConnect.BackColor = Color.White;

                try
                {
                    modbusClient.Disconnect();
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
    }
}
