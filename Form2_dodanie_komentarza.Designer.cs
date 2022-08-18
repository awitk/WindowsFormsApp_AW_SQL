using System;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp_AW_SQL
{
    partial class Form2_dodanie_komentarza
    {
    
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private void button2_Click(object sender, Event Args e)
        {
            Close();
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
     
    /// XXXXXXXXX AW

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.dataGridView1 = new System.Windows.Forms.DataGridView();
        this.plecTableAdapter1 = new WindowsFormsApp_AW_SQL.MTBTableAdapters.PLECTableAdapter();
        this.dataGridView2 = new System.Windows.Forms.DataGridView();
        this.kOMENTARZIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.wYNIKIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.dataDodaniaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.komentarztrescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.komentarzautorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
        this.kOMENTARZBindingSource = new System.Windows.Forms.BindingSource(this.components);
        this.mTB = new WindowsFormsApp_AW_SQL.MTB();
        this.kOMENTARZTableAdapter = new WindowsFormsApp_AW_SQL.MTBTableAdapters.KOMENTARZTableAdapter();
        this.button1 = new System.Windows.Forms.Button();
        this.button2 = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.kOMENTARZBindingSource)).BeginInit();
        ((System.ComponentModel.ISupportInitialize)(this.mTB)).BeginInit();
        this.SuspendLayout();
        // 
        // dataGridView1
        // 
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new System.Drawing.Point(0, 0);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.Size = new System.Drawing.Size(240, 150);
        this.dataGridView1.TabIndex = 0;
        // 
        // plecTableAdapter1
        // 
        this.plecTableAdapter1.ClearBeforeFill = true;
        // 
        // dataGridView2
        // 
        this.dataGridView2.AutoGenerateColumns = false;
        this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.kOMENTARZIDDataGridViewTextBoxColumn,
            this.wYNIKIDDataGridViewTextBoxColumn,
            this.dataDodaniaDataGridViewTextBoxColumn,
            this.komentarztrescDataGridViewTextBoxColumn,
            this.komentarzautorDataGridViewTextBoxColumn});
        this.dataGridView2.DataSource = this.kOMENTARZBindingSource;
        this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dataGridView2.Location = new System.Drawing.Point(0, 0);
        this.dataGridView2.Name = "dataGridView2";
        this.dataGridView2.Size = new System.Drawing.Size(800, 450);
        this.dataGridView2.TabIndex = 1;
        this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
        // 
        // kOMENTARZIDDataGridViewTextBoxColumn
        // 
        this.kOMENTARZIDDataGridViewTextBoxColumn.DataPropertyName = "KOMENTARZ_ID";
        this.kOMENTARZIDDataGridViewTextBoxColumn.HeaderText = "KOMENTARZ_ID";
        this.kOMENTARZIDDataGridViewTextBoxColumn.Name = "kOMENTARZIDDataGridViewTextBoxColumn";
        // 
        // wYNIKIDDataGridViewTextBoxColumn
        // 
        this.wYNIKIDDataGridViewTextBoxColumn.DataPropertyName = "WYNIK_ID";
        this.wYNIKIDDataGridViewTextBoxColumn.HeaderText = "WYNIK_ID";
        this.wYNIKIDDataGridViewTextBoxColumn.Name = "wYNIKIDDataGridViewTextBoxColumn";
        // 
        // dataDodaniaDataGridViewTextBoxColumn
        // 
        this.dataDodaniaDataGridViewTextBoxColumn.DataPropertyName = "Data_Dodania";
        this.dataDodaniaDataGridViewTextBoxColumn.HeaderText = "Data_Dodania";
        this.dataDodaniaDataGridViewTextBoxColumn.Name = "dataDodaniaDataGridViewTextBoxColumn";
        // 
        // komentarztrescDataGridViewTextBoxColumn
        // 
        this.komentarztrescDataGridViewTextBoxColumn.DataPropertyName = "Komentarz_tresc";
        this.komentarztrescDataGridViewTextBoxColumn.HeaderText = "Komentarz_tresc";
        this.komentarztrescDataGridViewTextBoxColumn.Name = "komentarztrescDataGridViewTextBoxColumn";
        // 
        // komentarzautorDataGridViewTextBoxColumn
        // 
        this.komentarzautorDataGridViewTextBoxColumn.DataPropertyName = "Komentarz_autor";
        this.komentarzautorDataGridViewTextBoxColumn.HeaderText = "Komentarz_autor";
        this.komentarzautorDataGridViewTextBoxColumn.Name = "komentarzautorDataGridViewTextBoxColumn";
        // 
        // kOMENTARZBindingSource
        // 
        this.kOMENTARZBindingSource.DataMember = "KOMENTARZ";
        this.kOMENTARZBindingSource.DataSource = this.mTB;
        // 
        // mTB
        // 
        this.mTB.DataSetName = "MTB";
        this.mTB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
        // 
        // kOMENTARZTableAdapter
        // 
        this.kOMENTARZTableAdapter.ClearBeforeFill = true;
        // 
        // button1
        // 
        this.button1.Location = new System.Drawing.Point(79, 113);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(111, 37);
        this.button1.TabIndex = 2;
        this.button1.Text = "Usuń Rekord";
        this.button1.UseVisualStyleBackColor = true;
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // button2
        // 
        this.button2.Location = new System.Drawing.Point(237, 113);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(111, 37);
        this.button2.TabIndex = 3;
        this.button2.Text = "Dodaj Rekord";
        this.button2.UseVisualStyleBackColor = true;
        // 
        // dodanie_komentarza
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.button2);
        this.Controls.Add(this.button1);
        this.Controls.Add(this.dataGridView2);
        this.Controls.Add(this.dataGridView1);
        this.Name = "dodanie_komentarza";
        this.Text = "Form1";
        this.Load += new System.EventHandler(this.Form1_Load);
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.kOMENTARZBindingSource)).EndInit();
        ((System.ComponentModel.ISupportInitialize)(this.mTB)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.DataGridView dataGridView1;
    private MTBTableAdapters.PLECTableAdapter plecTableAdapter1;
    private System.Windows.Forms.DataGridView dataGridView2;
    private MTB mTB;
    private System.Windows.Forms.BindingSource kOMENTARZBindingSource;
    private MTBTableAdapters.KOMENTARZTableAdapter kOMENTARZTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn kOMENTARZIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn wYNIKIDDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn dataDodaniaDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn komentarztrescDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn komentarzautorDataGridViewTextBoxColumn;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
}
