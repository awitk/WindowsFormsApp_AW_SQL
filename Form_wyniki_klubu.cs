﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data.SqlClient;
using WindowsFormsApp_AW_SQL.Models2;

namespace WindowsFormsApp_AW_SQL
{
    public partial class Form_wyniki_klubu : Form
    {
        public Form_wyniki_klubu()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)

        //// LISTA WSZYSTKICH KLUBÓW
        {
            using (var con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = @"Data Source=DESKTOP-D50UGU8\SQL_AW;Initial Catalog=master;Integrated Security=True";
                    System.Console.WriteLine(0);
                    con.Open();
                    var cmd = new SqlCommand();
                    cmd.Connection = con;
                    cmd.CommandText = "select Klub_Nazwa from klub_kolarski;";
                    System.Console.WriteLine(1);

                    var reader = cmd.ExecuteReader();

                    System.Console.WriteLine(2);
                    var list = new List<Wynik_F4>();
                    while (reader.Read())
                    {
                        System.Console.WriteLine(reader.ToString());

                        var kl = new Wynik_F4

                        {
                            Klub_Nazwa = reader["Klub_Nazwa"].ToString()
                        };
                        list.Add(kl);
                    }
                    System.Console.WriteLine(list);
                    // wynikiDataGridView.DataSource = list;
                    //  this.comboBox1_SelectedIndexChanged.DataSource = list;
                }
                catch (Exception f) { MessageBox.Show("blad" + f.StackTrace); }
            }

            //private void Form_Wyniki_Klubu_Load(object sender, EventArgs e)

            //// PRZEKAZANIE WYBRANEGO KLUBU DO SELECTA ŻEBY WYŚWIETLIĆ WYNIKI TEGO KLUBU
            //{
            //    // pobranie listy klubu i przypisanie do combobox

            //    using (var con = new SqlConnection())
            //    {
            //        try
            //        {
            //            con.ConnectionString = @"Data Source=DESKTOP-D50UGU8\SQL_AW;Initial Catalog=master;Integrated Security=True";
            //            System.Console.WriteLine(0);
            //            con.Open();
            //            var cmd = new SqlCommand();
            //            cmd.Connection = con;
            //            cmd.CommandText = "select Klub_Nazwa from klub_kolarski;";
            //            System.Console.WriteLine(1);

            //            var reader = cmd.ExecuteReader();

            //            System.Console.WriteLine(2);
            //            var list = new List<Wynik_F4>();
            //            while (reader.Read())
            //            {
            //                System.Console.WriteLine(reader.ToString());

            //                var kl = new Wynik_F4

            //                { Klub_Nazwa = reader["Klub_Nazwa"].ToString()
            //                };
            //                list.Add(kl);
            //            }
            //            System.Console.WriteLine(list);
            //            // wynikiDataGridView.DataSource = list;
            //            //  this.comboBox1_SelectedIndexChanged.DataSource = list;
            //        }
            //        catch (Exception f) { MessageBox.Show("blad" + f.StackTrace); }
            //    }
            //}
        }
    }
}
