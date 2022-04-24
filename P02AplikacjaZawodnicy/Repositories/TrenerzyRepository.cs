using P02AplikacjaZawodnicy.Domain;
using P02AplikacjaZawodnicy.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02AplikacjaZawodnicy.Repositories
{
    class TrenerzyRepository
    {

        public Trener[] WczytajTrenerow()
        {

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            object[][] wynik= pzb.WyslijPolecenieSQL("select id_trenera, imie_t, nazwisko_t, data_ur_t from trenerzy");

            Trener[] trenerzy = new Trener[wynik.Length];

            for (int i = 0; i < wynik.Length; i++)
            {
                Trener ityTrener = new Trener();
                ityTrener.Id = (int)wynik[i][0];
                  
                ityTrener.Imie = (string)wynik[i][1];
                ityTrener.Nazwisko = (string)wynik[i][2];
                ityTrener.DataUr = (DateTime)wynik[i][3];
                trenerzy[i] = ityTrener;
            }

            return trenerzy;
        }


        public void DodajTrenera(Trener z)
        {
            string szablon = @"insert into trenerzy 
                         (imie_t, nazwisko_t, data_ur_t)
                         values
                         ({0}, '{1}', '{2}')";

            string sql = string.Format(szablon, z.Imie, z.Nazwisko,z.DataUr.ToString("yyyyMMdd"));

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WyslijPolecenieSQL(sql);
        }

        public void Edytuj(Trener z)
        {
            string szablon = @"update trenerzy set imie_t='{0}',nazwisko_t='{1}',data_ur_t='{2}'
                                where id_trenera = {3}";

            string sql = string.Format(szablon,z.Imie,z.Nazwisko,z.DataUr.ToString("yyyyMMdd"),z.Id);

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WyslijPolecenieSQL(sql);
        }

        //params - mogę podać jednego lub wielu po przecinku, lub po prostu całą kolekcję 
        public void Usun(params Trener[] trenerzy)
        {
            string sql = string.Format("delete trenerzy where id_trenera in ({0})",
                string.Join(" ,", trenerzy.Select(x => x.Id)));

            PolaczenieZBaza pzb = new PolaczenieZBaza();
            pzb.WyslijPolecenieSQL(sql);
        }
    }
}
