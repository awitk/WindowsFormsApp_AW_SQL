using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp_AW_SQL.Models2;

namespace WindowsFormsApp_AW_SQL
{
    public partial class ListaWynikowForm : Form
    {
        public ListaWynikowForm()
        {
            InitializeComponent();


            using (var con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=DESKTOP-D50UGU8;Initial Catalog=master;Integrated Security=True";

                con.Open();
                var cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandText = @"select z.Imie, z.Nazwisko, w.Punkty, w.Czy_Nagroda, k.Kategoria_Nazwa from [WYNIKI] w join [ZAWODNICY] z on w.ZAWODNIK_ID=z.ZAWODNIK_ID join KATEGORIA k on w.Kategoria_ID=k.Kategoria_ID";
                var reader = cmd.ExecuteReader();

                var list = new List<Wynik>();
                while (reader.Read())
                {
                    var w = new Wynik
                    {
                        Imie = reader["Imie"].ToString(),
                        Nazwisko = reader["Nazwisko"].ToString(),
                        Punkty = (int)reader["Punkty"],
                        CzyNagroda = (int)reader["Czy_Nagroda"],
                        Kategoria = reader["Kategoria_Nazwa"].ToString()
                    };
                    list.Add(w);
                }
                
                wynikiDataGridView.DataSource = list;
            }


            ////1. Przygotowanie połączenia do bazy danych
            ////Tutaj jako parametr proszę podać connection string
            //var con = new SqlConnection("");

            ////2. Przygotowaniem zapytania
            //var com = new SqlCommand();
            //com.Connection = con;
            //com.CommandText = "select * from Wyniki";

            ////3. Uruchomienie zapytania
            //var dr = com.ExecuteReader();

            //var osoby = new List<Wynik>();
            //while (dr.Read())
            //{
            //    var o = new Osoba();
            //    o.IdOsoba = (int)dr["IdOsoba"];
            //    o.Nazwisko = dr["Nazwisko"].ToString();
            //    osoby.Add(o);
            //}

            ////...połączyć liste z danymi z samą tabelką

        }
    }
}
