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
    public partial class Tigo_Pesa : Form
    {
        public HomeMenu tigotohome;
        public EntryForm tigoform;
        public Tigo_Pesa()
        {
            InitializeComponent();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            tigotohome.setVisibility("on");
            this.Close();
        }

        private void NewEntry_Click(object sender, EventArgs e)
        {
            tigoform = new EntryForm();
            tigoform.formtotigo = this;
            tigoform.setBelonging("tigo");
            tigoform.ShowDialog();
        }
    }
}
