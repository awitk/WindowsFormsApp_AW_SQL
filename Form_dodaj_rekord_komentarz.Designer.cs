
namespace WindowsFormsApp_AW_SQL
{
    partial class Form_dodaj_rekord_komentarz
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label_data = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_zatwierdz = new System.Windows.Forms.Button();
            this.label_id_komentarza = new System.Windows.Forms.Label();
            this.label_id_wyniku = new System.Windows.Forms.Label();
            this.button_anuluj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(107, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(107, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(30, 114);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(107, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(30, 153);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(215, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(30, 195);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(213, 20);
            this.textBox5.TabIndex = 4;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(28, 98);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(215, 13);
            this.label_data.TabIndex = 5;
            this.label_data.Text = "wpisz datę dodania (w formacie 2022.08.01)";
            this.label_data.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "wpisz treść komentarza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "wpisz  autora (pole nieobowiązkowe)";
            // 
            // button_zatwierdz
            // 
            this.button_zatwierdz.Location = new System.Drawing.Point(298, 66);
            this.button_zatwierdz.Name = "button_zatwierdz";
            this.button_zatwierdz.Size = new System.Drawing.Size(140, 50);
            this.button_zatwierdz.TabIndex = 8;
            this.button_zatwierdz.Text = "ZATWERDŹ dodanie komentarza";
            this.button_zatwierdz.UseVisualStyleBackColor = true;
            this.button_zatwierdz.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // label_id_komentarza
            // 
            this.label_id_komentarza.AutoSize = true;
            this.label_id_komentarza.Location = new System.Drawing.Point(28, 9);
            this.label_id_komentarza.Name = "label_id_komentarza";
            this.label_id_komentarza.Size = new System.Drawing.Size(102, 13);
            this.label_id_komentarza.TabIndex = 10;
            this.label_id_komentarza.Text = "wpisz id komentarza";
            this.label_id_komentarza.Click += new System.EventHandler(this.label_id_komentarza_Click);
            // 
            // label_id_wyniku
            // 
            this.label_id_wyniku.AutoSize = true;
            this.label_id_wyniku.Location = new System.Drawing.Point(28, 50);
            this.label_id_wyniku.Name = "label_id_wyniku";
            this.label_id_wyniku.Size = new System.Drawing.Size(80, 13);
            this.label_id_wyniku.TabIndex = 11;
            this.label_id_wyniku.Text = "wpisz id wyniku";
            // 
            // button_anuluj
            // 
            this.button_anuluj.Location = new System.Drawing.Point(298, 137);
            this.button_anuluj.Name = "button_anuluj";
            this.button_anuluj.Size = new System.Drawing.Size(140, 50);
            this.button_anuluj.TabIndex = 12;
            this.button_anuluj.Text = "ANULUJ dodanie komentarza";
            this.button_anuluj.UseVisualStyleBackColor = true;
            // 
            // Form_dodaj_rekord_komentarz
            // 
            this.ClientSize = new System.Drawing.Size(464, 249);
            this.Controls.Add(this.button_anuluj);
            this.Controls.Add(this.label_id_wyniku);
            this.Controls.Add(this.label_id_komentarza);
            this.Controls.Add(this.button_zatwierdz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_data);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form_dodaj_rekord_komentarz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;

        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Button button_zatwierdz;
        private System.Windows.Forms.Label label_id_komentarza;
        private System.Windows.Forms.Label label_id_wyniku;
        private System.Windows.Forms.Button button_anuluj;
    }
}
