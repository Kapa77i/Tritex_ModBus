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
        //ModbusTcpServer modbusServer;
        EasyModbus.ModbusServer modbusServer;

        public Tritex_Modbus()
        {
            InitializeComponent();
            modbusServer = new EasyModbus.ModbusServer();
            //modbusServer = new ModbusTcpServer();
            //modbusServer.LocalIPAddress = double.Parse("127.0.0.1");

            //Show the second form (client)
            Modbus_Client client = new Modbus_Client();
            client.Show();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {

                modbusServer.Listen();
                lbStatus.Text = "Status of the Connection: Connected!";
                btnStart.Text = "Stop";
                btnStart.BackColor = Color.Red;
            }
            else if (btnStart.Text == "Stop")
            {
                //modbusServer = new ModbusServer();
                modbusServer.StopListening();
                modbusServer = null;
                lbStatus.Text = "Status of the Connection: Connection lost!";
                btnStart.Text = "Start";
                btnStart.BackColor = Color.White;
            }
        }
        //private void btnSet_Click(object sender, EventArgs e)
        //{
        //    if (cbRegisterType.Text == "Holding Register")
        //    {
        //        ModbusServer.HoldingRegisters regs = modbusServer.holdingRegisters;
        //    }
        //}
    }


    //private void btnStart_Click(object sender, EventArgs e)
    //{
    //    if (btnStart.Text == "Start")
    //    {

    //        modbusServer.Start();
    //        lbStatus.Text = "Status of the Connection: Connected!";
    //        btnStart.Text = "Stop";
    //        btnStart.BackColor = Color.Red;
    //    }
    //    else if (btnStart.Text == "Stop")
    //    {
    //        //modbusServer = new ModbusServer();
    //        modbusServer.Dispose();
    //        modbusServer = null;
    //        lbStatus.Text = "Status of the Connection: Connection lost!";
    //        btnStart.Text = "Start";
    //        btnStart.BackColor = Color.White;
    //    }
    //}

    //private void btnSet_Click(object sender, EventArgs e)
    //{
    //    //if (cbRegisterType.Text == "Holding Register")
    //    //{
    //    //    ModbusServer.HoldingRegisters regs = modbusServer.holdingRegisters;
    //    //}
    //}


}

