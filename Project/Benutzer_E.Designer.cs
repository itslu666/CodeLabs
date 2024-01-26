namespace Project
{
    partial class Benutzer_E
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Benutzer_E));
            this.panel_PW = new System.Windows.Forms.Panel();
            this.PBLogo2 = new System.Windows.Forms.PictureBox();
            this.Spieletraum_PW = new System.Windows.Forms.Label();
            this.CloseHinzufuegen = new System.Windows.Forms.Button();
            this.BenutzerHIN_button = new System.Windows.Forms.Button();
            this.BenutzerBEA_button = new System.Windows.Forms.Button();
            this.BenutzerENT_button = new System.Windows.Forms.Button();
            this.panel_PW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_PW
            // 
            this.panel_PW.BackColor = System.Drawing.Color.BlueViolet;
            this.panel_PW.Controls.Add(this.PBLogo2);
            this.panel_PW.Controls.Add(this.Spieletraum_PW);
            this.panel_PW.Controls.Add(this.CloseHinzufuegen);
            this.panel_PW.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_PW.Location = new System.Drawing.Point(0, 0);
            this.panel_PW.Name = "panel_PW";
            this.panel_PW.Size = new System.Drawing.Size(397, 44);
            this.panel_PW.TabIndex = 8;
            this.panel_PW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_PW_MouseDown);
            // 
            // PBLogo2
            // 
            this.PBLogo2.Image = global::Project.Properties.Resources.Password;
            this.PBLogo2.Location = new System.Drawing.Point(15, 4);
            this.PBLogo2.Name = "PBLogo2";
            this.PBLogo2.Size = new System.Drawing.Size(37, 33);
            this.PBLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo2.TabIndex = 8;
            this.PBLogo2.TabStop = false;
            this.PBLogo2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_PW_MouseDown);
            // 
            // Spieletraum_PW
            // 
            this.Spieletraum_PW.AutoSize = true;
            this.Spieletraum_PW.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Spieletraum_PW.ForeColor = System.Drawing.Color.White;
            this.Spieletraum_PW.Location = new System.Drawing.Point(58, 9);
            this.Spieletraum_PW.Name = "Spieletraum_PW";
            this.Spieletraum_PW.Size = new System.Drawing.Size(285, 29);
            this.Spieletraum_PW.TabIndex = 1;
            this.Spieletraum_PW.Text = "Benutzer Einstellungen";
            this.Spieletraum_PW.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_PW_MouseDown);
            // 
            // CloseHinzufuegen
            // 
            this.CloseHinzufuegen.BackColor = System.Drawing.Color.BlueViolet;
            this.CloseHinzufuegen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseHinzufuegen.BackgroundImage")));
            this.CloseHinzufuegen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseHinzufuegen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseHinzufuegen.FlatAppearance.BorderSize = 0;
            this.CloseHinzufuegen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseHinzufuegen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseHinzufuegen.Location = new System.Drawing.Point(349, 0);
            this.CloseHinzufuegen.Name = "CloseHinzufuegen";
            this.CloseHinzufuegen.Size = new System.Drawing.Size(49, 44);
            this.CloseHinzufuegen.TabIndex = 0;
            this.CloseHinzufuegen.UseVisualStyleBackColor = false;
            this.CloseHinzufuegen.Click += new System.EventHandler(this.CloseHinzufuegen_Click);
            // 
            // BenutzerHIN_button
            // 
            this.BenutzerHIN_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BenutzerHIN_button.Location = new System.Drawing.Point(90, 97);
            this.BenutzerHIN_button.Name = "BenutzerHIN_button";
            this.BenutzerHIN_button.Size = new System.Drawing.Size(216, 48);
            this.BenutzerHIN_button.TabIndex = 9;
            this.BenutzerHIN_button.Text = "Benutzer Hinzufügen";
            this.BenutzerHIN_button.UseVisualStyleBackColor = true;
            this.BenutzerHIN_button.Click += new System.EventHandler(this.BenutzerHIN_button_Click);
            // 
            // BenutzerBEA_button
            // 
            this.BenutzerBEA_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BenutzerBEA_button.Location = new System.Drawing.Point(90, 161);
            this.BenutzerBEA_button.Name = "BenutzerBEA_button";
            this.BenutzerBEA_button.Size = new System.Drawing.Size(216, 48);
            this.BenutzerBEA_button.TabIndex = 10;
            this.BenutzerBEA_button.Text = "Benutzer Bearbeiten";
            this.BenutzerBEA_button.UseVisualStyleBackColor = true;
            this.BenutzerBEA_button.Click += new System.EventHandler(this.BenutzerBEA_button_Click);
            // 
            // BenutzerENT_button
            // 
            this.BenutzerENT_button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BenutzerENT_button.Location = new System.Drawing.Point(90, 227);
            this.BenutzerENT_button.Name = "BenutzerENT_button";
            this.BenutzerENT_button.Size = new System.Drawing.Size(216, 48);
            this.BenutzerENT_button.TabIndex = 11;
            this.BenutzerENT_button.Text = "Benutzer Entfernen";
            this.BenutzerENT_button.UseVisualStyleBackColor = true;
            this.BenutzerENT_button.Click += new System.EventHandler(this.BenutzerENT_button_Click);
            // 
            // Benutzer_E
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 373);
            this.Controls.Add(this.BenutzerENT_button);
            this.Controls.Add(this.BenutzerBEA_button);
            this.Controls.Add(this.BenutzerHIN_button);
            this.Controls.Add(this.panel_PW);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Benutzer_E";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Benutzer_E";
            this.Load += new System.EventHandler(this.Benutzer_E_Load);
            this.panel_PW.ResumeLayout(false);
            this.panel_PW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_PW;
        private PictureBox PBLogo2;
        private Label Spieletraum_PW;
        private Button CloseHinzufuegen;
        private Button BenutzerHIN_button;
        private Button BenutzerBEA_button;
        private Button BenutzerENT_button;
    }
}