using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P01KomunikacjaMiedzyFormularzami
{
    public partial class FrmStartowy : Form
    {
        FrmSzczegoly frmSzczegoly;

        public TextBox TxtDane { get { return txtDane; } }
        public FrmStartowy()
        {
            InitializeComponent();
        }

        private void btnSzczegoly_Click(object sender, EventArgs e)
        {
            frmSzczegoly = new FrmSzczegoly(this);
            frmSzczegoly.Show();

        }

        private void btnWyslij_Click(object sender, EventArgs e)
        {
            // formularz szczegoly <--> formularz startowy 
            frmSzczegoly.TxtDane.Text = txtDane.Text;
        }
    }
}
