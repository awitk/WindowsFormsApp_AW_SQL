
using System;

namespace WindowsFormsApp_AW_SQL
{
    partial class PrzykladowyFormularz
    {
        
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.button1_wszystkie_wyniki = new System.Windows.Forms.Button();
            this.button2_przegladaj_komentarze = new System.Windows.Forms.Button();
            this.button3_zawodnik = new System.Windows.Forms.Button();
            this.button4_klub = new System.Windows.Forms.Button();
            this.Button5_wyniki_1edycja = new System.Windows.Forms.Button();
            this.button6_kategoria_edycja = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2_dodaj_komentarz_do_wyniku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_wszystkie_wyniki
            // 
            this.button1_wszystkie_wyniki.Location = new System.Drawing.Point(26, 251);
            this.button1_wszystkie_wyniki.Margin = new System.Windows.Forms.Padding(2);
            this.button1_wszystkie_wyniki.Name = "button1_wszystkie_wyniki";
            this.button1_wszystkie_wyniki.Size = new System.Drawing.Size(161, 37);
            this.button1_wszystkie_wyniki.TabIndex = 0;
            this.button1_wszystkie_wyniki.Text = "Przeglądaj wszystkie wyniki";
            this.button1_wszystkie_wyniki.UseVisualStyleBackColor = true;
            this.button1_wszystkie_wyniki.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2_przegladaj_komentarze
            // 
            this.button2_przegladaj_komentarze.Location = new System.Drawing.Point(211, 251);
            this.button2_przegladaj_komentarze.Margin = new System.Windows.Forms.Padding(2);
            this.button2_przegladaj_komentarze.Name = "button2_przegladaj_komentarze";
            this.button2_przegladaj_komentarze.Size = new System.Drawing.Size(161, 37);
            this.button2_przegladaj_komentarze.TabIndex = 2;
            this.button2_przegladaj_komentarze.Text = "Przeglądaj wszystkie komentarze";
            this.button2_przegladaj_komentarze.UseVisualStyleBackColor = true;

            // button2_dodaj_komentarz_do_wyniku
            // 
            this.button2_dodaj_komentarz_do_wyniku.Location = new System.Drawing.Point(397, 251);
            this.button2_dodaj_komentarz_do_wyniku.Margin = new System.Windows.Forms.Padding(2);
            this.button2_dodaj_komentarz_do_wyniku.Name = "button2_dodaj_komentarz_do_wyniku";
            this.button2_dodaj_komentarz_do_wyniku.Size = new System.Drawing.Size(161, 37);
            this.button2_dodaj_komentarz_do_wyniku.TabIndex = 7;
            this.button2_dodaj_komentarz_do_wyniku.Text = "Dodaj komentarz do wyniku";
            this.button2_dodaj_komentarz_do_wyniku.UseVisualStyleBackColor = true;
            this.button2_dodaj_komentarz_do_wyniku.Click += new System.EventHandler(this.Button2_dodaj_komentarz_do_wyniku_Click);
            // 
            // 
            // button3_zawodnik
            // 
            this.button3_zawodnik.Location = new System.Drawing.Point(26, 315);
            this.button3_zawodnik.Margin = new System.Windows.Forms.Padding(2);
            this.button3_zawodnik.Name = "button3_zawodnik";
            this.button3_zawodnik.Size = new System.Drawing.Size(161, 37);
            this.button3_zawodnik.TabIndex = 3;
            this.button3_zawodnik.Text = "Zobacz wyniki zawodnika";
            this.button3_zawodnik.UseVisualStyleBackColor = true;
            this.button3_zawodnik.Click += new System.EventHandler(this.Button3_zawodnik_Click);
            // 
            // button4_klub
            // 
            this.button4_klub.Location = new System.Drawing.Point(211, 315);
            this.button4_klub.Margin = new System.Windows.Forms.Padding(2);
            this.button4_klub.Name = "Button4_klub";
            this.button4_klub.Size = new System.Drawing.Size(161, 37);
            this.button4_klub.TabIndex = 4;
            this.button4_klub.Text = "Zobacz wyniki klubu";
            this.button4_klub.UseVisualStyleBackColor = true;
            this.button4_klub.Click += new System.EventHandler(this.Button4_klub_Click);
            // 
            // button5_wyniki_1edycja
            // 
            this.Button5_wyniki_1edycja.Location = new System.Drawing.Point(26, 370);
            this.Button5_wyniki_1edycja.Margin = new System.Windows.Forms.Padding(2);
            this.Button5_wyniki_1edycja.Name = "Button5_wyniki_1edycja";
            this.Button5_wyniki_1edycja.Size = new System.Drawing.Size(161, 45);
            this.Button5_wyniki_1edycja.TabIndex = 5;
            this.Button5_wyniki_1edycja.Text = "Zobacz wyniki z jednej edycji zawodów";
            this.Button5_wyniki_1edycja.UseVisualStyleBackColor = true;
            this.Button5_wyniki_1edycja.Click += new System.EventHandler(this.Button5_wyniki_1edycja_Click);
            // 
            // button6_kategoria_edycja
            // 
            this.button6_kategoria_edycja.Location = new System.Drawing.Point(211, 370);
            this.button6_kategoria_edycja.Margin = new System.Windows.Forms.Padding(2);
            this.button6_kategoria_edycja.Name = "button6_kategoria_edycja";
            this.button6_kategoria_edycja.Size = new System.Drawing.Size(177, 45);
            this.button6_kategoria_edycja.TabIndex = 6;
            this.button6_kategoria_edycja.Text = "Zobacz wyniki wybranej kategorii w ramach jednej edycji zawodów";
            this.button6_kategoria_edycja.UseVisualStyleBackColor = true;
            this.button6_kategoria_edycja.Click += new System.EventHandler(this.Button6_kategoria_edycja_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp_AW_SQL.Properties.Resources.mtb_photo2;
            this.pictureBox1.Location = new System.Drawing.Point(78, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(399, 225);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
 
            // PrzykladowyFormularz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 505);
            this.Controls.Add(this.button1_wszystkie_wyniki);
            this.Controls.Add(this.button2_przegladaj_komentarze); 
            this.Controls.Add(this.button2_dodaj_komentarz_do_wyniku);
            this.Controls.Add(this.button3_zawodnik); 
            this.Controls.Add(this.button4_klub);
            this.Controls.Add(this.Button5_wyniki_1edycja);
            this.Controls.Add(this.button6_kategoria_edycja);

            this.Controls.Add(this.pictureBox1);
            
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PrzykladowyFormularz";
            this.Text = "PrzykladowyFormularz";
            this.Load += new System.EventHandler(this.PrzykladowyFormularz_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;

        private System.Windows.Forms.Button button1_wszystkie_wyniki;
        private System.Windows.Forms.Button button2_przegladaj_komentarze;
        private System.Windows.Forms.Button button2_dodaj_komentarz_do_wyniku;
        private System.Windows.Forms.Button button3_zawodnik;
        private System.Windows.Forms.Button button4_klub;
        private System.Windows.Forms.Button Button5_wyniki_1edycja;
        private System.Windows.Forms.Button button6_kategoria_edycja;
        
    }
}