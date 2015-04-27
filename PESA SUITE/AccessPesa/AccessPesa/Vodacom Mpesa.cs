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
    public partial class Vodacom_Mpesa : Form
    {
        public HomeMenu vodatohome;
        public EntryForm vodaform;
        public Vodacom_Mpesa()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            vodatohome.setVisibility("on");
            this.Close();

        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            vodaform = new EntryForm();
            vodaform.formtovoda = this;
            vodaform.setBelonging("voda");
            vodaform.ShowDialog();
        }
    }
}
