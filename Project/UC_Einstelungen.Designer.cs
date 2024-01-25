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
            PW_Button = new Button();
            US_Button = new Button();
            Server_Button = new Button();
            DB_Button = new Button();
            BEnutzer_Button = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // PW_Button
            // 
            PW_Button.BackColor = Color.MediumPurple;
            PW_Button.FlatAppearance.MouseDownBackColor = Color.White;
            PW_Button.FlatAppearance.MouseOverBackColor = Color.Purple;
            PW_Button.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PW_Button.ForeColor = Color.White;
            PW_Button.Location = new Point(223, 317);
            PW_Button.Name = "PW_Button";
            PW_Button.Size = new Size(233, 85);
            PW_Button.TabIndex = 0;
            PW_Button.Text = "Passwort ändern";
            PW_Button.UseVisualStyleBackColor = false;
            PW_Button.Click += PW_Button_Click;
            // 
            // US_Button
            // 
            US_Button.BackColor = Color.MediumPurple;
            US_Button.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            US_Button.ForeColor = Color.White;
            US_Button.Location = new Point(550, 317);
            US_Button.Name = "US_Button";
            US_Button.Size = new Size(233, 85);
            US_Button.TabIndex = 1;
            US_Button.Text = "Username ändern";
            US_Button.UseVisualStyleBackColor = false;
            // 
            // Server_Button
            // 
            Server_Button.BackColor = Color.MediumPurple;
            Server_Button.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Server_Button.ForeColor = Color.White;
            Server_Button.Location = new Point(871, 317);
            Server_Button.Name = "Server_Button";
            Server_Button.Size = new Size(233, 85);
            Server_Button.TabIndex = 2;
            Server_Button.Text = "Server wechseln";
            Server_Button.UseVisualStyleBackColor = false;
            Server_Button.Click += Server_Button_Click;
            // 
            // DB_Button
            // 
            DB_Button.BackColor = Color.MediumPurple;
            DB_Button.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            DB_Button.ForeColor = Color.White;
            DB_Button.Location = new Point(223, 513);
            DB_Button.Name = "DB_Button";
            DB_Button.Size = new Size(233, 85);
            DB_Button.TabIndex = 3;
            DB_Button.Text = "Datenbank wechseln";
            DB_Button.UseVisualStyleBackColor = false;
            // 
            // BEnutzer_Button
            // 
            BEnutzer_Button.BackColor = Color.MediumPurple;
            BEnutzer_Button.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BEnutzer_Button.ForeColor = Color.White;
            BEnutzer_Button.Location = new Point(871, 513);
            BEnutzer_Button.Name = "BEnutzer_Button";
            BEnutzer_Button.Size = new Size(233, 85);
            BEnutzer_Button.TabIndex = 4;
            BEnutzer_Button.Text = "Benutzer Einstellung";
            BEnutzer_Button.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(551, 513);
            button1.Name = "button1";
            button1.Size = new Size(233, 85);
            button1.TabIndex = 5;
            button1.Text = "Themes";
            button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.GREY_GEAR_LOADING;
            pictureBox1.Location = new Point(539, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // UC_Einstelungen
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources._4493324_weiss_und_lila_verlauf_hintergrund_kostenlos_foto;
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(BEnutzer_Button);
            Controls.Add(DB_Button);
            Controls.Add(Server_Button);
            Controls.Add(US_Button);
            Controls.Add(PW_Button);
            Name = "UC_Einstelungen";
            Size = new Size(1349, 746);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
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
