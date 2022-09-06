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
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTB = new WindowsFormsApp_AW_SQL.MTB();
            this.kLUBKOLARSKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kLUB_KOLARSKITableAdapter = new WindowsFormsApp_AW_SQL.MTBTableAdapters.KLUB_KOLARSKITableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.mTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLUBKOLARSKIBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kLUBKOLARSKIBindingSource, "Klub_Nazwa", true));
            this.comboBox1.DataSource = this.kLUBKOLARSKIBindingSource;
            this.comboBox1.DisplayMember = "Klub_Nazwa";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.ValueMember = "Klub_Nazwa";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wybierz klub kolarski";
            this.label1.Click += new System.EventHandler(this.Label1_Click_1);
            // 
            // mTB
            // 
            this.mTB.DataSetName = "MTB";
            this.mTB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kLUBKOLARSKIBindingSource
            // 
            this.kLUBKOLARSKIBindingSource.DataMember = "KLUB_KOLARSKI";
            this.kLUBKOLARSKIBindingSource.DataSource = this.mTB;
            // 
            // kLUB_KOLARSKITableAdapter
            // 
            this.kLUB_KOLARSKITableAdapter.ClearBeforeFill = true;
            // 
            // Form_wyniki_klubu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 356);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form_wyniki_klubu";
            this.Text = "Form_wyniki_klubu";
            this.Load += new System.EventHandler(this.Form_wyniki_klubu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kLUBKOLARSKIBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form_wyniki_klubu_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private MTB mTB;
        private System.Windows.Forms.BindingSource kLUBKOLARSKIBindingSource;
        private MTBTableAdapters.KLUB_KOLARSKITableAdapter kLUB_KOLARSKITableAdapter;
    }
}