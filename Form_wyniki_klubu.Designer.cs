using System;

namespace WindowsFormsApp_AW_SQL
{
    partial class Form_wyniki_klubu
    {

        /// </summary>
        private System.ComponentModel.IContainer components = null;
       
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        private void InitializeComponent()
        {
            Form_wyniki_klubu form_wyniki_klubu = this;
            form_wyniki_klubu.comboBox1 = new System.Windows.Forms.ComboBox();
            form_wyniki_klubu.label1 = new System.Windows.Forms.Label();
            form_wyniki_klubu.SuspendLayout();
            // 
            // comboBox1
            // 
            form_wyniki_klubu.comboBox1.FormattingEnabled = true;
            form_wyniki_klubu.comboBox1.Location = new System.Drawing.Point(54, 46);
            form_wyniki_klubu.comboBox1.Name = "comboBox1";
            form_wyniki_klubu.comboBox1.Size = new System.Drawing.Size(121, 21);
            form_wyniki_klubu.comboBox1.TabIndex = 0;
            form_wyniki_klubu.comboBox1.SelectedIndexChanged += new System.EventHandler(form_wyniki_klubu.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            form_wyniki_klubu.label1.AutoSize = true;
            form_wyniki_klubu.label1.Location = new System.Drawing.Point(54, 13);
            form_wyniki_klubu.label1.Name = "label1";
            form_wyniki_klubu.label1.Size = new System.Drawing.Size(107, 13);
            form_wyniki_klubu.label1.TabIndex = 1;
            form_wyniki_klubu.label1.Text = "Wybierz klub kolarski";
            form_wyniki_klubu.label1.Click += new System.EventHandler(form_wyniki_klubu.Label1_Click_1);
            // 
            // Wyniki_Klubu
            // 
            form_wyniki_klubu.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            form_wyniki_klubu.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            form_wyniki_klubu.ClientSize = new System.Drawing.Size(557, 356);
            form_wyniki_klubu.Controls.Add(form_wyniki_klubu.label1);
            form_wyniki_klubu.Controls.Add(form_wyniki_klubu.comboBox1);
            form_wyniki_klubu.Name = "Form_wyniki_klubu";
            form_wyniki_klubu.Text = "Form_wyniki_klubu";
            form_wyniki_klubu.Load += new System.EventHandler(form_wyniki_klubu.Form_wyniki_klubu_Load);
            form_wyniki_klubu.ResumeLayout(false);
            form_wyniki_klubu.PerformLayout();

        }

        private void Form_wyniki_klubu_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}