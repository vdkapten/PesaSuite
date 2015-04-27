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
    public partial class Ezy_Pesa : Form
    {
        public HomeMenu ezytohome;
        public EntryForm ezyform;
        public Ezy_Pesa()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            ezytohome.setVisibility("on");
            this.Close();
        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            ezyform = new EntryForm();
            ezyform.formtoezy = this;
            ezyform.setBelonging("ezy");
            ezyform.ShowDialog();
        }
    }
}
