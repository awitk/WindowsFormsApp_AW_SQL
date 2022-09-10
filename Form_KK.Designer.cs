
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_AW_SQL.Models;

namespace WindowsFormsApp_AW_SQL
{
    partial class Form_KK
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
            this.components = new System.ComponentModel.Container();
            this.label1_wybierz_kk = new System.Windows.Forms.Label();
            this.comboBox_kk = new System.Windows.Forms.ComboBox();
            this.kLUBKOLARSKIBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mTB = new WindowsFormsApp_AW_SQL.MTB();
            this.Button_combo_click = new System.Windows.Forms.Button();
            this.kLUB_KOLARSKITableAdapter = new WindowsFormsApp_AW_SQL.MTBTableAdapters.KLUB_KOLARSKITableAdapter();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.kLUBKOLARSKIBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTB)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1_wybierz_kk
            // 
            this.label1_wybierz_kk.AutoSize = true;
            this.label1_wybierz_kk.Location = new System.Drawing.Point(32, 23);
            this.label1_wybierz_kk.Name = "label1_wybierz_kk";
            this.label1_wybierz_kk.Size = new System.Drawing.Size(137, 13);
            this.label1_wybierz_kk.TabIndex = 0;
            this.label1_wybierz_kk.Text = "Wybierz Klub Kolarski z listy";
            // 
            // comboBox_kk
            // 
            this.comboBox_kk.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.kLUBKOLARSKIBindingSource, "Klub_Nazwa", true));
            this.comboBox_kk.DataSource = this.kLUBKOLARSKIBindingSource;
            this.comboBox_kk.DisplayMember = "Klub_Nazwa";
            this.comboBox_kk.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_kk.FormattingEnabled = true;
            this.comboBox_kk.Location = new System.Drawing.Point(49, 68);
            this.comboBox_kk.Name = "comboBox_kk";
            this.comboBox_kk.Size = new System.Drawing.Size(121, 21);
            this.comboBox_kk.TabIndex = 1;
            this.comboBox_kk.ValueMember = "Klub_Nazwa";
            this.comboBox_kk.SelectedIndexChanged += new System.EventHandler(this.comboBox_kk_SelectedIndexChanged);
            // 
            // kLUBKOLARSKIBindingSource
            // 
            this.kLUBKOLARSKIBindingSource.DataMember = "KLUB_KOLARSKI";
            this.kLUBKOLARSKIBindingSource.DataSource = this.mTB;
            // 
            // mTB
            // 
            this.mTB.DataSetName = "MTB";
            this.mTB.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Button_combo_click
            // 
            this.Button_combo_click.Location = new System.Drawing.Point(49, 118);
            this.Button_combo_click.Name = "Button_combo_click";
            this.Button_combo_click.Size = new System.Drawing.Size(94, 27);
            this.Button_combo_click.TabIndex = 2;
            this.Button_combo_click.Text = "ok";
            this.Button_combo_click.UseVisualStyleBackColor = true;
            this.Button_combo_click.Click += new System.EventHandler(this.add_string_Click);
            // 
            // kLUB_KOLARSKITableAdapter
            // 
            this.kLUB_KOLARSKITableAdapter.ClearBeforeFill = true;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(425, 25);
            this.fillByToolStrip.TabIndex = 3;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // Form_KK
            // 
            this.ClientSize = new System.Drawing.Size(425, 215);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.Button_combo_click);
            this.Controls.Add(this.comboBox_kk);
            this.Controls.Add(this.label1_wybierz_kk);
            this.Name = "Form_KK";
            this.Load += new System.EventHandler(this.Form_KK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kLUBKOLARSKIBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mTB)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

      

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1_wybierz_kk;
        private System.Windows.Forms.ComboBox comboBox_kk;
        private System.Windows.Forms.Button Button_combo_click;
        private MTB mTB;
        private System.Windows.Forms.BindingSource kLUBKOLARSKIBindingSource;
        private MTBTableAdapters.KLUB_KOLARSKITableAdapter kLUB_KOLARSKITableAdapter;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
    }
}
