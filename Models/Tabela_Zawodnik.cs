using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_AW_SQL.Models
{
    internal class Tabela_Zawodnik
    {

        public int zawodnik_id { get; set; }
        public int plec_id { get; set; }
        public int numer_startowy { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public string ImieINazwisko
        {
            get
            {
                return Imie + " " + Nazwisko;
            }

        }
    }
}

