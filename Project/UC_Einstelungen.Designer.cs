namespace Project
{
    partial class UC_Einstelungen
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
            this.PW_Button = new System.Windows.Forms.Button();
            this.US_Button = new System.Windows.Forms.Button();
            this.Server_Button = new System.Windows.Forms.Button();
            this.DB_Button = new System.Windows.Forms.Button();
            this.BEnutzer_Button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PW_Button
            // 
            this.PW_Button.BackColor = System.Drawing.Color.MediumPurple;
            this.PW_Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PW_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.PW_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PW_Button.ForeColor = System.Drawing.Color.White;
            this.PW_Button.Location = new System.Drawing.Point(223, 317);
            this.PW_Button.Name = "PW_Button";
            this.PW_Button.Size = new System.Drawing.Size(233, 85);
            this.PW_Button.TabIndex = 0;
            this.PW_Button.Text = "Passwort ändern";
            this.PW_Button.UseVisualStyleBackColor = false;
            // 
            // US_Button
            // 
            this.US_Button.BackColor = System.Drawing.Color.MediumPurple;
            this.US_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.US_Button.ForeColor = System.Drawing.Color.White;
            this.US_Button.Location = new System.Drawing.Point(550, 317);
            this.US_Button.Name = "US_Button";
            this.US_Button.Size = new System.Drawing.Size(233, 85);
            this.US_Button.TabIndex = 1;
            this.US_Button.Text = "Username ändern";
            this.US_Button.UseVisualStyleBackColor = false;
            // 
            // Server_Button
            // 
            this.Server_Button.BackColor = System.Drawing.Color.MediumPurple;
            this.Server_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Server_Button.ForeColor = System.Drawing.Color.White;
            this.Server_Button.Location = new System.Drawing.Point(871, 317);
            this.Server_Button.Name = "Server_Button";
            this.Server_Button.Size = new System.Drawing.Size(233, 85);
            this.Server_Button.TabIndex = 2;
            this.Server_Button.Text = "Server wechseln";
            this.Server_Button.UseVisualStyleBackColor = false;
            // 
            // DB_Button
            // 
            this.DB_Button.BackColor = System.Drawing.Color.MediumPurple;
            this.DB_Button.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DB_Button.ForeColor = System.Drawing.Color.White;
            this.DB_Button.Location = new System.Drawing.Point(223, 513);
            this.DB_Button.Name = "DB_Button";
            this.DB_Button.Size = new System.Drawing.Size(233, 85);
            this.DB_Button.TabIndex = 3;
            this.DB_Button.Text = "Datenbank wechseln";
            this.DB_Button.UseVisualStyleBackColor = false;
            // 
            // BEnutzer_Button
            // 
            this.BEnutzer_Button.BackColor = System.Drawing.Color.MediumPurple;
            this.BEnutzer_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BEnutzer_Button.ForeColor = System.Drawing.Color.White;
            this.BEnutzer_Button.Location = new System.Drawing.Point(871, 513);
            this.BEnutzer_Button.Name = "BEnutzer_Button";
            this.BEnutzer_Button.Size = new System.Drawing.Size(233, 85);
            this.BEnutzer_Button.TabIndex = 4;
            this.BEnutzer_Button.Text = "Benutzer Einstellung";
            this.BEnutzer_Button.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumPurple;
            this.button1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(551, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(233, 85);
            this.button1.TabIndex = 5;
            this.button1.Text = "Themes";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.GREY_GEAR_LOADING;
            this.pictureBox1.Location = new System.Drawing.Point(539, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(267, 224);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // UC_Einstelungen
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BEnutzer_Button);
            this.Controls.Add(this.DB_Button);
            this.Controls.Add(this.Server_Button);
            this.Controls.Add(this.US_Button);
            this.Controls.Add(this.PW_Button);
            this.Name = "UC_Einstelungen";
            this.Size = new System.Drawing.Size(1349, 746);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button PW_Button;
        private Button US_Button;
        private Button Server_Button;
        private Button DB_Button;
        private Button BEnutzer_Button;
        private Button button1;
        private PictureBox pictureBox1;
    }
}
