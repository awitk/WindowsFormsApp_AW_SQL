using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp_AW_SQL.Models2;

namespace WindowsFormsApp_AW_SQL
{
    public partial class Form_przegladaj_wszystkie_komentarze : Form
    {
        public Form_przegladaj_wszystkie_komentarze()
        {
            InitializeComponent();
        }

        private void Wszystkie_Komentarze_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form_przegladaj_wszystkie_komentarze_Load(object sender, EventArgs e)
        {

            Wszystkie_Komentarze_DataGridView.DataSource = Wszystkie_KomentarzeList();
        }

        public Wszystkie_KomentarzeList()
        {
            InitializeComponent();


            DataTable dtWszystkie_Komentarze = new DataTable();


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
                        cmd.CommandText = "Select Wynik_ID, Data_Dodania, Komentarz_tresc, Komentarz_autor from KOMENTARZ;";
                        System.Console.WriteLine(1);
                        var reader = cmd.ExecuteReader();


                        var list = new List<Wynik_F7>();
                        while (reader.Read())
                        {
                            System.Console.WriteLine(reader.ToString());
                            var wk = new Wynik_F7

                            {
                                Wynik_ID = (int)reader["Wynik_ID"],
                                Data_Dodania = reader["Data_dodania"].ToString(),
                                Komentarz_tresc = reader["Komentarz_tresc"].ToString(),
                                Komentarz_autor = reader["Komentarz_autor"].ToString()
                            };
                            list.Add(wk);
                        }



                        Wszystkie_Komentarze_DataGridView.DataSource = list;
                    }
                    catch (Exception e) { MessageBox.Show("blad" + e.StackTrace); }



                }
            }
        }
    }
}
