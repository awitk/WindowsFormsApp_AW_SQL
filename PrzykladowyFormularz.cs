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

        private void Button1_Click(object sender, EventArgs e)
        {
            var oknoZWynikami = new ListaWynikowForm();
            oknoZWynikami.ShowDialog();
        }

        private void Button2_dodaj_komentarz_do_wyniku_Click(object sender, EventArgs e)
        {
            var oknoZWynikami = new Form_dodaj_rekord_komentarz();
            oknoZWynikami.ShowDialog();
        }

        private void Button2_przegladaj_komentarze_Click(object sender, EventArgs e)
        {
            var oknoZWynikami = new Form2_dodanie_komentarza();
            oknoZWynikami.ShowDialog();
        }

        private void Button4_klub_Click(object sender, EventArgs e)
        {
            var oknoZWynikami = new Form_KK();
            oknoZWynikami.ShowDialog();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void PrzykladowyFormularz_Load(object sender, EventArgs e)
        {
           
        }
    }
}
