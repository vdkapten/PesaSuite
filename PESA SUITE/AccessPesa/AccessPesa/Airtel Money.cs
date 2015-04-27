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
    public partial class Airtel_Money : Form
    {
        public HomeMenu airteltohome;
        public Ezy_Pesa ezy;
        public Vodacom_Mpesa voda;
        public CRDB_Bank crdb;
        public EntryForm airtelform;
        public Airtel_Money()
        {
            InitializeComponent();
        }
        private void Airtel_Money_Activated(object sender, EventArgs e)
        {
            airteltohome.setVisibility("off");
            
            //Connect to Database(Load from it)
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            airteltohome.setVisibility("on");
            this.Close();
       
        }

        private void CrdbBank_Click(object sender, EventArgs e)
        {
            crdb = new CRDB_Bank();
            crdb.airtel = this;
            crdb.Show();
            this.Close();
        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            airtelform = new EntryForm();
            airtelform.formtoairtel = this;
            airtelform.setBelonging("airtel");
            airtelform.ShowDialog();
        }

        private void EzyPesaButton_Click(object sender, EventArgs e)
        {

        }

        

       /* private void BackButton_Click(object sender, EventArgs e)
        {
            this.home.Show();
            this.Close();
        }*/
    }
}
