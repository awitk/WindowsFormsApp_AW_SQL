using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp_AW_SQL
{
    public partial class Form_dodaj_rekord_komentarz : Form
    {
        public Form_dodaj_rekord_komentarz()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button_OK_Click(object sender, EventArgs e)
        {

            string wstaw_komentarz_id = textBox1.Text;
            string wstaw_wynik_id = textBox2.Text;
            string wstaw_date = textBox3.Text;
            string wstaw_komentarz_tresc = textBox4.Text;
            string wstaw_komentarz_autor = textBox5.Text;


            // sql connection

            using (var con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = @"Data Source=DESKTOP-D50UGU8\SQL_AW;Initial Catalog=master;Integrated Security=True";
                    System.Console.WriteLine(0);
                    con.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = con; 
                    cmd.CommandText = $"INSERT INTO KOMENTARZ (KOMENTARZ_ID, WYNIK_ID, Data_Dodania, Komentarz_tresc, Komentarz_autor) VALUES('{wstaw_komentarz},{wstaw_wynik_id},{wstaw_date},{wstaw_komentarz_tresc},{wstaw_komentarz_autor}')";
                    cmd.ExecuteNonQuery();
                    Close();


                }
                catch (Exception ab) { }


            }
        }

        private void button_ANULUJ_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_id_komentarza_Click(object sender, EventArgs e)
        {

        }
    }
}

