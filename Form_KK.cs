using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Data.SqlClient;
using WindowsFormsApp_AW_SQL.Models2;


namespace WindowsFormsApp_AW_SQL
{
    public partial class Form_KK : Form

    { SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-D50UGU8\SQL_AW;Initial Catalog=master;Integrated Security=True");

        public Form_KK()
        {
            InitializeComponent();
        }
        private void add_string_Click(object sender, EventArgs e)
        {
            string namestr = Button_combo_click.Text;
            comboBox_kk.Items.Add(namestr);
        }


        private void Form_KK_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand sc = new SqlCommand("SELECT Klub_nazwa from KLUB_KOLARSKI", con);
                SqlDataReader reader = sc.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Columns.Add("Klub_nazwa", typeof(string));
                dt.Load(reader);
                comboBox_kk.ValueMember = "Klub_nazwa";
                comboBox_kk.DataSource = dt;
                con.Close();
            }
            catch (Exception ex) { }
            }
            private void comboBox_kk_SelectedIndexChanged(object sender, EventArgs e)
            {

            }
        } } 
        

  