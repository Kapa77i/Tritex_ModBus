﻿namespace Tritex_ModBus
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
            this.btnMove2 = new System.Windows.Forms.Button();
            this.tbM1 = new System.Windows.Forms.TextBox();
            this.tbM2 = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMove3 = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnBreak = new System.Windows.Forms.Button();
            this.btnPosition = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.btnIEG_MOD = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbM_Maintained = new System.Windows.Forms.Label();
            this.lbM_Monetary = new System.Windows.Forms.Label();
            this.lbStatusJogPlus = new System.Windows.Forms.Label();
            this.lbStatusJogMinus = new System.Windows.Forms.Label();
            this.lbStatusMove2 = new System.Windows.Forms.Label();
            this.lbStatusMove3 = new System.Windows.Forms.Label();
            this.lbStatusHoming = new System.Windows.Forms.Label();
            this.lbStatusAltMode = new System.Windows.Forms.Label();
            this.btnStatusMain = new System.Windows.Forms.Button();
            this.btnStatusMone = new System.Windows.Forms.Button();
            this.btnStatusJogPlus = new System.Windows.Forms.Button();
            this.btnStatusJogMinus = new System.Windows.Forms.Button();
            this.btnStatusMove2 = new System.Windows.Forms.Button();
            this.btnStatusMove3 = new System.Windows.Forms.Button();
            this.btnStatusHome = new System.Windows.Forms.Button();
            this.btnStatusAltMode = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
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
            this.btnConnect.Location = new System.Drawing.Point(167, 106);
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
            this.lbClientStatus.Location = new System.Drawing.Point(580, 17);
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
            this.btnGoHome.Location = new System.Drawing.Point(188, 21);
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
            this.panel1.Controls.Add(this.btnGoHome);
            this.panel1.Location = new System.Drawing.Point(105, 325);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 103);
            this.panel1.TabIndex = 10;
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.White;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(26, 21);
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
            this.btnEnable.Location = new System.Drawing.Point(29, 19);
            this.btnEnable.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnable.Name = "btnEnable";
            this.btnEnable.Size = new System.Drawing.Size(131, 60);
            this.btnEnable.TabIndex = 10;
            this.btnEnable.Text = "Enable IEG_MOT";
            this.btnEnable.UseVisualStyleBackColor = false;
            this.btnEnable.Click += new System.EventHandler(this.btnEnable_Click);
            // 
            // btnMove2
            // 
            this.btnMove2.BackColor = System.Drawing.Color.White;
            this.btnMove2.Enabled = false;
            this.btnMove2.Location = new System.Drawing.Point(32, 105);
            this.btnMove2.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove2.Name = "btnMove2";
            this.btnMove2.Size = new System.Drawing.Size(131, 60);
            this.btnMove2.TabIndex = 12;
            this.btnMove2.Text = "Move 2";
            this.btnMove2.UseVisualStyleBackColor = false;
            this.btnMove2.Click += new System.EventHandler(this.btnMove2_Click);
            // 
            // tbM1
            // 
            this.tbM1.Enabled = false;
            this.tbM1.Location = new System.Drawing.Point(172, 30);
            this.tbM1.Margin = new System.Windows.Forms.Padding(4);
            this.tbM1.Name = "tbM1";
            this.tbM1.Size = new System.Drawing.Size(113, 22);
            this.tbM1.TabIndex = 17;
            this.tbM1.Text = "192.168.0.211";
            // 
            // tbM2
            // 
            this.tbM2.Enabled = false;
            this.tbM2.Location = new System.Drawing.Point(293, 30);
            this.tbM2.Margin = new System.Windows.Forms.Padding(4);
            this.tbM2.Name = "tbM2";
            this.tbM2.Size = new System.Drawing.Size(112, 22);
            this.tbM2.TabIndex = 18;
            this.tbM2.Text = "192.168.0.212";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMove3);
            this.panel3.Controls.Add(this.btnMove2);
            this.panel3.Controls.Add(this.btnJogPlus);
            this.panel3.Controls.Add(this.btnJogMinus);
            this.panel3.Location = new System.Drawing.Point(13, 432);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(334, 192);
            this.panel3.TabIndex = 19;
            // 
            // btnMove3
            // 
            this.btnMove3.BackColor = System.Drawing.Color.White;
            this.btnMove3.Enabled = false;
            this.btnMove3.Location = new System.Drawing.Point(172, 105);
            this.btnMove3.Margin = new System.Windows.Forms.Padding(4);
            this.btnMove3.Name = "btnMove3";
            this.btnMove3.Size = new System.Drawing.Size(131, 60);
            this.btnMove3.TabIndex = 13;
            this.btnMove3.Text = "Move 3";
            this.btnMove3.UseVisualStyleBackColor = false;
            this.btnMove3.Click += new System.EventHandler(this.btnMove3_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnBreak);
            this.panel4.Controls.Add(this.btnPosition);
            this.panel4.Location = new System.Drawing.Point(369, 432);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(178, 201);
            this.panel4.TabIndex = 21;
            // 
            // btnBreak
            // 
            this.btnBreak.BackColor = System.Drawing.Color.White;
            this.btnBreak.Enabled = false;
            this.btnBreak.Location = new System.Drawing.Point(20, 105);
            this.btnBreak.Margin = new System.Windows.Forms.Padding(4);
            this.btnBreak.Name = "btnBreak";
            this.btnBreak.Size = new System.Drawing.Size(131, 60);
            this.btnBreak.TabIndex = 12;
            this.btnBreak.Text = "Override Breaks";
            this.btnBreak.UseVisualStyleBackColor = false;
            this.btnBreak.Click += new System.EventHandler(this.btnBreak_Click);
            // 
            // btnPosition
            // 
            this.btnPosition.BackColor = System.Drawing.Color.White;
            this.btnPosition.Enabled = false;
            this.btnPosition.Location = new System.Drawing.Point(20, 25);
            this.btnPosition.Margin = new System.Windows.Forms.Padding(4);
            this.btnPosition.Name = "btnPosition";
            this.btnPosition.Size = new System.Drawing.Size(131, 60);
            this.btnPosition.TabIndex = 10;
            this.btnPosition.Text = "Position";
            this.btnPosition.UseVisualStyleBackColor = false;
            this.btnPosition.Click += new System.EventHandler(this.btnPosition_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.BackColor = System.Drawing.Color.White;
            this.btnAlt.Enabled = false;
            this.btnAlt.Location = new System.Drawing.Point(357, 19);
            this.btnAlt.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(131, 60);
            this.btnAlt.TabIndex = 8;
            this.btnAlt.Text = "Alternate Mode";
            this.btnAlt.UseVisualStyleBackColor = false;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // btnIEG_MOD
            // 
            this.btnIEG_MOD.BackColor = System.Drawing.Color.White;
            this.btnIEG_MOD.Enabled = false;
            this.btnIEG_MOD.Location = new System.Drawing.Point(168, 19);
            this.btnIEG_MOD.Margin = new System.Windows.Forms.Padding(4);
            this.btnIEG_MOD.Name = "btnIEG_MOD";
            this.btnIEG_MOD.Size = new System.Drawing.Size(131, 60);
            this.btnIEG_MOD.TabIndex = 12;
            this.btnIEG_MOD.Text = "Enable IEG_MOD";
            this.btnIEG_MOD.UseVisualStyleBackColor = false;
            this.btnIEG_MOD.Click += new System.EventHandler(this.btnIEG_MOD_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnIEG_MOD);
            this.panel5.Controls.Add(this.btnEnable);
            this.panel5.Controls.Add(this.btnAlt);
            this.panel5.Location = new System.Drawing.Point(12, 220);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(518, 101);
            this.panel5.TabIndex = 22;
            // 
            // lbM_Maintained
            // 
            this.lbM_Maintained.AutoSize = true;
            this.lbM_Maintained.Location = new System.Drawing.Point(597, 72);
            this.lbM_Maintained.Name = "lbM_Maintained";
            this.lbM_Maintained.Size = new System.Drawing.Size(110, 16);
            this.lbM_Maintained.TabIndex = 23;
            this.lbM_Maintained.Text = "Maintained Move";
            // 
            // lbM_Monetary
            // 
            this.lbM_Monetary.AutoSize = true;
            this.lbM_Monetary.Location = new System.Drawing.Point(598, 104);
            this.lbM_Monetary.Name = "lbM_Monetary";
            this.lbM_Monetary.Size = new System.Drawing.Size(100, 16);
            this.lbM_Monetary.TabIndex = 24;
            this.lbM_Monetary.Text = "Monetary Move";
            // 
            // lbStatusJogPlus
            // 
            this.lbStatusJogPlus.AutoSize = true;
            this.lbStatusJogPlus.Location = new System.Drawing.Point(598, 136);
            this.lbStatusJogPlus.Name = "lbStatusJogPlus";
            this.lbStatusJogPlus.Size = new System.Drawing.Size(37, 16);
            this.lbStatusJogPlus.TabIndex = 26;
            this.lbStatusJogPlus.Text = "Jog+";
            // 
            // lbStatusJogMinus
            // 
            this.lbStatusJogMinus.AutoSize = true;
            this.lbStatusJogMinus.Location = new System.Drawing.Point(598, 169);
            this.lbStatusJogMinus.Name = "lbStatusJogMinus";
            this.lbStatusJogMinus.Size = new System.Drawing.Size(34, 16);
            this.lbStatusJogMinus.TabIndex = 27;
            this.lbStatusJogMinus.Text = "Jog-";
            // 
            // lbStatusMove2
            // 
            this.lbStatusMove2.AutoSize = true;
            this.lbStatusMove2.Location = new System.Drawing.Point(598, 206);
            this.lbStatusMove2.Name = "lbStatusMove2";
            this.lbStatusMove2.Size = new System.Drawing.Size(51, 16);
            this.lbStatusMove2.TabIndex = 28;
            this.lbStatusMove2.Text = "Move 2";
            // 
            // lbStatusMove3
            // 
            this.lbStatusMove3.AutoSize = true;
            this.lbStatusMove3.Location = new System.Drawing.Point(598, 244);
            this.lbStatusMove3.Name = "lbStatusMove3";
            this.lbStatusMove3.Size = new System.Drawing.Size(51, 16);
            this.lbStatusMove3.TabIndex = 29;
            this.lbStatusMove3.Text = "Move 3";
            // 
            // lbStatusHoming
            // 
            this.lbStatusHoming.AutoSize = true;
            this.lbStatusHoming.Location = new System.Drawing.Point(598, 282);
            this.lbStatusHoming.Name = "lbStatusHoming";
            this.lbStatusHoming.Size = new System.Drawing.Size(44, 16);
            this.lbStatusHoming.TabIndex = 30;
            this.lbStatusHoming.Text = "Home";
            // 
            // lbStatusAltMode
            // 
            this.lbStatusAltMode.AutoSize = true;
            this.lbStatusAltMode.Location = new System.Drawing.Point(598, 314);
            this.lbStatusAltMode.Name = "lbStatusAltMode";
            this.lbStatusAltMode.Size = new System.Drawing.Size(60, 16);
            this.lbStatusAltMode.TabIndex = 31;
            this.lbStatusAltMode.Text = "Alt Mode";
            // 
            // btnStatusMain
            // 
            this.btnStatusMain.BackColor = System.Drawing.SystemColors.Window;
            this.btnStatusMain.Location = new System.Drawing.Point(745, 72);
            this.btnStatusMain.Name = "btnStatusMain";
            this.btnStatusMain.Size = new System.Drawing.Size(18, 16);
            this.btnStatusMain.TabIndex = 32;
            this.btnStatusMain.UseVisualStyleBackColor = false;
            // 
            // btnStatusMone
            // 
            this.btnStatusMone.BackColor = System.Drawing.SystemColors.Window;
            this.btnStatusMone.Location = new System.Drawing.Point(745, 104);
            this.btnStatusMone.Name = "btnStatusMone";
            this.btnStatusMone.Size = new System.Drawing.Size(18, 16);
            this.btnStatusMone.TabIndex = 33;
            this.btnStatusMone.UseVisualStyleBackColor = false;
            // 
            // btnStatusJogPlus
            // 
            this.btnStatusJogPlus.BackColor = System.Drawing.SystemColors.Window;
            this.btnStatusJogPlus.Location = new System.Drawing.Point(745, 136);
            this.btnStatusJogPlus.Name = "btnStatusJogPlus";
            this.btnStatusJogPlus.Size = new System.Drawing.Size(18, 15);
            this.btnStatusJogPlus.TabIndex = 34;
            this.btnStatusJogPlus.UseVisualStyleBackColor = false;
            // 
            // btnStatusJogMinus
            // 
            this.btnStatusJogMinus.BackColor = System.Drawing.SystemColors.Window;
            this.btnStatusJogMinus.Location = new System.Drawing.Point(745, 170);
            this.btnStatusJogMinus.Name = "btnStatusJogMinus";
            this.btnStatusJogMinus.Size = new System.Drawing.Size(18, 15);
            this.btnStatusJogMinus.TabIndex = 35;
            this.btnStatusJogMinus.UseVisualStyleBackColor = false;
            // 
            // btnStatusMove2
            // 
            this.btnStatusMove2.BackColor = System.Drawing.SystemColors.Window;
            this.btnStatusMove2.Location = new System.Drawing.Point(745, 206);
            this.btnStatusMove2.Name = "btnStatusMove2";
            this.btnStatusMove2.Size = new System.Drawing.Size(18, 15);
            this.btnStatusMove2.TabIndex = 36;
            this.btnStatusMove2.UseVisualStyleBackColor = false;
            // 
            // btnStatusMove3
            // 
            this.btnStatusMove3.BackColor = System.Drawing.SystemColors.Window;
            this.btnStatusMove3.Location = new System.Drawing.Point(745, 244);
            this.btnStatusMove3.Name = "btnStatusMove3";
            this.btnStatusMove3.Size = new System.Drawing.Size(18, 15);
            this.btnStatusMove3.TabIndex = 37;
            this.btnStatusMove3.UseVisualStyleBackColor = false;
            // 
            // btnStatusHome
            // 
            this.btnStatusHome.BackColor = System.Drawing.SystemColors.Window;
            this.btnStatusHome.Location = new System.Drawing.Point(745, 282);
            this.btnStatusHome.Name = "btnStatusHome";
            this.btnStatusHome.Size = new System.Drawing.Size(18, 15);
            this.btnStatusHome.TabIndex = 38;
            this.btnStatusHome.UseVisualStyleBackColor = false;
            // 
            // btnStatusAltMode
            // 
            this.btnStatusAltMode.BackColor = System.Drawing.SystemColors.Window;
            this.btnStatusAltMode.Location = new System.Drawing.Point(745, 314);
            this.btnStatusAltMode.Name = "btnStatusAltMode";
            this.btnStatusAltMode.Size = new System.Drawing.Size(18, 15);
            this.btnStatusAltMode.TabIndex = 39;
            this.btnStatusAltMode.UseVisualStyleBackColor = false;
            // 
            // Modbus_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 746);
            this.Controls.Add(this.btnStatusAltMode);
            this.Controls.Add(this.btnStatusHome);
            this.Controls.Add(this.btnStatusMove3);
            this.Controls.Add(this.btnStatusMove2);
            this.Controls.Add(this.btnStatusJogMinus);
            this.Controls.Add(this.btnStatusJogPlus);
            this.Controls.Add(this.btnStatusMone);
            this.Controls.Add(this.btnStatusMain);
            this.Controls.Add(this.lbStatusAltMode);
            this.Controls.Add(this.lbStatusHoming);
            this.Controls.Add(this.lbStatusMove3);
            this.Controls.Add(this.lbStatusMove2);
            this.Controls.Add(this.lbStatusJogMinus);
            this.Controls.Add(this.lbStatusJogPlus);
            this.Controls.Add(this.lbM_Monetary);
            this.Controls.Add(this.lbM_Maintained);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
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
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnMove2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnPosition;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.Button btnBreak;
        private System.Windows.Forms.Button btnMove3;
        private System.Windows.Forms.Button btnIEG_MOD;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbM_Maintained;
        private System.Windows.Forms.Label lbM_Monetary;
        private System.Windows.Forms.Label lbStatusJogPlus;
        private System.Windows.Forms.Label lbStatusJogMinus;
        private System.Windows.Forms.Label lbStatusMove2;
        private System.Windows.Forms.Label lbStatusMove3;
        private System.Windows.Forms.Label lbStatusHoming;
        private System.Windows.Forms.Label lbStatusAltMode;
        private System.Windows.Forms.Button btnStatusMain;
        private System.Windows.Forms.Button btnStatusMone;
        private System.Windows.Forms.Button btnStatusJogPlus;
        private System.Windows.Forms.Button btnStatusJogMinus;
        private System.Windows.Forms.Button btnStatusMove2;
        private System.Windows.Forms.Button btnStatusMove3;
        private System.Windows.Forms.Button btnStatusHome;
        private System.Windows.Forms.Button btnStatusAltMode;
    }
}