namespace WindowsFormsApp_AW_SQL
{
    partial class Form_przegladaj_wszystkie_komentarze
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
            this.Wszystkie_Komentarze_DataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Wszystkie_Komentarze_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Wszystkie_Komentarze_DataGridView
            // 
            this.Wszystkie_Komentarze_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Wszystkie_Komentarze_DataGridView.Location = new System.Drawing.Point(27, 13);
            this.Wszystkie_Komentarze_DataGridView.Name = "Wszystkie_Komentarze_DataGridView";
            this.Wszystkie_Komentarze_DataGridView.Size = new System.Drawing.Size(488, 296);
            this.Wszystkie_Komentarze_DataGridView.TabIndex = 0;
            this.Wszystkie_Komentarze_DataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Wszystkie_Komentarze_DataGridView_CellContentClick);
            // 
            // Form_przegladaj_wszystkie_komentarze
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 432);
            this.Controls.Add(this.Wszystkie_Komentarze_DataGridView);
            this.MaximizeBox = false;
            this.Name = "Form_przegladaj_wszystkie_komentarze";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wszystkie_Komentarze List";
            this.Load += new System.EventHandler(this.Form_przegladaj_wszystkie_komentarze_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wszystkie_Komentarze_DataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Wszystkie_Komentarze_DataGridView;
    }
}