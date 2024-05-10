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
            this.btnJogMinus = new System.Windows.Forms.Button();
            this.btnGoHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnEnable = new System.Windows.Forms.Button();
            this.btnMove1 = new System.Windows.Forms.Button();
            this.tbM1 = new System.Windows.Forms.TextBox();
            this.tbM2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMove1Terminate = new System.Windows.Forms.Button();
            this.btnMove2 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnVelocity = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnTorque = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
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
            this.lbClientStatus.Location = new System.Drawing.Point(560, 9);
            this.lbClientStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbClientStatus.Name = "lbClientStatus";
            this.lbClientStatus.Size = new System.Drawing.Size(169, 24);
            this.lbClientStatus.TabIndex = 5;
            this.lbClientStatus.Text = "Client Connection: ";
            // 
            // btnJogPlus
            // 
            this.btnJogPlus.BackColor = System.Drawing.Color.White;
            this.btnJogPlus.Enabled = false;
            this.btnJogPlus.Location = new System.Drawing.Point(33, 25);
            this.btnJogPlus.Margin = new System.Windows.Forms.Padding(4);
            this.btnJogPlus.Name = "btnJogPlus";
            this.btnJogPlus.Size = new System.Drawing.Size(131, 60);
            this.btnJogPlus.TabIndex = 7;
            this.btnJogPlus.Text = "Jog+";
            this.btnJogPlus.UseVisualStyleBackColor = false;
            this.btnJogPlus.Click += new System.EventHandler(this.btnJogPlus_Click);
            // 
            // btnJogMinus
            // 
            this.btnJogMinus.BackColor = System.Drawing.Color.White;
            this.btnJogMinus.Enabled = false;
            this.btnJogMinus.Location = new System.Drawing.Point(172, 25);
            this.btnJogMinus.Margin = new System.Windows.Forms.Padding(4);
            this.btnJogMinus.Name = "btnJogMinus";
            this.btnJogMinus.Size = new System.Drawing.Size(131, 60);
            this.btnJogMinus.TabIndex = 8;
            this.btnJogMinus.Text = "Jog-";
            this.btnJogMinus.UseVisualStyleBackColor = false;
            this.btnJogMinus.Click += new System.EventHandler(this.btnJogMinus_Click);
            // 
            // btnGoHome
            // 
            this.btnGoHome.BackColor = System.Drawing.Color.White;
            this.btnGoHome.Enabled = false;
            this.btnGoHome.Location = new System.Drawing.Point(28, 160);
            this.btnGoHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnGoHome.Name = "btnGoHome";
            this.btnGoHome.Size = new System.Drawing.Size(131, 60);
            this.btnGoHome.TabIndex = 9;
            this.btnGoHome.Text = "Go Home";
            this.btnGoHome.UseVisualStyleBackColor = false;
            this.btnGoHome.Click += new System.EventHandler(this.btnGoHome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnStop);
            this.panel1.Controls.Add(this.btnEnable);
            this.panel1.Controls.Add(this.btnGoHome);
            this.panel1.Location = new System.Drawing.Point(26, 19);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 251);
            this.panel1.TabIndex = 10;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(28, 87);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(131, 60);
            this.btnStop.TabIndex = 11;
            this.btnStop.Text = "STOP Move";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnEnable
            // 
            this.btnEnable.BackColor = System.Drawing.Color.White;
            this.btnEnable.Enabled = false;
            this.btnEnable.Location = new System.Drawing.Point(28, 16);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(131, 60);
            this.btnEnable.TabIndex = 10;
            this.btnEnable.Text = "Enable Move";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnMove1
            // 
            this.btnMove1.BackColor = System.Drawing.Color.White;
            this.btnMove1.Enabled = false;
            this.btnMove1.Location = new System.Drawing.Point(32, 105);
            this.btnMove1.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove1.Name = "btnMove1";
            this.btnMove1.Size = new System.Drawing.Size(131, 60);
            this.btnMove1.TabIndex = 12;
            this.btnMove1.Text = "Move 2";
            this.btnMove1.UseVisualStyleBackColor = false;
            this.btnMove1.Click += new System.EventHandler(this.btnMove1_Click);
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
            this.panel3.Controls.Add(this.btnMove1Terminate);
            this.panel3.Controls.Add(this.btnMove2);
            this.panel3.Controls.Add(this.btnMove1);
            this.panel3.Controls.Add(this.btnJogPlus);
            this.panel3.Controls.Add(this.btnJogMinus);
            this.panel3.Location = new System.Drawing.Point(221, 19);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(351, 270);
            this.panel3.TabIndex = 19;
            // 
            // btnMove1Terminate
            // 
            this.btnMove1Terminate.BackColor = System.Drawing.Color.White;
            this.btnMove1Terminate.Enabled = false;
            this.btnMove1Terminate.Location = new System.Drawing.Point(32, 185);
            this.btnMove1Terminate.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove1Terminate.Name = "btnMove1Terminate";
            this.btnMove1Terminate.Size = new System.Drawing.Size(131, 60);
            this.btnMove1Terminate.TabIndex = 14;
            this.btnMove1Terminate.Text = "End Move Lvl";
            this.btnMove1Terminate.UseVisualStyleBackColor = false;
            this.btnMove1Terminate.Click += new System.EventHandler(this.btnMove1Terminate_Click);
            // 
            // btnMove2
            // 
            this.btnMove2.BackColor = System.Drawing.Color.White;
            this.btnMove2.Enabled = false;
            this.btnMove2.Location = new System.Drawing.Point(171, 105);
            this.btnMove2.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove2.Name = "btnMove2";
            this.btnMove2.Size = new System.Drawing.Size(131, 60);
            this.btnMove2.TabIndex = 13;
            this.btnMove2.Text = "Move Edge Initiate";
            this.btnMove2.UseVisualStyleBackColor = false;
            this.btnMove2.Click += new System.EventHandler(this.btnMove2_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Location = new System.Drawing.Point(12, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(596, 315);
            this.panel2.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnTorque);
            this.panel4.Controls.Add(this.btnPosition);
            this.panel4.Controls.Add(this.btnVelocity);
            this.panel4.Controls.Add(this.btnAlt);
            this.panel4.Location = new System.Drawing.Point(667, 201);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(586, 317);
            this.panel4.TabIndex = 21;
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.Color.White;
            this.btnAlt.Enabled = false;
            this.btnAlt.Location = new System.Drawing.Point(33, 22);
            this.btnAlt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(131, 60);
            this.btnAlt.TabIndex = 8;
            this.btnAlt.Text = "Alternate Mode";
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnVelocity
            // 
            this.btnVelocity.BackColor = System.Drawing.Color.White;
            this.btnVelocity.Enabled = false;
            this.btnVelocity.Location = new System.Drawing.Point(228, 99);
            this.btnVelocity.Margin = new System.Windows.Forms.Padding(4);
            this.btnVelocity.Name = "btnVelocity";
            this.btnVelocity.Size = new System.Drawing.Size(131, 60);
            this.btnVelocity.TabIndex = 9;
            this.btnVelocity.Text = "Velocity";
            this.btnVelocity.UseVisualStyleBackColor = false;
            // 
            // btnPosition
            // 
            this.btnPosition.BackColor = System.Drawing.Color.White;
            this.btnPosition.Enabled = false;
            this.btnPosition.Location = new System.Drawing.Point(228, 22);
            this.btnPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(131, 60);
            this.btnPosition.TabIndex = 10;
            this.btnPosition.Text = "Position";
            this.btnPosition.UseVisualStyleBackColor = false;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnTorque
            // 
            this.btnTorque.BackColor = System.Drawing.Color.White;
            this.btnTorque.Enabled = false;
            this.btnTorque.Location = new System.Drawing.Point(228, 177);
            this.btnTorque.Margin = new System.Windows.Forms.Padding(4);
            this.btnTorque.Name = "btnTorque";
            this.btnTorque.Size = new System.Drawing.Size(131, 60);
            this.btnTorque.TabIndex = 11;
            this.btnTorque.Text = "Torque";
            this.btnTorque.UseVisualStyleBackColor = false;
            // 
            // Modbus_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 746);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tbM2);
            this.Controls.Add(this.tbM1);
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
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnJogMinus;
        private System.Windows.Forms.Button btnGoHome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEnable;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.TextBox tbM1;
        private System.Windows.Forms.TextBox tbM2;
        private System.Windows.Forms.Button btnMove1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnMove2;
        private System.Windows.Forms.Button btnMove1Terminate;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnTorque;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnVelocity;
        private System.Windows.Forms.Button btnAlt;
    }
}