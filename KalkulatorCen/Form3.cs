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
    public partial class Form3 : Form
    {

        private Form1 parentForm;
        public Form3(Form1 form1)
        {
            InitializeComponent();
            this.parentForm = form1;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CenaMon_Click(object sender, EventArgs e)
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
