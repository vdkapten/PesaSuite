using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessPesa
{
    public partial class EntryForm : Form
    {
        private Boolean error;
        public Airtel_Money formtoairtel;
        public Ezy_Pesa formtoezy;
        public Tigo_Pesa formtotigo;
        public Vodacom_Mpesa formtovoda;
        public CRDB_Bank formtocrdb;
        public String from;
        public EntryForm()
        {
            InitializeComponent();
        }

        public void setBelonging(String f){
            from = f;
        }
        private void EntryForm_Load(object sender, EventArgs e)
        {
            switch (from)
            {
                case "airtel":
                    label1.Text = "AIRTEL MONEY FORM";
                    this.BackColor = Color.DarkRed;
                    break;
                case "ezy":
                    label1.Text = "EZYPESA FORM";
                    this.BackColor = Color.DarkGreen;
                    break;
                case "tigo":
                    label1.Text = "TIGO PESA FORM";
                    this.BackColor = Color.SteelBlue;
                    break;
                case "voda":
                    label1.Text = "VODACOM M-PESA FORM";
                    this.BackColor = Color.DarkRed;
                    break;
                case "crdb":
                    label1.Text = "CRDB BANK FORM";
                    this.BackColor = Color.SeaGreen;
                    break;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            
            
            DialogResult dialogResult = MessageBox.Show("Reset your Form?", "Reset?", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes)
            {
                TransactionId_TextBox.Text = "";
                TransactionValue_TextBox.Text = "";
                CustomerCellPhone_TextBox.Text = "";
                CustomerIdNo_TextBox.Text = "";
                CustomerIdType_TextBox.Text = "";
                CustomerName_TextBox.Text = "";
                PokeaButton.Checked = false;
                ToaButton.Checked = false;
                resetlabels();
            }
            
            
            
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {//ErrorHandling
            resetlabels();
            error = false;
            
            ErrorHandling();
            if (error == true)
            {
                AlertMain.Visible = true;
                //AlertMain.ForeColor = System.Drawing.Color.White;
            }
            else if (error == false) 
            { //connect
                MessageBox.Show("Success");
            }


            /*  Connection to database
             
             * String tablename = "mpesa";
            Databasecon inserting = new Databasecon();
            
             */
            
            //kazi kwako kupitisha variable checki mfumo wa function yangu Insertdata
          //inserting.Insertdata(tablename,  990, "toa", 10000,"sele", 091475533, 4, "passport",2000);
          //inserting.selectdata();

        }

        private void resetlabels()
        {
            custnumerror.Visible = false;
            AlertMain.Visible = false;
            Alert1.Visible = false;
            Alert2.Visible = false;
            Alert3.Visible = false;
            Alert4.Visible = false;
            Alert5.Visible = false;
            Alert6.Visible = false;
            Alert7.Visible = false;
        }
        private void ErrorHandling()
        {
            bool mb = false;
            String messagenumber = "";
            if (TransactionId_TextBox.Text.Length < 7)
            {
                error = true;
                Alert1.Visible = true;
            }

            if (!PokeaButton.Checked && !ToaButton.Checked)
            {
                error = true;
                Alert2.Visible = true;
            }

            if (TransactionValue_TextBox.Text.Length < 1)
            {
                error = true;
                Alert3.Visible = true;
            }

            if (CustomerName_TextBox.Text.Length < 1)
            {
                error = true;
                Alert4.Visible = true;
            }
            
            int a;
            bool isNumeric = int.TryParse(CustomerCellPhone_TextBox.Text, out a);
                
                
                if (isNumeric == false)
                {
                    
                        mb = true;
                        custnumerror.Visible = true;
                   // messagenumber = "Customer Cell Phone is not a number Check Again";
                    error = true;
                    Alert5.Visible = true;
                    
                }
                
                else if (isNumeric == true)
                {
                    if (CustomerCellPhone_TextBox.Text.Length < 10)
                    {
                        mb = true;
                        custnumerror.Visible = true;
                        messagenumber = "Customer Cell Phone is not full (10digits)";
                    error = true;
                    Alert5.Visible = true;
                    }
                }
                   
                    int b;
                  bool  isNumericb = int.TryParse(CustomerIdNo_TextBox.Text, out b);
                    if (isNumericb == false)
                    {
                        
                            mb = true;
                            messagenumber = "Customer Id is not a number Check Again";
                        error = true;
                        Alert6.Visible = true;
                        
                    }
                    else
                    {
                        if (CustomerIdNo_TextBox.Text.Length < 1)
                        {
                        error = true;
                        Alert6.Visible = true;
                        }
                    }
            if (CustomerIdType_TextBox.Text.Length < 1)
            {
                error = true;
                Alert7.Visible = true;
            }

            if (mb == true)
            {
                //MessageBox.Show(messagenumber);
                mb = false;
            }

            

        }
    }
}
