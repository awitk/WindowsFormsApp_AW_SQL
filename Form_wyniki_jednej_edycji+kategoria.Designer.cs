
namespace WindowsFormsApp_AW_SQL
{
    partial class Form_wyniki_jednej_edycji_kategoria
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

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.listBox_edycja_zawodow = new System.Windows.Forms.ListBox();
            this.textBox_wybierz_edycje = new System.Windows.Forms.TextBox();
            this.dataGridView_wyniki_edycja_kategoria = new System.Windows.Forms.DataGridView();
            this.mTB = new WindowsFormsApp_AW_SQL.MTB();
            this.mTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBox_kategoria = new System.Windows.Forms.ListBox();
            this.textBox_wybierz_kategorie = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wyniki_edycja_kategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_edycja_zawodow
            // 
            this.listBox_edycja_zawodow.FormattingEnabled = true;
            this.listBox_edycja_zawodow.Location = new System.Drawing.Point(46, 65);
            this.listBox_edycja_zawodow.Name = "listBox_edycja_zawodow";
            this.listBox_edycja_zawodow.Size = new System.Drawing.Size(135, 56);
            this.listBox_edycja_zawodow.TabIndex = 0;
            // 
            // textBox_wybierz_edycje
            // 
            this.textBox_wybierz_edycje.Location = new System.Drawing.Point(46, 23);
            this.textBox_wybierz_edycje.Name = "textBox_wybierz_edycje";
            this.textBox_wybierz_edycje.Size = new System.Drawing.Size(135, 20);
            this.textBox_wybierz_edycje.TabIndex = 1;
            this.textBox_wybierz_edycje.Text = "Wybierz edycję zawodów";
            this.textBox_wybierz_edycje.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView_wyniki_edycja_kategoria
            // 
            this.dataGridView_wyniki_edycja_kategoria.AutoGenerateColumns = false;
            this.dataGridView_wyniki_edycja_kategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_wyniki_edycja_kategoria.DataSource = this.mTBBindingSource;
            this.dataGridView_wyniki_edycja_kategoria.Location = new System.Drawing.Point(46, 172);
            this.dataGridView_wyniki_edycja_kategoria.Name = "dataGridView_wyniki_edycja_kategoria";
            this.dataGridView_wyniki_edycja_kategoria.Size = new System.Drawing.Size(328, 149);
            this.dataGridView_wyniki_edycja_kategoria.TabIndex = 4;
            // 
            // mTB
            // 
            this.mTB.DataSetName = "MTB";
            this.mTB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mTBBindingSource
            // 
            this.mTBBindingSource.DataSource = this.mTB;
            this.mTBBindingSource.Position = 0;
            // 
            // listBox_kategoria
            // 
            this.listBox_kategoria.FormattingEnabled = true;
            this.listBox_kategoria.Location = new System.Drawing.Point(239, 65);
            this.listBox_kategoria.Name = "listBox_kategoria";
            this.listBox_kategoria.Size = new System.Drawing.Size(135, 56);
            this.listBox_kategoria.TabIndex = 3;
            // 
            // textBox_wybierz_kategorie
            // 
            this.textBox_wybierz_kategorie.Location = new System.Drawing.Point(239, 23);
            this.textBox_wybierz_kategorie.Name = "textBox_wybierz_kategorie";
            this.textBox_wybierz_kategorie.Size = new System.Drawing.Size(135, 20);
            this.textBox_wybierz_kategorie.TabIndex = 2;
            this.textBox_wybierz_kategorie.Text = "Wybierz kategorię zawodników";
            this.textBox_wybierz_kategorie.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form_wyniki_jednej_edycji_kategoria
            // 
            this.ClientSize = new System.Drawing.Size(557, 356);
            this.Controls.Add(this.dataGridView_wyniki_edycja_kategoria);
            this.Controls.Add(this.listBox_kategoria);
            this.Controls.Add(this.textBox_wybierz_kategorie);
            this.Controls.Add(this.textBox_wybierz_edycje);
            this.Controls.Add(this.listBox_edycja_zawodow);
            this.Name = "Form_wyniki_jednej_edycji_kategoria";
            this.Load += new System.EventHandler(this.Form_wyniki_jednej_edycji_kategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_wyniki_edycja_kategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_edycja_zawodow;
        private System.Windows.Forms.TextBox textBox_wybierz_edycje;
        private System.Windows.Forms.DataGridView dataGridView_wyniki_edycja_kategoria;
        private System.Windows.Forms.BindingSource mTBBindingSource;
        private MTB mTB;
        private System.Windows.Forms.ListBox listBox_kategoria;
        private System.Windows.Forms.TextBox textBox_wybierz_kategorie;
    }
}
