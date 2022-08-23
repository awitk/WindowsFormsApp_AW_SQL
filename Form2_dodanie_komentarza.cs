using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp_AW_SQL
{
    public partial class Form2_dodanie_komentarza : Form
    {
        public Form2_dodanie_komentarza()
        {
            InitializeComponent();
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
