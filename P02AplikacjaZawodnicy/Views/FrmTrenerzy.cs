using P02AplikacjaZawodnicy.Domain;
using P02AplikacjaZawodnicy.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P02AplikacjaZawodnicy.Views
{
    public partial class FrmTrenerzy : Form
    {
        public FrmTrenerzy()
        {
            InitializeComponent();


            TrenerzyRepository zr = new TrenerzyRepository();
            Trener[] trenerzy = zr.WczytajTrenerow();
            dgvDane.DataSource = trenerzy;
        }

        private void dgvDane_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int edtytowanyWiersz = e.RowIndex;
            Trener t= (Trener)dgvDane.Rows[edtytowanyWiersz].DataBoundItem;
            TrenerzyRepository tr = new TrenerzyRepository();
            tr.Edytuj(t);
            
        }
    }
}
