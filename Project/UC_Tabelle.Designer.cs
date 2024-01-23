namespace Project
{
    partial class UC_Tabelle
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.Kunden_Panel = new System.Windows.Forms.Button();
            this.Lieferant_Panel = new System.Windows.Forms.Button();
            this.Artikel_Panel = new System.Windows.Forms.Button();
            this.Export_Button = new System.Windows.Forms.Button();
            this.Bearbeiten_Button = new System.Windows.Forms.Button();
            this.Loeschen_Button = new System.Windows.Forms.Button();
            this.Hinzufügen_Button = new System.Windows.Forms.Button();
            this.Suchleiste = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelContainer.Controls.Add(this.Kunden_Panel);
            this.PanelContainer.Controls.Add(this.Lieferant_Panel);
            this.PanelContainer.Controls.Add(this.Artikel_Panel);
            this.PanelContainer.Controls.Add(this.Export_Button);
            this.PanelContainer.Controls.Add(this.Bearbeiten_Button);
            this.PanelContainer.Controls.Add(this.Loeschen_Button);
            this.PanelContainer.Controls.Add(this.Hinzufügen_Button);
            this.PanelContainer.Controls.Add(this.Suchleiste);
            this.PanelContainer.Controls.Add(this.pictureBox2);
            this.PanelContainer.Controls.Add(this.dataGridView1);
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1343, 736);
            this.PanelContainer.TabIndex = 7;
            // 
            // Kunden_Panel
            // 
            this.Kunden_Panel.BackColor = System.Drawing.Color.BlueViolet;
            this.Kunden_Panel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Kunden_Panel.ForeColor = System.Drawing.Color.White;
            this.Kunden_Panel.Location = new System.Drawing.Point(30, 523);
            this.Kunden_Panel.Name = "Kunden_Panel";
            this.Kunden_Panel.Size = new System.Drawing.Size(186, 63);
            this.Kunden_Panel.TabIndex = 23;
            this.Kunden_Panel.Text = "Kunden";
            this.Kunden_Panel.UseVisualStyleBackColor = false;
            this.Kunden_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kunden_Panel_MouseDown);
            this.Kunden_Panel.MouseEnter += new System.EventHandler(this.Kunden_Panel_MouseEnter);
            this.Kunden_Panel.MouseLeave += new System.EventHandler(this.Kunden_Panel_MouseLeave);
            // 
            // Lieferant_Panel
            // 
            this.Lieferant_Panel.BackColor = System.Drawing.Color.BlueViolet;
            this.Lieferant_Panel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Lieferant_Panel.ForeColor = System.Drawing.Color.White;
            this.Lieferant_Panel.Location = new System.Drawing.Point(30, 415);
            this.Lieferant_Panel.Name = "Lieferant_Panel";
            this.Lieferant_Panel.Size = new System.Drawing.Size(186, 63);
            this.Lieferant_Panel.TabIndex = 22;
            this.Lieferant_Panel.Text = "Lieferant";
            this.Lieferant_Panel.UseVisualStyleBackColor = false;
            this.Lieferant_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lieferant_Panel_MouseDown);
            this.Lieferant_Panel.MouseEnter += new System.EventHandler(this.Lieferant_Panel_MouseEnter);
            this.Lieferant_Panel.MouseLeave += new System.EventHandler(this.Lieferant_Panel_MouseLeave);
            // 
            // Artikel_Panel
            // 
            this.Artikel_Panel.BackColor = System.Drawing.Color.BlueViolet;
            this.Artikel_Panel.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Artikel_Panel.ForeColor = System.Drawing.Color.White;
            this.Artikel_Panel.Location = new System.Drawing.Point(30, 310);
            this.Artikel_Panel.Name = "Artikel_Panel";
            this.Artikel_Panel.Size = new System.Drawing.Size(186, 63);
            this.Artikel_Panel.TabIndex = 21;
            this.Artikel_Panel.Text = "Artikel";
            this.Artikel_Panel.UseVisualStyleBackColor = false;
            this.Artikel_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Artikel_Panel_MouseDown);
            this.Artikel_Panel.MouseEnter += new System.EventHandler(this.Artikel_Panel_MouseHover);
            this.Artikel_Panel.MouseLeave += new System.EventHandler(this.Artikel_Panel_MouseLeave);
            // 
            // Export_Button
            // 
            this.Export_Button.BackColor = System.Drawing.Color.BlueViolet;
            this.Export_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Export_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Export_Button.ForeColor = System.Drawing.Color.White;
            this.Export_Button.Location = new System.Drawing.Point(623, 650);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(260, 46);
            this.Export_Button.TabIndex = 20;
            this.Export_Button.Text = "Export Tabelle";
            this.Export_Button.UseVisualStyleBackColor = false;
            this.Export_Button.MouseEnter += new System.EventHandler(this.Export_Button_MouseEnter);
            this.Export_Button.MouseLeave += new System.EventHandler(this.Export_Button_MouseLeave);
            // 
            // Bearbeiten_Button
            // 
            this.Bearbeiten_Button.BackColor = System.Drawing.Color.BlueViolet;
            this.Bearbeiten_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.Bearbeiten_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bearbeiten_Button.ForeColor = System.Drawing.Color.White;
            this.Bearbeiten_Button.Location = new System.Drawing.Point(1009, 121);
            this.Bearbeiten_Button.Name = "Bearbeiten_Button";
            this.Bearbeiten_Button.Size = new System.Drawing.Size(187, 69);
            this.Bearbeiten_Button.TabIndex = 19;
            this.Bearbeiten_Button.Text = "Bearbeiten";
            this.Bearbeiten_Button.UseVisualStyleBackColor = false;
            this.Bearbeiten_Button.Click += new System.EventHandler(this.Bearbeiten_Button_Click);
            this.Bearbeiten_Button.MouseEnter += new System.EventHandler(this.Bearbeiten_Button_MouseEnter);
            this.Bearbeiten_Button.MouseLeave += new System.EventHandler(this.Bearbeiten_Button_MouseLeave);
            // 
            // Loeschen_Button
            // 
            this.Loeschen_Button.BackColor = System.Drawing.Color.BlueViolet;
            this.Loeschen_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.Loeschen_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Loeschen_Button.ForeColor = System.Drawing.Color.White;
            this.Loeschen_Button.Location = new System.Drawing.Point(659, 121);
            this.Loeschen_Button.Name = "Loeschen_Button";
            this.Loeschen_Button.Size = new System.Drawing.Size(187, 69);
            this.Loeschen_Button.TabIndex = 18;
            this.Loeschen_Button.Text = "Löschen";
            this.Loeschen_Button.UseVisualStyleBackColor = false;
            this.Loeschen_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loeschen_Button_MouseDown);
            this.Loeschen_Button.MouseEnter += new System.EventHandler(this.Loeschen_Button_MouseEnter);
            this.Loeschen_Button.MouseLeave += new System.EventHandler(this.Loeschen_Button_MouseLeave);
            // 
            // Hinzufügen_Button
            // 
            this.Hinzufügen_Button.BackColor = System.Drawing.Color.BlueViolet;
            this.Hinzufügen_Button.FlatAppearance.BorderSize = 5;
            this.Hinzufügen_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.Hinzufügen_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hinzufügen_Button.ForeColor = System.Drawing.Color.White;
            this.Hinzufügen_Button.Location = new System.Drawing.Point(345, 121);
            this.Hinzufügen_Button.Name = "Hinzufügen_Button";
            this.Hinzufügen_Button.Size = new System.Drawing.Size(187, 69);
            this.Hinzufügen_Button.TabIndex = 17;
            this.Hinzufügen_Button.Text = "Hinzufügen";
            this.Hinzufügen_Button.UseVisualStyleBackColor = false;
            this.Hinzufügen_Button.Click += new System.EventHandler(this.Hinzufügen_Button_Click);
            this.Hinzufügen_Button.MouseEnter += new System.EventHandler(this.Hinzufügen_Button_MouseEnter);
            this.Hinzufügen_Button.MouseLeave += new System.EventHandler(this.Hinzufügen_Button_MouseLeave);
            // 
            // Suchleiste
            // 
            this.Suchleiste.Location = new System.Drawing.Point(239, 227);
            this.Suchleiste.Name = "Suchleiste";
            this.Suchleiste.PlaceholderText = "Suchen...";
            this.Suchleiste.Size = new System.Drawing.Size(1053, 23);
            this.Suchleiste.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox2.Image = global::Project.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(1298, 227);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(239, 256);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1090, 379);
            this.dataGridView1.TabIndex = 0;
            // 
            // UC_Tabelle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.PanelContainer);
            this.Name = "UC_Tabelle";
            this.Size = new System.Drawing.Size(1349, 746);
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel PanelContainer;
        private Button Export_Button;
        private Button Bearbeiten_Button;
        private Button Loeschen_Button;
        private Button Hinzufügen_Button;
        private TextBox Suchleiste;
        private PictureBox pictureBox2;
        private DataGridView dataGridView1;
        private Button Kunden_Panel;
        private Button Lieferant_Panel;
        private Button Artikel_Panel;
    }
}
