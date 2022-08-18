using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp_AW_SQL.Models2;

namespace WindowsFormsApp_AW_SQL
{
    public partial class Wyniki_Klubu : Form
    {
        public Wyniki_Klubu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Wyniki_Klubu_Load(object sender, EventArgs e)
        {
            // pobranie listy klubu i przypisanie do combobox

            using (var con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = @"Data Source=DESKTOP-D50UGU8\SQL_AW;Initial Catalog=master;Integrated Security=True";
                    System.Console.WriteLine(0);
                    con.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select w.wynik_id,z.Imie, z.Nazwisko, w.Punkty, w.Czy_Nagroda, k.Kategoria_Nazwa from WYNIKI w join ZAWODNICY z on w.ZAWODNIK_ID = z.ZAWODNIK_ID join KATEGORIA k on w.Kategoria_ID = k.Kategoria_ID";
                    System.Console.WriteLine(1);
                    //cmd.CommandText = "select * from WYNIKI";
                    var reader = cmd.ExecuteReader();

                    System.Console.WriteLine(2);
                    var list = new List<Wynik>();
                    while (reader.Read())
                    {
                        System.Console.WriteLine(reader.ToString());
                        System.Console.WriteLine(3);
                        var w = new Wynik

                        {

                            Imie = reader["Imie"].ToString(),
                            Nazwisko = reader["Nazwisko"].ToString(),
                            Punkty = (int)reader["Punkty"],
                            // CzyNagroda = (int)reader["Czy_Nagroda"], czas to null
                            Kategoria = reader["Kategoria_Nazwa"].ToString()
                        };
                        list.Add(w);
                    }

                    //wynikiDataGridView.DataSource = list;
                }
                catch (Exception f) { MessageBox.Show("blad" + f.StackTrace); }
            }
        }
    }
    }

