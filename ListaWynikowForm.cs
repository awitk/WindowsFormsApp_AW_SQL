using System;
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
                try
                {
                    con.ConnectionString = @"Data Source=DESKTOP-D50UGU8\SQL_AW;Initial Catalog=master;Integrated Security=True";
                    System.Console.WriteLine(0);
                    con.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select Wynik_id, Imie, Nazwisko, Plec_nazwa, Kategoria_Nazwa, Klub_Nazwa, Srednia_predkosc, Czas, Punkty, Miejscowosc, e.Data FROM WYNIKI as w JOIN ZAWODNICY as z on w.ZAWODNIK_ID = z.ZAWODNIK_ID JOIN KATEGORIA as kat on w.kategoria_id = kat.kategoria_id JOIN EDYCJA_ZAWODOW as e on e.edycja_id = w.edycja_zawodow_id JOIN KLUB_KOLARSKI as klub on klub.klub_ID = z.Klub_Kolarski_Klub_id JOIN PLEC as p on p.id = Z.Plec_id order by Punkty DESC";
                    System.Console.WriteLine(1);
                    var reader = cmd.ExecuteReader();

             
                    var list = new List<Wynik_F1>();
                    while (reader.Read())
                    {
                        System.Console.WriteLine(reader.ToString()); 
                        var w = new Wynik_F1
                        
                        {
                          Wynik_id = (int)reader["Wynik_id"],
                          Imie = reader["Imie"].ToString(),
                          Nazwisko = reader["Nazwisko"].ToString(),
                          Plec = reader["Plec_nazwa"].ToString(),
                          Kategoria = reader["Kategoria_Nazwa"].ToString(),
                          Klub_Kolarski = reader["Klub_Nazwa"].ToString(),
                          Srednia_Predkosc = (int)reader["Srednia_Predkosc"],
                          Czas = reader["Czas"].ToString(),
                          Punkty = (int)reader["Punkty"],
                          Miejscowosc = reader["Miejscowosc"].ToString(),
                          Data = reader["Data"].ToString()
                         };
                        list.Add(w);
                    }
                  

                 
                    wynikiDataGridView.DataSource = list;
                }
                catch (Exception e) { MessageBox.Show("blad" + e.StackTrace); }} }

        private void wynikiDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

/// O CO CHODZI Z TYM ŻE NIE WYŚWIETLA SIĘ WYNIK ID???
