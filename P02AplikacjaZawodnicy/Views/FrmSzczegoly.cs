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
    enum TrybOkienka
    {
        Dodawanie,
        Edycja,
        Inny
    }
    public partial class FrmSzczegoly : Form
    {
        FrmZawodnicy frmZawodnicy;
        Zawodnik edytowany;

        private TrybOkienka trybOkienka
        {
            get
            {
               return edytowany == null ? TrybOkienka.Dodawanie : TrybOkienka.Edycja;
            }
        }

        public FrmSzczegoly(FrmZawodnicy frmZawodnicy)
        {
            this.frmZawodnicy = frmZawodnicy;
            InitializeComponent();
        }

        public FrmSzczegoly(FrmZawodnicy frmZawodnicy, Zawodnik z) : this(frmZawodnicy)
        {
            edytowany = z;

            txtImie.Text = z.Imie;
            txtNazwisko.Text = z.Nazwisko;
            txtKraj.Text = z.Kraj;
            dtpDataUrodzenia.Value = z.DataUr;
            numWaga.Value = z.Waga;
            if(z.Wzrost != null)
                numWzrost.Value = (int)z.Wzrost;
            btnUsun.Visible = true;
        }

        private void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik z;
            if (trybOkienka == TrybOkienka.Dodawanie) // to jest sytuacja gdy jestesmy w trybie dodwania 
                z = new Zawodnik();
            else if (trybOkienka == TrybOkienka.Edycja)
                z = edytowany;
            else
                throw new NotImplementedException("Nieznany tyb");

            z.Imie = txtImie.Text;
            z.Nazwisko = txtNazwisko.Text;
            z.Kraj = txtKraj.Text;
            z.DataUr = dtpDataUrodzenia.Value;
            z.Waga = Convert.ToInt32(numWaga.Value);
            z.Wzrost = Convert.ToInt32(numWzrost.Value);

            ZawodnicyRepository zr = new ZawodnicyRepository();

            if (trybOkienka == TrybOkienka.Dodawanie)
                zr.DodajZawodnika(z);
            else if (trybOkienka == TrybOkienka.Edycja)
                zr.Edytuj(z);
            else
                throw new NotImplementedException("Nieznany tryb");
            
            frmZawodnicy.Odswiez();
            this.Close();

        }

        private void btnUsun_Click(object sender, EventArgs e)
        {
            DialogResult dr=
                MessageBox.Show($"Czy napewno chcesz usunać zawodnika {edytowany.ImieNazwisko} ? ",
                    "Pytanie", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                ZawodnicyRepository zr = new ZawodnicyRepository();
                zr.Usun(edytowany);
                frmZawodnicy.Odswiez();
                this.Close();
            }

            
        }
    }
}
