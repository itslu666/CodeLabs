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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.Export_Button = new System.Windows.Forms.Button();
            this.Bearbeiten_Button = new System.Windows.Forms.Button();
            this.Loeschen_Button = new System.Windows.Forms.Button();
            this.Hinzufügen_Button = new System.Windows.Forms.Button();
            this.Suchleiste = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Kunden_Panel = new System.Windows.Forms.Panel();
            this.Kunden_Label = new System.Windows.Forms.Label();
            this.Lieferant_Panel = new System.Windows.Forms.Panel();
            this.Lieferant_Label = new System.Windows.Forms.Label();
            this.Artikel_Panel = new System.Windows.Forms.Panel();
            this.Artikel_Label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Kunden_Panel.SuspendLayout();
            this.Lieferant_Panel.SuspendLayout();
            this.Artikel_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelContainer.Controls.Add(this.Export_Button);
            this.PanelContainer.Controls.Add(this.Bearbeiten_Button);
            this.PanelContainer.Controls.Add(this.Loeschen_Button);
            this.PanelContainer.Controls.Add(this.Hinzufügen_Button);
            this.PanelContainer.Controls.Add(this.Suchleiste);
            this.PanelContainer.Controls.Add(this.pictureBox2);
            this.PanelContainer.Controls.Add(this.Kunden_Panel);
            this.PanelContainer.Controls.Add(this.Lieferant_Panel);
            this.PanelContainer.Controls.Add(this.Artikel_Panel);
            this.PanelContainer.Controls.Add(this.dataGridView1);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(0, 0);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1349, 746);
            this.PanelContainer.TabIndex = 7;
            // 
            // Export_Button
            // 
            this.Export_Button.BackColor = System.Drawing.Color.BlueViolet;
            this.Export_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Export_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Export_Button.ForeColor = System.Drawing.Color.White;
            this.Export_Button.Location = new System.Drawing.Point(592, 592);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(337, 65);
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
            this.Bearbeiten_Button.Location = new System.Drawing.Point(900, 35);
            this.Bearbeiten_Button.Name = "Bearbeiten_Button";
            this.Bearbeiten_Button.Size = new System.Drawing.Size(194, 65);
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
            this.Loeschen_Button.Location = new System.Drawing.Point(660, 35);
            this.Loeschen_Button.Name = "Loeschen_Button";
            this.Loeschen_Button.Size = new System.Drawing.Size(194, 65);
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
            this.Hinzufügen_Button.Location = new System.Drawing.Point(402, 35);
            this.Hinzufügen_Button.Name = "Hinzufügen_Button";
            this.Hinzufügen_Button.Size = new System.Drawing.Size(194, 65);
            this.Hinzufügen_Button.TabIndex = 17;
            this.Hinzufügen_Button.Text = "Hinzufügen";
            this.Hinzufügen_Button.UseVisualStyleBackColor = false;
            this.Hinzufügen_Button.Click += new System.EventHandler(this.Hinzufügen_Button_Click);
            this.Hinzufügen_Button.MouseEnter += new System.EventHandler(this.Hinzufügen_Button_MouseEnter);
            this.Hinzufügen_Button.MouseLeave += new System.EventHandler(this.Hinzufügen_Button_MouseLeave);
            // 
            // Suchleiste
            // 
            this.Suchleiste.Location = new System.Drawing.Point(249, 129);
            this.Suchleiste.Name = "Suchleiste";
            this.Suchleiste.PlaceholderText = "Suchen...";
            this.Suchleiste.Size = new System.Drawing.Size(1051, 23);
            this.Suchleiste.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox2.Image = global::Project.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(1306, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // Kunden_Panel
            // 
            this.Kunden_Panel.BackColor = System.Drawing.Color.BlueViolet;
            this.Kunden_Panel.Controls.Add(this.Kunden_Label);
            this.Kunden_Panel.Location = new System.Drawing.Point(16, 448);
            this.Kunden_Panel.Name = "Kunden_Panel";
            this.Kunden_Panel.Size = new System.Drawing.Size(218, 75);
            this.Kunden_Panel.TabIndex = 13;
            this.Kunden_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kunden_Panel_MouseDown);
            this.Kunden_Panel.MouseEnter += new System.EventHandler(this.Kunden_Panel_MouseEnter);
            this.Kunden_Panel.MouseLeave += new System.EventHandler(this.Kunden_Panel_MouseLeave);
            // 
            // Kunden_Label
            // 
            this.Kunden_Label.AutoSize = true;
            this.Kunden_Label.BackColor = System.Drawing.Color.Transparent;
            this.Kunden_Label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kunden_Label.ForeColor = System.Drawing.Color.White;
            this.Kunden_Label.Location = new System.Drawing.Point(66, 25);
            this.Kunden_Label.Name = "Kunden_Label";
            this.Kunden_Label.Size = new System.Drawing.Size(93, 23);
            this.Kunden_Label.TabIndex = 0;
            this.Kunden_Label.Text = "Kunden";
            this.Kunden_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Kunden_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kunden_Label_MouseDown);
            this.Kunden_Label.MouseEnter += new System.EventHandler(this.Kunden_Panel_MouseEnter);
            this.Kunden_Label.MouseLeave += new System.EventHandler(this.Kunden_Panel_MouseLeave);
            // 
            // Lieferant_Panel
            // 
            this.Lieferant_Panel.BackColor = System.Drawing.Color.BlueViolet;
            this.Lieferant_Panel.Controls.Add(this.Lieferant_Label);
            this.Lieferant_Panel.Location = new System.Drawing.Point(16, 318);
            this.Lieferant_Panel.Name = "Lieferant_Panel";
            this.Lieferant_Panel.Size = new System.Drawing.Size(218, 75);
            this.Lieferant_Panel.TabIndex = 12;
            this.Lieferant_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lieferant_Panel_MouseDown);
            this.Lieferant_Panel.MouseEnter += new System.EventHandler(this.Lieferant_Panel_MouseEnter);
            this.Lieferant_Panel.MouseLeave += new System.EventHandler(this.Lieferant_Panel_MouseLeave);
            // 
            // Lieferant_Label
            // 
            this.Lieferant_Label.AutoSize = true;
            this.Lieferant_Label.BackColor = System.Drawing.Color.Transparent;
            this.Lieferant_Label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lieferant_Label.ForeColor = System.Drawing.Color.White;
            this.Lieferant_Label.Location = new System.Drawing.Point(57, 28);
            this.Lieferant_Label.Name = "Lieferant_Label";
            this.Lieferant_Label.Size = new System.Drawing.Size(108, 23);
            this.Lieferant_Label.TabIndex = 0;
            this.Lieferant_Label.Text = "Lieferant";
            this.Lieferant_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lieferant_Panel_MouseDown);
            this.Lieferant_Label.MouseEnter += new System.EventHandler(this.Lieferant_Panel_MouseEnter);
            this.Lieferant_Label.MouseLeave += new System.EventHandler(this.Lieferant_Panel_MouseLeave);
            // 
            // Artikel_Panel
            // 
            this.Artikel_Panel.BackColor = System.Drawing.Color.BlueViolet;
            this.Artikel_Panel.Controls.Add(this.Artikel_Label);
            this.Artikel_Panel.Location = new System.Drawing.Point(16, 189);
            this.Artikel_Panel.Name = "Artikel_Panel";
            this.Artikel_Panel.Size = new System.Drawing.Size(218, 79);
            this.Artikel_Panel.TabIndex = 11;
            this.Artikel_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Artikel_Panel_MouseDown);
            this.Artikel_Panel.MouseEnter += new System.EventHandler(this.Artikel_Panel_MouseHover);
            this.Artikel_Panel.MouseLeave += new System.EventHandler(this.Artikel_Panel_MouseLeave);
            // 
            // Artikel_Label
            // 
            this.Artikel_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Artikel_Label.AutoSize = true;
            this.Artikel_Label.BackColor = System.Drawing.Color.Transparent;
            this.Artikel_Label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Artikel_Label.ForeColor = System.Drawing.Color.White;
            this.Artikel_Label.Location = new System.Drawing.Point(67, 26);
            this.Artikel_Label.Name = "Artikel_Label";
            this.Artikel_Label.Size = new System.Drawing.Size(83, 23);
            this.Artikel_Label.TabIndex = 0;
            this.Artikel_Label.Text = "Artikel";
            this.Artikel_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Artikel_Label_MouseDown);
            this.Artikel_Label.MouseEnter += new System.EventHandler(this.Artikel_Panel_MouseHover);
            this.Artikel_Label.MouseLeave += new System.EventHandler(this.Artikel_Panel_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // UC_Tabelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelContainer);
            this.Name = "UC_Tabelle";
            this.Size = new System.Drawing.Size(1349, 746);
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Kunden_Panel.ResumeLayout(false);
            this.Kunden_Panel.PerformLayout();
            this.Lieferant_Panel.ResumeLayout(false);
            this.Lieferant_Panel.PerformLayout();
            this.Artikel_Panel.ResumeLayout(false);
            this.Artikel_Panel.PerformLayout();
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
        private Panel Kunden_Panel;
        private Label Kunden_Label;
        private Panel Lieferant_Panel;
        private Label Lieferant_Label;
        private Panel Artikel_Panel;
        private Label Artikel_Label;
        private DataGridView dataGridView1;
    }
}
