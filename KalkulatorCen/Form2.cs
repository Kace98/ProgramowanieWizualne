using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorCen
{
    public partial class Form2 : Form
    {
        private Form1 parentForm;

        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.parentForm = form1;
        }

        private void ProcWyb_Click(object sender, EventArgs e)
        {

        }

        private void Procesory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DyskWyb_Click(object sender, EventArgs e)
        {

        }

        private void Dysk1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dysk2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Dysk3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CenaLaczna_Click(object sender, EventArgs e)
        {

        }

        private void OK_Click(object sender, EventArgs e)
        {

        }

        private void Anuluj_Click(object sender, EventArgs e)
        {
            this.Close();
            this.parentForm.Show();
        }
    }
}
