namespace Project
{
    partial class UC_Import
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.TB_Openfile = new System.Windows.Forms.TextBox();
            this.Openfile_Button = new System.Windows.Forms.Button();
            this.Inport_Tabelle = new System.Windows.Forms.DataGridView();
            this.Speichern_Button = new System.Windows.Forms.Button();
            this.Löschen_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Inport_Tabelle)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Openfile
            // 
            this.TB_Openfile.Location = new System.Drawing.Point(220, 121);
            this.TB_Openfile.Name = "TB_Openfile";
            this.TB_Openfile.Size = new System.Drawing.Size(533, 23);
            this.TB_Openfile.TabIndex = 0;
            // 
            // Openfile_Button
            // 
            this.Openfile_Button.BackColor = System.Drawing.Color.MediumPurple;
            this.Openfile_Button.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Openfile_Button.ForeColor = System.Drawing.Color.White;
            this.Openfile_Button.Location = new System.Drawing.Point(788, 121);
            this.Openfile_Button.Name = "Openfile_Button";
            this.Openfile_Button.Size = new System.Drawing.Size(89, 27);
            this.Openfile_Button.TabIndex = 1;
            this.Openfile_Button.Text = "Suchen";
            this.Openfile_Button.UseVisualStyleBackColor = false;
            // 
            // Inport_Tabelle
            // 
            this.Inport_Tabelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Inport_Tabelle.Location = new System.Drawing.Point(33, 173);
            this.Inport_Tabelle.Name = "Inport_Tabelle";
            this.Inport_Tabelle.RowTemplate.Height = 25;
            this.Inport_Tabelle.Size = new System.Drawing.Size(1177, 527);
            this.Inport_Tabelle.TabIndex = 2;
            // 
            // Speichern_Button
            // 
            this.Speichern_Button.BackColor = System.Drawing.Color.MediumPurple;
            this.Speichern_Button.BackgroundImage = global::Project.Properties.Resources.Save3;
            this.Speichern_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Speichern_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Speichern_Button.ForeColor = System.Drawing.Color.White;
            this.Speichern_Button.Location = new System.Drawing.Point(1230, 280);
            this.Speichern_Button.Name = "Speichern_Button";
            this.Speichern_Button.Size = new System.Drawing.Size(88, 78);
            this.Speichern_Button.TabIndex = 3;
            this.Speichern_Button.UseVisualStyleBackColor = false;
            this.Speichern_Button.MouseEnter += new System.EventHandler(this.Speichern_Button_MouseEnter);
            this.Speichern_Button.MouseLeave += new System.EventHandler(this.Speichern_Button_MouseLeave);
            // 
            // Löschen_Button
            // 
            this.Löschen_Button.BackColor = System.Drawing.Color.MediumPurple;
            this.Löschen_Button.BackgroundImage = global::Project.Properties.Resources.Trash;
            this.Löschen_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Löschen_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Löschen_Button.ForeColor = System.Drawing.Color.White;
            this.Löschen_Button.Location = new System.Drawing.Point(1230, 532);
            this.Löschen_Button.Name = "Löschen_Button";
            this.Löschen_Button.Size = new System.Drawing.Size(95, 78);
            this.Löschen_Button.TabIndex = 4;
            this.Löschen_Button.UseVisualStyleBackColor = false;
            this.Löschen_Button.MouseEnter += new System.EventHandler(this.Löschen_Button_MouseEnter);
            this.Löschen_Button.MouseLeave += new System.EventHandler(this.Löschen_Button_MouseLeave);
            // 
            // UC_Import
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.Löschen_Button);
            this.Controls.Add(this.Speichern_Button);
            this.Controls.Add(this.Inport_Tabelle);
            this.Controls.Add(this.Openfile_Button);
            this.Controls.Add(this.TB_Openfile);
            this.Name = "UC_Import";
            this.Size = new System.Drawing.Size(1349, 746);
            ((System.ComponentModel.ISupportInitialize)(this.Inport_Tabelle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox TB_Openfile;
        private Button Openfile_Button;
        private DataGridView Inport_Tabelle;
        private Button Speichern_Button;
        private Button Löschen_Button;
    }
}
