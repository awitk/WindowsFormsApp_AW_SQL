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

       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var oknoZWynikami = new Form2_dodanie_komentarza();
            oknoZWynikami.ShowDialog();
        }

        private void button4_klub_Click(object sender, EventArgs e)
        {
            var oknoZWynikami = new Wyniki_Klubu();
            oknoZWynikami.ShowDialog();


       
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
