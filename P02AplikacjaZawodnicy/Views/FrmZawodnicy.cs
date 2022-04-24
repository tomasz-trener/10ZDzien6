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
    public partial class FrmZawodnicy : Form
    {
        public FrmZawodnicy()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, EventArgs e)
        {
            Odswiez();
        }

        private void Odswiez()
        {
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik[] zawodnicy = zr.WczytajZawodnikow();
            lbDane.DataSource = zawodnicy;
            lbDane.DisplayMember = "Wiersz"; // to musi być właściwość (a nie pole)
        }
    }
}
