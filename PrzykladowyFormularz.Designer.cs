
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
            this.button4_klub = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2_dodaj_komentarz_do_wyniku = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1_wszystkie_wyniki
            // 
            this.button1_wszystkie_wyniki.Location = new System.Drawing.Point(78, 264);
            this.button1_wszystkie_wyniki.Margin = new System.Windows.Forms.Padding(2);
            this.button1_wszystkie_wyniki.Name = "button1_wszystkie_wyniki";
            this.button1_wszystkie_wyniki.Size = new System.Drawing.Size(399, 37);
            this.button1_wszystkie_wyniki.TabIndex = 0;
            this.button1_wszystkie_wyniki.Text = "Przeglądaj wszystkie wyniki";
            this.button1_wszystkie_wyniki.UseVisualStyleBackColor = true;
            this.button1_wszystkie_wyniki.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button4_klub
            // 
            this.button4_klub.Location = new System.Drawing.Point(78, 376);
            this.button4_klub.Margin = new System.Windows.Forms.Padding(2);
            this.button4_klub.Name = "button4_klub";
            this.button4_klub.Size = new System.Drawing.Size(399, 37);
            this.button4_klub.TabIndex = 4;
            this.button4_klub.Text = "Zobacz wyniki klubu";
            this.button4_klub.UseVisualStyleBackColor = true;
            this.button4_klub.Click += new System.EventHandler(this.Button4_klub_Click);
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
            // button2_dodaj_komentarz_do_wyniku
            // 
            this.button2_dodaj_komentarz_do_wyniku.Location = new System.Drawing.Point(78, 319);
            this.button2_dodaj_komentarz_do_wyniku.Margin = new System.Windows.Forms.Padding(2);
            this.button2_dodaj_komentarz_do_wyniku.Name = "button2_dodaj_komentarz_do_wyniku";
            this.button2_dodaj_komentarz_do_wyniku.Size = new System.Drawing.Size(399, 37);
            this.button2_dodaj_komentarz_do_wyniku.TabIndex = 7;
            this.button2_dodaj_komentarz_do_wyniku.Text = "Dodaj komentarz do wyniku";
            this.button2_dodaj_komentarz_do_wyniku.UseVisualStyleBackColor = true;
            this.button2_dodaj_komentarz_do_wyniku.Click += new System.EventHandler(this.Button2_dodaj_komentarz_do_wyniku_Click);
            // 
            // PrzykladowyFormularz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 505);
            this.Controls.Add(this.button1_wszystkie_wyniki);
            this.Controls.Add(this.button2_dodaj_komentarz_do_wyniku);
            this.Controls.Add(this.button4_klub);
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
        private System.Windows.Forms.Button button2_dodaj_komentarz_do_wyniku;
        private System.Windows.Forms.Button button4_klub;
        
    }
}