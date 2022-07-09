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

namespace WindowsFormsApp_AW_SQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mTB.KOMENTARZ' table. You can move, or remove it, as needed.
            this.kOMENTARZTableAdapter.Fill(this.mTB.KOMENTARZ);

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRowView wybranyKomentarz = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
            int idKomentarz = (int)wybranyKomentarz.Row["IdKomentarz"];
            MessageBox.Show("IdKomentarz: " + idKomentarz);


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-D50UGU8\SQL_AW;Initial Catalog=master;Integrated Security=True");
            SqlCommand com = new SqlCommand();
            com.Connection = con;
            com.CommandText = "select * from komentarz";
        }
    }
}
