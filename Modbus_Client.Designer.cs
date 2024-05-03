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
            this.btnJogPlus = new System.Windows.Forms.Button();
            this.btnJobMinus = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnMove1 = new System.Windows.Forms.Button();
            this.tbRegisterVal = new System.Windows.Forms.TextBox();
            this.btnReadRegister = new System.Windows.Forms.Button();
            this.tbShowRegVal = new System.Windows.Forms.TextBox();
            this.lbRegister = new System.Windows.Forms.Label();
            this.lbRegVal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbM1 = new System.Windows.Forms.TextBox();
            this.tbM2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.Location = new System.Drawing.Point(36, 33);
            this.lbIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(73, 16);
            this.lbIP.TabIndex = 0;
            this.lbIP.Text = "IP Address";
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(36, 73);
            this.lbPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(31, 16);
            this.lbPort.TabIndex = 1;
            this.lbPort.Text = "Port";
            // 
            // tbPort
            // 
            this.tbPort.Enabled = false;
            this.tbPort.Location = new System.Drawing.Point(169, 69);
            this.tbPort.Margin = new System.Windows.Forms.Padding(4);
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(135, 22);
            this.tbPort.TabIndex = 3;
            this.tbPort.Text = "502";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(167, 103);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(147, 36);
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
            this.lbClientStatus.Location = new System.Drawing.Point(13, 429);
            this.lbClientStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClientStatus.Name = "lbClientStatus";
            this.lbClientStatus.Size = new System.Drawing.Size(169, 24);
            this.lbClientStatus.TabIndex = 5;
            this.lbClientStatus.Text = "Client Connection: ";
            // 
            // btnJogPlus
            // 
            this.btnJogPlus.Enabled = false;
            this.btnJogPlus.Location = new System.Drawing.Point(29, 25);
            this.btnJogPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnJogPlus.Name = "btnJogPlus";
            this.btnJogPlus.Size = new System.Drawing.Size(131, 60);
            this.btnJogPlus.TabIndex = 7;
            this.btnJogPlus.Text = "Jog+";
            this.btnJogPlus.UseVisualStyleBackColor = true;
            this.btnJogPlus.Click += new System.EventHandler(this.btnJogPlus_Click);
            // 
            // btnJobMinus
            // 
            this.btnJobMinus.Enabled = false;
            this.btnJobMinus.Location = new System.Drawing.Point(168, 25);
            this.btnJobMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnJobMinus.Name = "btnJobMinus";
            this.btnJobMinus.Size = new System.Drawing.Size(131, 60);
            this.btnJobMinus.TabIndex = 8;
            this.btnJobMinus.Text = "Jog-";
            this.btnJobMinus.UseVisualStyleBackColor = true;
            this.btnJobMinus.Click += new System.EventHandler(this.btnJobMinus_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.Enabled = false;
            this.btnGoHome.Location = new System.Drawing.Point(28, 160);
            this.btnGoHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(131, 60);
            this.btnGoHome.TabIndex = 9;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnEnable);
            this.panel1.Controls.Add(this.btnGoHome);
            this.panel1.Location = new System.Drawing.Point(40, 158);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 251);
            this.panel1.TabIndex = 10;
            // 
            // btnStop
            // 
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(28, 87);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(131, 60);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "STOP Move";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.Enabled = false;
            this.btnEnable.Location = new System.Drawing.Point(28, 16);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(131, 60);
            this.btnEnable.TabIndex = 10;
            this.btnEnable.Text = "Enable Move";
            this.btnEnable.UseVisualStyleBackColor = true;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnMove1
            // 
            this.btnMove1.Enabled = false;
            this.btnMove1.Location = new System.Drawing.Point(32, 105);
            this.btnMove1.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove1.Name = "btnMove1";
            this.btnMove1.Size = new System.Drawing.Size(131, 60);
            this.btnMove1.TabIndex = 12;
            this.btnMove1.Text = "Move";
            this.btnMove1.UseVisualStyleBackColor = true;
            // 
            // tbRegisterVal
            // 
            this.tbRegisterVal.Location = new System.Drawing.Point(133, 22);
            this.tbRegisterVal.Margin = new System.Windows.Forms.Padding(4);
            this.tbRegisterVal.Name = "tbRegisterVal";
            this.tbRegisterVal.Size = new System.Drawing.Size(181, 22);
            this.tbRegisterVal.TabIndex = 11;
            // 
            // btnReadRegister
            // 
            this.btnReadRegister.Location = new System.Drawing.Point(133, 54);
            this.btnReadRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnReadRegister.Name = "btnReadRegister";
            this.btnReadRegister.Size = new System.Drawing.Size(183, 28);
            this.btnReadRegister.TabIndex = 12;
            this.btnReadRegister.Text = "Read Register Value";
            this.btnReadRegister.UseVisualStyleBackColor = true;
            this.btnReadRegister.Click += new System.EventHandler(this.btnReadRegister_Click);
            // 
            // tbShowRegVal
            // 
            this.tbShowRegVal.Location = new System.Drawing.Point(167, 128);
            this.tbShowRegVal.Margin = new System.Windows.Forms.Padding(4);
            this.tbShowRegVal.Name = "tbShowRegVal";
            this.tbShowRegVal.Size = new System.Drawing.Size(108, 22);
            this.tbShowRegVal.TabIndex = 13;
            // 
            // lbRegister
            // 
            this.lbRegister.AutoSize = true;
            this.lbRegister.Location = new System.Drawing.Point(21, 30);
            this.lbRegister.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(61, 16);
            this.lbRegister.TabIndex = 14;
            this.lbRegister.Text = "Register:";
            // 
            // lbRegVal
            // 
            this.lbRegVal.AutoSize = true;
            this.lbRegVal.Location = new System.Drawing.Point(93, 132);
            this.lbRegVal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRegVal.Name = "lbRegVal";
            this.lbRegVal.Size = new System.Drawing.Size(42, 16);
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
            this.panel2.Location = new System.Drawing.Point(623, 33);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 174);
            this.panel2.TabIndex = 16;
            // 
            // tbM1
            // 
            this.tbM1.Enabled = false;
            this.tbM1.Location = new System.Drawing.Point(172, 23);
            this.tbM1.Margin = new System.Windows.Forms.Padding(4);
            this.tbM1.Name = "tbM1";
            this.tbM1.Size = new System.Drawing.Size(132, 22);
            this.tbM1.TabIndex = 17;
            this.tbM1.Text = "192.168.0.211";
            // 
            // tbM2
            // 
            this.tbM2.Enabled = false;
            this.tbM2.Location = new System.Drawing.Point(325, 23);
            this.tbM2.Margin = new System.Windows.Forms.Padding(4);
            this.tbM2.Name = "tbM2";
            this.tbM2.Size = new System.Drawing.Size(132, 22);
            this.tbM2.TabIndex = 18;
            this.tbM2.Text = "192.168.0.212";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMove1);
            this.panel3.Controls.Add(this.btnJogPlus);
            this.panel3.Controls.Add(this.btnJobMinus);
            this.panel3.Location = new System.Drawing.Point(235, 158);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 235);
            this.panel3.TabIndex = 19;
            // 
            // Modbus_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 746);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.tbM2);
            this.Controls.Add(this.tbM1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbClientStatus);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.tbPort);
            this.Controls.Add(this.lbPort);
            this.Controls.Add(this.lbIP);
            this.Location = new System.Drawing.Point(500, 500);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Modbus_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Modbus_Client";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label lbClientStatus;
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
        private System.Windows.Forms.Button btnMove1;
        private System.Windows.Forms.Panel panel3;
    }
}