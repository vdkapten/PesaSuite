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
    public partial class CRDB_Bank : Form
    {
        public HomeMenu home;
        public Airtel_Money airtel;
        public EntryForm crdbform;
        public CRDB_Bank()
        {
            InitializeComponent();
        }

        private void CRDB_Bank_Load(object sender, EventArgs e)
        {
            //connect to database

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //home = new HomeMenu();
           // home.Visible = true;
            
            home.setVisibility("on");
            this.Close();
        }

        private void AirtelMoney_Click(object sender, EventArgs e)
        {
            home.airtel = new Airtel_Money();
            //home.airtel.home.Visible = false;
            //airtel = new Airtel_Money();
            //home.airtel.crdb = this;
            home.airtel.Show();
            
            this.Close();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void EzyPesa_Click(object sender, EventArgs e)
        {

        }

        private void TigoPesa_Click(object sender, EventArgs e)
        {

        }

        private void VodacomMpesa_Click(object sender, EventArgs e)
        {

        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            crdbform = new EntryForm();
            crdbform.formtocrdb = this;
            crdbform.setBelonging("crdb");
            crdbform.ShowDialog();
        
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/

     
    }
}
