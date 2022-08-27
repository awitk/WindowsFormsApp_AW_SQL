using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WindowsFormsApp_AW_SQL.Models2;

namespace WindowsFormsApp_AW_SQL
{
    public partial class Form2_dodanie_komentarza : Form
    {
        public Form2_dodanie_komentarza()
        {
            InitializeComponent();

            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-D50UGU8\SQL_AW;Initial Catalog=master;Integrated Security=True";
            System.Console.WriteLine(0);
            con.Open();
            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select Komentarz_Id, Wynik_Id, Data_dodania,Komentarz_tresc, Komentarz_autor FROM KOMENTARZ";
            System.Console.WriteLine(1);
            var reader = cmd.ExecuteReader();


            var list = new List<Wynik_F2>();
            while (reader.Read())
            {
                System.Console.WriteLine(reader.ToString());
                var w = new Wynik_F2

                {
                    KOMENTARZ_ID = (int)reader["Komentarz_Id"],
                    WYNIK_ID = (int)reader["Wynik_Id"],
                    Data_Dodania = reader["Data_dodania"].ToString(),
                    Komentarz_tresc = reader["Komentarz_tresc"].ToString(),
                    Komentarz_autor = reader["Komentarz_autor"].ToString()

                };
                list.Add(w);
            }
            dataGridView2.DataSource = list;
                    }


        private void button_form2_usun_rekord_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("button_form2_usun_rekord");
        }

        private void button_form2_dodaj_rekord_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("button_form2_dodaj_rekord");
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { System.Console.WriteLine("dataGridView2_CellContentClick"); }


        private void Form2_dodanie_komentarza_Load(object sender, EventArgs e)
        { System.Console.WriteLine("Form2_dodanie_komentarza_Load"); }
    }
}
