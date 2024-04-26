namespace Tritex_ModBus
{
    partial class Modbus_Client
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbIP = new System.Windows.Forms.Label();
            this.lbPort = new System.Windows.Forms.Label();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lbClientStatus = new System.Windows.Forms.Label();
            this.cbEngines = new System.Windows.Forms.ComboBox();
            this.btnJogPlus = new System.Windows.Forms.Button();
            this.btnJobMinus = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbRegisterVal = new System.Windows.Forms.TextBox();
            this.btnReadRegister = new System.Windows.Forms.Button();
            this.tbShowRegVal = new System.Windows.Forms.TextBox();
            this.lbRegister = new System.Windows.Forms.Label();
            this.lbRegVal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.tbM1 = new System.Windows.Forms.TextBox();
            this.tbM2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(27, 27);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(58, 13);
            this.lbIP.TabIndex = 0;
            this.lbIP.Text = "IP Address";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(27, 59);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(26, 13);
            this.lbPort.TabIndex = 1;
            this.lbPort.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Enabled = false;
            this.tbPort.Location = new System.Drawing.Point(139, 56);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(119, 20);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "502";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(143, 93);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(110, 29);
            this.btnConnect.TabIndex = 4;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lbClientStatus
            // 
            this.lbClientStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbClientStatus.AutoSize = true;
            this.lbClientStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbClientStatus.Location = new System.Drawing.Point(12, 508);
            this.lbClientStatus.Name = "lbClientStatus";
            this.lbClientStatus.Size = new System.Drawing.Size(133, 18);
            this.lbClientStatus.TabIndex = 5;
            this.lbClientStatus.Text = "Client Connection: ";
            // 
            // cbEngines
            // 
            this.cbEngines.Enabled = false;
            this.cbEngines.FormattingEnabled = true;
            this.cbEngines.Items.AddRange(new object[] {
            "192.168.0.212",
            "192.168.0.211",
            "192.168.0.1",
            "192.168.0.254",
            "127.0.0.1"});
            this.cbEngines.Location = new System.Drawing.Point(284, 55);
            this.cbEngines.Name = "cbEngines";
            this.cbEngines.Size = new System.Drawing.Size(121, 21);
            this.cbEngines.TabIndex = 6;
            // 
            // btnJogPlus
            // 
            this.btnJogPlus.Enabled = false;
            this.btnJogPlus.Location = new System.Drawing.Point(137, 25);
            this.btnJogPlus.Name = "btnJogPlus";
            this.btnJogPlus.Size = new System.Drawing.Size(98, 49);
            this.btnJogPlus.TabIndex = 7;
            this.btnJogPlus.Text = "Jog+";
            this.btnJogPlus.UseVisualStyleBackColor = true;
            this.btnJogPlus.Click += new System.EventHandler(this.btnJogPlus_Click);
            // 
            // btnJobMinus
            // 
            this.btnJobMinus.Enabled = false;
            this.btnJobMinus.Location = new System.Drawing.Point(241, 25);
            this.btnJobMinus.Name = "btnJobMinus";
            this.btnJobMinus.Size = new System.Drawing.Size(98, 49);
            this.btnJobMinus.TabIndex = 8;
            this.btnJobMinus.Text = "Jog-";
            this.btnJobMinus.UseVisualStyleBackColor = true;
            this.btnJobMinus.Click += new System.EventHandler(this.btnJobMinus_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Enabled = false;
            this.btnGoHome.Location = new System.Drawing.Point(21, 90);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(98, 49);
            this.btnGoHome.TabIndex = 9;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnEnable);
            this.panel1.Controls.Add(this.btnGoHome);
            this.panel1.Controls.Add(this.btnJobMinus);
            this.panel1.Controls.Add(this.btnJogPlus);
            this.panel1.Location = new System.Drawing.Point(66, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 188);
            this.panel1.TabIndex = 10;
            // 
            // tbRegisterVal
            // 
            this.tbRegisterVal.Location = new System.Drawing.Point(100, 18);
            this.tbRegisterVal.Name = "tbRegisterVal";
            this.tbRegisterVal.Size = new System.Drawing.Size(137, 20);
            this.tbRegisterVal.TabIndex = 11;
            // 
            // btnReadRegister
            // 
            this.btnReadRegister.Location = new System.Drawing.Point(100, 44);
            this.btnReadRegister.Name = "btnReadRegister";
            this.btnReadRegister.Size = new System.Drawing.Size(137, 23);
            this.btnReadRegister.TabIndex = 12;
            this.btnReadRegister.Text = "Read Register Value";
            this.btnReadRegister.UseVisualStyleBackColor = true;
            this.btnReadRegister.Click += new System.EventHandler(this.btnReadRegister_Click);
            // 
            // tbShowRegVal
            // 
            this.tbShowRegVal.Location = new System.Drawing.Point(125, 104);
            this.tbShowRegVal.Name = "tbShowRegVal";
            this.tbShowRegVal.Size = new System.Drawing.Size(82, 20);
            this.tbShowRegVal.TabIndex = 13;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Location = new System.Drawing.Point(16, 24);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(49, 13);
            this.lbRegister.TabIndex = 14;
            this.lbRegister.Text = "Register:";
            // 
            // lbRegVal
            // 
            this.lbRegVal.AutoSize = true;
            this.lbRegVal.Location = new System.Drawing.Point(70, 107);
            this.lbRegVal.Name = "lbRegVal";
            this.lbRegVal.Size = new System.Drawing.Size(34, 13);
            this.lbRegVal.TabIndex = 15;
            this.lbRegVal.Text = "Value";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbRegVal);
            this.panel2.Controls.Add(this.lbRegister);
            this.panel2.Controls.Add(this.tbShowRegVal);
            this.panel2.Controls.Add(this.btnReadRegister);
            this.panel2.Controls.Add(this.tbRegisterVal);
            this.panel2.Location = new System.Drawing.Point(30, 322);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 141);
            this.panel2.TabIndex = 16;
            // 
            // btnEnable
            // 
            this.btnEnable.Enabled = false;
            this.btnEnable.Location = new System.Drawing.Point(21, 25);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(98, 49);
            this.btnEnable.TabIndex = 10;
            this.btnEnable.Text = "Enable Move";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(184, 90);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(98, 49);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "STOP Move";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // tbM1
            // 
            this.tbM1.Enabled = false;
            this.tbM1.Location = new System.Drawing.Point(139, 19);
            this.tbM1.Name = "tbM1";
            this.tbM1.Size = new System.Drawing.Size(100, 20);
            this.tbM1.TabIndex = 17;
            this.tbM1.Text = "192.168.0.211";
            // 
            // tbM2
            // 
            this.tbM2.Enabled = false;
            this.tbM2.Location = new System.Drawing.Point(250, 19);
            this.tbM2.Name = "tbM2";
            this.tbM2.Size = new System.Drawing.Size(100, 20);
            this.tbM2.TabIndex = 18;
            this.tbM2.Text = "192.168.0.212";
            // 
            // Modbus_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 592);
            this.Controls.Add(this.tbM2);
            this.Controls.Add(this.tbM1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cbEngines);
            this.Controls.Add(this.lbClientStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIP);
            this.Location = new System.Drawing.Point(500, 500);
            this.Name = "Modbus_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Modbus_Client";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lbClientStatus;
        private System.Windows.Forms.ComboBox cbEngines;
        private System.Windows.Forms.Button btnJogPlus;
        private System.Windows.Forms.Button btnJobMinus;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox tbRegisterVal;
        private System.Windows.Forms.Button btnReadRegister;
        private System.Windows.Forms.TextBox tbShowRegVal;
        private System.Windows.Forms.Label lbRegister;
        private System.Windows.Forms.Label lbRegVal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbM1;
        private System.Windows.Forms.TextBox tbM2;
    }
}