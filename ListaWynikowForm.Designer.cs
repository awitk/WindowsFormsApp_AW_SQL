namespace WindowsFormsApp_AW_SQL
{
    partial class ListaWynikowForm
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
            this.wynikiDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.wynikiDataGridView.Name = "wynikiDataGridView";
            this.wynikiDataGridView.RowHeadersWidth = 51;
            this.wynikiDataGridView.RowTemplate.Height = 24;
            this.wynikiDataGridView.Size = new System.Drawing.Size(1157, 523);
            this.wynikiDataGridView.TabIndex = 0;
            this.wynikiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.wynikiDataGridView_CellContentClick);
            // 
            // ListaWynikowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 523);
            this.Controls.Add(this.wynikiDataGridView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListaWynikowForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista wyników";
            ((System.ComponentModel.ISupportInitialize)(this.wynikiDataGridView)).EndInit();
            this.ResumeLayout(false);

        }


        private System.Windows.Forms.DataGridView wynikiDataGridView;
    }
}