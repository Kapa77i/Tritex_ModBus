namespace Tritex_ModBus
{
    partial class Tritex_Modbus
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
            this.btnStart = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.brpData = new System.Windows.Forms.GroupBox();
            this.cbRegisterType = new System.Windows.Forms.ComboBox();
            this.lbRegisterType = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRegisterAddress = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSet = new System.Windows.Forms.Button();
            this.brpData.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(178, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(158, 68);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(12, 428);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(127, 13);
            this.lbStatus.TabIndex = 1;
            this.lbStatus.Text = "Status of the Connection:";
            // 
            // brpData
            // 
            this.brpData.Controls.Add(this.btnSet);
            this.brpData.Controls.Add(this.textBox2);
            this.brpData.Controls.Add(this.label2);
            this.brpData.Controls.Add(this.textBox1);
            this.brpData.Controls.Add(this.lbRegisterAddress);
            this.brpData.Controls.Add(this.cbRegisterType);
            this.brpData.Controls.Add(this.lbRegisterType);
            this.brpData.Controls.Add(this.label1);
            this.brpData.Location = new System.Drawing.Point(12, 144);
            this.brpData.Name = "brpData";
            this.brpData.Size = new System.Drawing.Size(324, 210);
            this.brpData.TabIndex = 2;
            this.brpData.TabStop = false;
            this.brpData.Text = "Change the Data";
            // 
            // cbRegisterType
            // 
            this.cbRegisterType.FormattingEnabled = true;
            this.cbRegisterType.Items.AddRange(new object[] {
            "Holding Register",
            "Input Register",
            "Digital Input",
            "Coil Output"});
            this.cbRegisterType.Location = new System.Drawing.Point(123, 20);
            this.cbRegisterType.Name = "cbRegisterType";
            this.cbRegisterType.Size = new System.Drawing.Size(176, 21);
            this.cbRegisterType.TabIndex = 2;
            // 
            // lbRegisterType
            // 
            this.lbRegisterType.AutoSize = true;
            this.lbRegisterType.Location = new System.Drawing.Point(6, 23);
            this.lbRegisterType.Name = "lbRegisterType";
            this.lbRegisterType.Size = new System.Drawing.Size(73, 13);
            this.lbRegisterType.TabIndex = 1;
            this.lbRegisterType.Text = "Register Type";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            // 
            // lbRegisterAddress
            // 
            this.lbRegisterAddress.AutoSize = true;
            this.lbRegisterAddress.Location = new System.Drawing.Point(6, 76);
            this.lbRegisterAddress.Name = "lbRegisterAddress";
            this.lbRegisterAddress.Size = new System.Drawing.Size(87, 13);
            this.lbRegisterAddress.TabIndex = 3;
            this.lbRegisterAddress.Text = "Register Address";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(123, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(123, 118);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(176, 20);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Set Value";
            // 
            // btnSet
            // 
            this.btnSet.Location = new System.Drawing.Point(123, 159);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(75, 28);
            this.btnSet.TabIndex = 7;
            this.btnSet.Text = "Set";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // Tritex_Modbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.brpData);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnStart);
            this.Name = "Tritex_Modbus";
            this.Text = "Tritex Modbus Controller";
            this.brpData.ResumeLayout(false);
            this.brpData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.GroupBox brpData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbRegisterType;
        private System.Windows.Forms.Label lbRegisterType;
        private System.Windows.Forms.Label lbRegisterAddress;
        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

