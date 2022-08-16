using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_AW_SQL.Models
{
    internal class tabela_Wyniki

    {
        public int WYNIK_ID { get; set; }
        public int ZAWODNIK_ID { get; set; }
        public int EDYCJA_ZAWODOW_ID { get; set; }
        public int DYSTANS_Dystans_ID { get; set; }
        public int Kategoria_ID { get; set; }
        public int Srednia_Predkosc { get; set; }
        public string Czas { get; set; }
        public int Punkty { get; set; }
        public int Czy_Nagroda { get; set; }

    }
}
