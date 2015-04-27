using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace AccessPesa
{
    public partial class HomeMenu : Form
    {
        public Airtel_Money airtel;
        public String onoff="";
        public HomeMenu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            setVisibility("on");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            CRDB_Bank crdbform = new CRDB_Bank();
            crdbform.home = this;
            this.Visible = false;
            crdbform.Show();
            //this.Close();
        }

        private void AirtelMoneyButton_Click(object sender, EventArgs e)
        {
             airtel = new Airtel_Money();
            airtel.airteltohome = this;
            this.Visible = false;
            airtel.Show();
            //this.Close();
        }
        

        private void EzyPesaButton_Click(object sender, EventArgs e)
        {
            Ezy_Pesa ezypesa = new Ezy_Pesa();
            ezypesa.ezytohome = this;
            this.Visible=false;
            ezypesa.Show();
            
        }

        private void tigobutton_Click(object sender, EventArgs e)
        {
            Tigo_Pesa tigo = new Tigo_Pesa();
            tigo.tigotohome = this;
            this.Visible=false;
            tigo.Show();
        }

        private void vodacombutton_Click(object sender, EventArgs e)
        {
            Vodacom_Mpesa voda = new Vodacom_Mpesa();
            voda.vodatohome = this;
            this.Visible=true;
            voda.Show();
        }
        
        public void setVisibility(String onoff)
        {
            
            
           if(onoff == "on")
           {
               this.Visible=true;
           }

            else if(onoff == "off")
           {
                this.Visible=false;
           }
        }

}
}
