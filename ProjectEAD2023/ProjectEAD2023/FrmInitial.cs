using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectEAD2023
{
    public partial class FrmInitial : Form
    {
        public FrmInitial()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRegistreProduct frmRegistreProduct = new FrmRegistreProduct();
            this.Hide();
            frmRegistreProduct.ShowDialog();
        }
    }
}
