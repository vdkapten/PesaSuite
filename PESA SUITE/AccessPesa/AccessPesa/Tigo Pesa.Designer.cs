namespace AccessPesa
{
    partial class Tigo_Pesa
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
            this.TigoLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.EzyPesaButton = new System.Windows.Forms.Button();
            this.VodacomMpesaButton = new System.Windows.Forms.Button();
            this.AirtelMoneyButton = new System.Windows.Forms.Button();
            this.Crdb_BankButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.NewEntry = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SN = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FloatBalance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransactionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransactionType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TransactionValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CusomerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerCellphone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerIDType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Report = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TigoLabel
            // 
            this.TigoLabel.AutoSize = true;
            this.TigoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TigoLabel.ForeColor = System.Drawing.Color.White;
            this.TigoLabel.Location = new System.Drawing.Point(65, 23);
            this.TigoLabel.Name = "TigoLabel";
            this.TigoLabel.Size = new System.Drawing.Size(141, 29);
            this.TigoLabel.TabIndex = 15;
            this.TigoLabel.Text = "TIGO PESA";
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(398, 18);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 31);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // EzyPesaButton
            // 
            this.EzyPesaButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EzyPesaButton.Location = new System.Drawing.Point(286, 15);
            this.EzyPesaButton.Name = "EzyPesaButton";
            this.EzyPesaButton.Size = new System.Drawing.Size(134, 34);
            this.EzyPesaButton.TabIndex = 13;
            this.EzyPesaButton.Text = "EZY PESA";
            this.EzyPesaButton.UseVisualStyleBackColor = true;
            // 
            // VodacomMpesaButton
            // 
            this.VodacomMpesaButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VodacomMpesaButton.Location = new System.Drawing.Point(429, 15);
            this.VodacomMpesaButton.Name = "VodacomMpesaButton";
            this.VodacomMpesaButton.Size = new System.Drawing.Size(134, 34);
            this.VodacomMpesaButton.TabIndex = 10;
            this.VodacomMpesaButton.Text = "VODACOM M-PESA";
            this.VodacomMpesaButton.UseVisualStyleBackColor = true;
            // 
            // AirtelMoneyButton
            // 
            this.AirtelMoneyButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AirtelMoneyButton.Location = new System.Drawing.Point(6, 15);
            this.AirtelMoneyButton.Name = "AirtelMoneyButton";
            this.AirtelMoneyButton.Size = new System.Drawing.Size(134, 34);
            this.AirtelMoneyButton.TabIndex = 12;
            this.AirtelMoneyButton.Text = "AIRTEL MONEY";
            this.AirtelMoneyButton.UseVisualStyleBackColor = true;
            // 
            // Crdb_BankButton
            // 
            this.Crdb_BankButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Crdb_BankButton.Location = new System.Drawing.Point(146, 15);
            this.Crdb_BankButton.Name = "Crdb_BankButton";
            this.Crdb_BankButton.Size = new System.Drawing.Size(134, 34);
            this.Crdb_BankButton.TabIndex = 11;
            this.Crdb_BankButton.Text = "CRDB BANK";
            this.Crdb_BankButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.EzyPesaButton);
            this.groupBox1.Controls.Add(this.VodacomMpesaButton);
            this.groupBox1.Controls.Add(this.AirtelMoneyButton);
            this.groupBox1.Controls.Add(this.Crdb_BankButton);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.ForeColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Location = new System.Drawing.Point(509, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(569, 57);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Switch To";
            // 
            // NewEntry
            // 
            this.NewEntry.Location = new System.Drawing.Point(574, 605);
            this.NewEntry.Name = "NewEntry";
            this.NewEntry.Size = new System.Drawing.Size(106, 35);
            this.NewEntry.TabIndex = 12;
            this.NewEntry.Text = "New Entry";
            this.NewEntry.UseVisualStyleBackColor = true;
            this.NewEntry.Click += new System.EventHandler(this.NewEntry_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SN,
            this.Date,
            this.FloatBalance,
            this.TransactionID,
            this.TransactionType,
            this.TransactionValue,
            this.CusomerName,
            this.CustomerCellphone,
            this.CustomerID,
            this.CustomerIDType});
            this.listView1.Location = new System.Drawing.Point(70, 66);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1111, 533);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // SN
            // 
            this.SN.Text = "S/N";
            this.SN.Width = 36;
            // 
            // Date
            // 
            this.Date.Text = "Date";
            this.Date.Width = 100;
            // 
            // FloatBalance
            // 
            this.FloatBalance.Text = "Float Balance";
            this.FloatBalance.Width = 114;
            // 
            // TransactionID
            // 
            this.TransactionID.Text = "Transaction ID";
            this.TransactionID.Width = 106;
            // 
            // TransactionType
            // 
            this.TransactionType.Text = "Transaction Type";
            this.TransactionType.Width = 108;
            // 
            // TransactionValue
            // 
            this.TransactionValue.Text = "TransactionValue";
            this.TransactionValue.Width = 134;
            // 
            // CusomerName
            // 
            this.CusomerName.Text = "Customer Name";
            this.CusomerName.Width = 153;
            // 
            // CustomerCellphone
            // 
            this.CustomerCellphone.Text = "Customer Cellphone #";
            this.CustomerCellphone.Width = 119;
            // 
            // CustomerID
            // 
            this.CustomerID.Text = "Customer ID #";
            this.CustomerID.Width = 129;
            // 
            // CustomerIDType
            // 
            this.CustomerIDType.Text = "Customer ID Type";
            this.CustomerIDType.Width = 113;
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(1087, 18);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(94, 31);
            this.Report.TabIndex = 16;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::AccessPesa.Properties.Resources.TigoPesa;
            this.pictureBox1.Location = new System.Drawing.Point(11, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // Tigo_Pesa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1244, 642);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.TigoLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NewEntry);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Tigo_Pesa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tigo Pesa";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TigoLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EzyPesaButton;
        private System.Windows.Forms.Button VodacomMpesaButton;
        private System.Windows.Forms.Button AirtelMoneyButton;
        private System.Windows.Forms.Button Crdb_BankButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button NewEntry;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader SN;
        private System.Windows.Forms.ColumnHeader Date;
        private System.Windows.Forms.ColumnHeader FloatBalance;
        private System.Windows.Forms.ColumnHeader TransactionID;
        private System.Windows.Forms.ColumnHeader TransactionType;
        private System.Windows.Forms.ColumnHeader TransactionValue;
        private System.Windows.Forms.ColumnHeader CusomerName;
        private System.Windows.Forms.ColumnHeader CustomerCellphone;
        private System.Windows.Forms.ColumnHeader CustomerID;
        private System.Windows.Forms.ColumnHeader CustomerIDType;
        private System.Windows.Forms.Button Report;
    }
}