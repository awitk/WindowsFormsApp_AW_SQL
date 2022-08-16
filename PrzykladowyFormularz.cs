using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_AW_SQL.Models;

namespace WindowsFormsApp_AW_SQL
{
    public partial class PrzykladowyFormularz : Form
    {
        public PrzykladowyFormularz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oknoZWynikami = new ListaWynikowForm();
            oknoZWynikami.ShowDialog();

            ////1. Przygotowanie połączenia do bazy danych
            ////Tutaj jako parametr proszę podać connection string
            //var con = new SqlConnection("");

            ////2. Przygotowaniem zapytania
            //var com = new SqlCommand();
            //com.Connection = con;
            //com.CommandText = "select * from Osoba";

            ////3. Uruchomienie zapytania
            //var dr = com.ExecuteReader();

            //var osoby = new List<Osoba>();
            //while (dr.Read())
            //{
            //    var o = new Osoba();
            //    o.IdOsoba = (int)dr["IdOsoba"];
            //    o.Nazwisko = dr["Nazwisko"].ToString();
            //    osoby.Add(o);
            //}

            ////...
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_klub_Click(object sender, EventArgs e)
        {
            var okno = new Wyniki_Klubu();
            // stworzenie okno

            okno.ShowDialog();

            
            //// MIEJSCE KODU 
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PrzykladowyFormularz_Load(object sender, EventArgs e)
        {
            // kod z lista klubu
        }
    }
}
