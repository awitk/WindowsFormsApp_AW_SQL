namespace WindowsFormsApp_AW_SQL
{
    partial class ListaWynikowForm
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
            this.wynikiDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.wynikiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // wynikiDataGridView
            // 
            this.wynikiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wynikiDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wynikiDataGridView.Location = new System.Drawing.Point(0, 0);
            this.wynikiDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.wynikiDataGridView.Name = "wynikiDataGridView";
            this.wynikiDataGridView.RowHeadersWidth = 51;
            this.wynikiDataGridView.RowTemplate.Height = 24;
            this.wynikiDataGridView.Size = new System.Drawing.Size(981, 509);
            this.wynikiDataGridView.TabIndex = 0;
            this.wynikiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wynikiDataGridView_CellContentClick);
            // 
            // ListaWynikowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 509);
            this.Controls.Add(this.wynikiDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListaWynikowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista wyników";
            ((System.ComponentModel.ISupportInitialize)(this.wynikiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView wynikiDataGridView;
    }
}