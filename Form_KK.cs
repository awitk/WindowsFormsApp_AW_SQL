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

    {
        private static object con;

        public Form_KK()
        {
            InitializeComponent();
            FillCombo();
        }

        private void add_string_Click(object sender, EventArgs e)
        {
            string namestr = Button_combo_click.Text;
            comboBox_kk.Items.Add(namestr);
        }

        private static void FillCombo()
        {
            con.ConnectionString = @"Data Source=DESKTOP-D50UGU8\SQL_AW;Initial Catalog=master;Integrated Security=True";
            System.Console.WriteLine(0);
            con.Open();
            var cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "SELECT Klub_nazwa from KLUB_KOLARSKI";
            System.Console.WriteLine(1);
            var reader = cmd.ExecuteReader();
            try
            {
                con.Open();

                //2. Wysyłamy komende SQL
                //forward only cursor

                SqlDataReader dr = com.ExecuteReader();

                while (dr.Read())
                {
                    string sName = myReader.GetString("name");
                     comboBox_kk.Items.Add(sName);
                }

                //3. Zamykamy połączenie
                con.Dispose();

            }
            catch (Exeption ex)
            }


                private void Form_KK_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'mTB.KLUB_KOLARSKI' table. You can move, or remove it, as needed.
            this.kLUB_KOLARSKITableAdapter.Fill(this.mTB.KLUB_KOLARSKI);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.kLUB_KOLARSKITableAdapter.FillBy(this.mTB.KLUB_KOLARSKI);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        }

        private void comboBox_kk_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
