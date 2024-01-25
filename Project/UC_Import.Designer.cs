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
            TB_Openfile = new TextBox();
            Openfile_Button = new Button();
            Inport_Tabelle = new DataGridView();
            Speichern_Button = new Button();
            Löschen_Button = new Button();
            ((System.ComponentModel.ISupportInitialize)Inport_Tabelle).BeginInit();
            SuspendLayout();
            // 
            // TB_Openfile
            // 
            TB_Openfile.Location = new Point(47, 125);
            TB_Openfile.Name = "TB_Openfile";
            TB_Openfile.PlaceholderText = "Tabellen name eingeben...";
            TB_Openfile.Size = new Size(1082, 23);
            TB_Openfile.TabIndex = 0;
            // 
            // Openfile_Button
            // 
            Openfile_Button.BackColor = Color.MediumPurple;
            Openfile_Button.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Openfile_Button.ForeColor = Color.White;
            Openfile_Button.Location = new Point(1135, 125);
            Openfile_Button.Name = "Openfile_Button";
            Openfile_Button.Size = new Size(89, 27);
            Openfile_Button.TabIndex = 1;
            Openfile_Button.Text = "Suchen";
            Openfile_Button.UseVisualStyleBackColor = false;
            Openfile_Button.Click += Openfile_Button_Click;
            // 
            // Inport_Tabelle
            // 
            Inport_Tabelle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Inport_Tabelle.Location = new Point(47, 154);
            Inport_Tabelle.Name = "Inport_Tabelle";
            Inport_Tabelle.RowTemplate.Height = 25;
            Inport_Tabelle.Size = new Size(1177, 527);
            Inport_Tabelle.TabIndex = 2;
            // 
            // Speichern_Button
            // 
            Speichern_Button.BackColor = Color.MediumPurple;
            Speichern_Button.BackgroundImage = Properties.Resources.Save3;
            Speichern_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Speichern_Button.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Speichern_Button.ForeColor = Color.White;
            Speichern_Button.Location = new Point(1238, 276);
            Speichern_Button.Name = "Speichern_Button";
            Speichern_Button.Size = new Size(80, 80);
            Speichern_Button.TabIndex = 3;
            Speichern_Button.UseVisualStyleBackColor = false;
            Speichern_Button.Click += Speichern_Button_Click;
            Speichern_Button.MouseEnter += Speichern_Button_MouseEnter;
            Speichern_Button.MouseLeave += Speichern_Button_MouseLeave;
            // 
            // Löschen_Button
            // 
            Löschen_Button.BackColor = Color.MediumPurple;
            Löschen_Button.BackgroundImage = Properties.Resources.Trash;
            Löschen_Button.BackgroundImageLayout = ImageLayout.Stretch;
            Löschen_Button.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Löschen_Button.ForeColor = Color.White;
            Löschen_Button.Location = new Point(1238, 533);
            Löschen_Button.Name = "Löschen_Button";
            Löschen_Button.Size = new Size(80, 80);
            Löschen_Button.TabIndex = 4;
            Löschen_Button.UseVisualStyleBackColor = false;
            Löschen_Button.Click += Löschen_Button_Click;
            Löschen_Button.MouseEnter += Löschen_Button_MouseEnter;
            Löschen_Button.MouseLeave += Löschen_Button_MouseLeave;
            // 
            // UC_Import
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackgroundImage = Properties.Resources._4493324_weiss_und_lila_verlauf_hintergrund_kostenlos_foto;
            Controls.Add(Löschen_Button);
            Controls.Add(Speichern_Button);
            Controls.Add(Inport_Tabelle);
            Controls.Add(Openfile_Button);
            Controls.Add(TB_Openfile);
            Name = "UC_Import";
            Size = new Size(1349, 746);
            ((System.ComponentModel.ISupportInitialize)Inport_Tabelle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TB_Openfile;
        private Button Openfile_Button;
        private DataGridView Inport_Tabelle;
        private Button Speichern_Button;
        private Button Löschen_Button;
    }
}
