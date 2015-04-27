namespace AccessPesa
{
    partial class Airtel_Money
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
            this.VodacomMpesaButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EzyPesaButton = new System.Windows.Forms.Button();
            this.CrdbBank = new System.Windows.Forms.Button();
            this.TigoPesaButton = new System.Windows.Forms.Button();
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
            this.BackButton = new System.Windows.Forms.Button();
            this.Airteltxt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.AirtelPic = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AirtelPic)).BeginInit();
            this.SuspendLayout();
            // 
            // VodacomMpesaButton
            // 
            this.VodacomMpesaButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VodacomMpesaButton.Location = new System.Drawing.Point(289, 15);
            this.VodacomMpesaButton.Name = "VodacomMpesaButton";
            this.VodacomMpesaButton.Size = new System.Drawing.Size(134, 34);
            this.VodacomMpesaButton.TabIndex = 3;
            this.VodacomMpesaButton.Text = "VODACOM M-PESA";
            this.VodacomMpesaButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkRed;
            this.groupBox1.Controls.Add(this.EzyPesaButton);
            this.groupBox1.Controls.Add(this.CrdbBank);
            this.groupBox1.Controls.Add(this.TigoPesaButton);
            this.groupBox1.Controls.Add(this.VodacomMpesaButton);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.groupBox1.ForeColor = System.Drawing.Color.MistyRose;
            this.groupBox1.Location = new System.Drawing.Point(509, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox1.Size = new System.Drawing.Size(569, 57);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Switch To";
            // 
            // EzyPesaButton
            // 
            this.EzyPesaButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.EzyPesaButton.Location = new System.Drawing.Point(6, 15);
            this.EzyPesaButton.Name = "EzyPesaButton";
            this.EzyPesaButton.Size = new System.Drawing.Size(134, 34);
            this.EzyPesaButton.TabIndex = 6;
            this.EzyPesaButton.Text = "EZY PESA";
            this.EzyPesaButton.UseVisualStyleBackColor = true;
            this.EzyPesaButton.Click += new System.EventHandler(this.EzyPesaButton_Click);
            // 
            // CrdbBank
            // 
            this.CrdbBank.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CrdbBank.Location = new System.Drawing.Point(429, 15);
            this.CrdbBank.Name = "CrdbBank";
            this.CrdbBank.Size = new System.Drawing.Size(134, 34);
            this.CrdbBank.TabIndex = 5;
            this.CrdbBank.Text = "CRDB BANK";
            this.CrdbBank.UseVisualStyleBackColor = true;
            this.CrdbBank.Click += new System.EventHandler(this.CrdbBank_Click);
            // 
            // TigoPesaButton
            // 
            this.TigoPesaButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TigoPesaButton.Location = new System.Drawing.Point(146, 15);
            this.TigoPesaButton.Name = "TigoPesaButton";
            this.TigoPesaButton.Size = new System.Drawing.Size(134, 34);
            this.TigoPesaButton.TabIndex = 4;
            this.TigoPesaButton.Text = "TIGO PESA";
            this.TigoPesaButton.UseVisualStyleBackColor = true;
            // 
            // NewEntry
            // 
            this.NewEntry.Location = new System.Drawing.Point(574, 605);
            this.NewEntry.Name = "NewEntry";
            this.NewEntry.Size = new System.Drawing.Size(106, 35);
            this.NewEntry.TabIndex = 11;
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
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(398, 18);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(94, 31);
            this.BackButton.TabIndex = 4;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Airteltxt
            // 
            this.Airteltxt.AutoSize = true;
            this.Airteltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Airteltxt.ForeColor = System.Drawing.Color.White;
            this.Airteltxt.Location = new System.Drawing.Point(66, 24);
            this.Airteltxt.Name = "Airteltxt";
            this.Airteltxt.Size = new System.Drawing.Size(191, 29);
            this.Airteltxt.TabIndex = 14;
            this.Airteltxt.Text = "AIRTEL MONEY";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1087, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 31);
            this.button1.TabIndex = 15;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AirtelPic
            // 
            this.AirtelPic.Image = global::AccessPesa.Properties.Resources.AirtelMoney;
            this.AirtelPic.Location = new System.Drawing.Point(12, 12);
            this.AirtelPic.Name = "AirtelPic";
            this.AirtelPic.Size = new System.Drawing.Size(48, 48);
            this.AirtelPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AirtelPic.TabIndex = 13;
            this.AirtelPic.TabStop = false;
            // 
            // Airtel_Money
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(1244, 642);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Airteltxt);
            this.Controls.Add(this.AirtelPic);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.NewEntry);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Airtel_Money";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Airtel_Money";
            this.Activated += new System.EventHandler(this.Airtel_Money_Activated);
            this.Load += new System.EventHandler(this.Airtel_Money_Activated);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AirtelPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button VodacomMpesaButton;
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
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button EzyPesaButton;
        private System.Windows.Forms.Button CrdbBank;
        private System.Windows.Forms.Button TigoPesaButton;
        private System.Windows.Forms.PictureBox AirtelPic;
        private System.Windows.Forms.Label Airteltxt;
        private System.Windows.Forms.Button button1;
    }
}