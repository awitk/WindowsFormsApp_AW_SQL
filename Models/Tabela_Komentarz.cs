using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp_AW_SQL.Models
    {
    public class Tabela_Komentarz
    {
        public int komentarz_id { get; set; }
        public int wynik_id { get; set; }
        public string Data_dodania { get; set; }
        public string Komentarz_tresc { get; set; }
        public string Komentarz_autor { get; set; }
        
    }
    }

