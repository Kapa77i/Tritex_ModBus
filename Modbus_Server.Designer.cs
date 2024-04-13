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
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.btnStart = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.tabcHolding = new System.Windows.Forms.TabControl();
            this.tabpHolding = new System.Windows.Forms.TabPage();
            this.tabpDigital = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.alias = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabcHolding.SuspendLayout();
            this.tabpHolding.SuspendLayout();
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
            // tabcHolding
            // 
            this.tabcHolding.Controls.Add(this.tabpHolding);
            this.tabcHolding.Controls.Add(this.tabpDigital);
            this.tabcHolding.Location = new System.Drawing.Point(25, 128);
            this.tabcHolding.Name = "tabcHolding";
            this.tabcHolding.SelectedIndex = 0;
            this.tabcHolding.Size = new System.Drawing.Size(460, 265);
            this.tabcHolding.TabIndex = 2;
            this.tabcHolding.TabStop = false;
            // 
            // tabpHolding
            // 
            this.tabpHolding.Controls.Add(this.listView1);
            this.tabpHolding.Location = new System.Drawing.Point(4, 22);
            this.tabpHolding.Name = "tabpHolding";
            this.tabpHolding.Padding = new System.Windows.Forms.Padding(3);
            this.tabpHolding.Size = new System.Drawing.Size(452, 239);
            this.tabpHolding.TabIndex = 0;
            this.tabpHolding.Text = "Holding Registers";
            this.tabpHolding.UseVisualStyleBackColor = true;
            // 
            // tabpDigital
            // 
            this.tabpDigital.Location = new System.Drawing.Point(4, 22);
            this.tabpDigital.Name = "tabpDigital";
            this.tabpDigital.Padding = new System.Windows.Forms.Padding(3);
            this.tabpDigital.Size = new System.Drawing.Size(452, 239);
            this.tabpDigital.TabIndex = 1;
            this.tabpDigital.Text = "Digital Inputs";
            this.tabpDigital.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Address,
            this.Value,
            this.alias});
            listViewGroup1.Header = "ListViewGroup";
            listViewGroup1.Name = "listViewGroup1";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1});
            this.listView1.HideSelection = false;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView1.Location = new System.Drawing.Point(0, 39);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(456, 204);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Tritex_Modbus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 450);
            this.Controls.Add(this.tabcHolding);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.btnStart);
            this.Name = "Tritex_Modbus";
            this.Text = "Tritex Modbus Controller";
            this.tabcHolding.ResumeLayout(false);
            this.tabpHolding.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.TabControl tabcHolding;
        private System.Windows.Forms.TabPage tabpHolding;
        private System.Windows.Forms.TabPage tabpDigital;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Value;
        private System.Windows.Forms.ColumnHeader alias;
    }
}

