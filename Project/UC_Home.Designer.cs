namespace Project
{
    partial class UC_Home
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PBUser = new System.Windows.Forms.PictureBox();
            this.UserProfilbild = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Tabelle_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilbild)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.DarkMagenta;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(5, 1);
            this.monthCalendar1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCalendar1.ForeColor = System.Drawing.Color.BlueViolet;
            this.monthCalendar1.Location = new System.Drawing.Point(200, 462);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.BlueViolet;
            this.monthCalendar1.TitleForeColor = System.Drawing.Color.Indigo;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.DarkViolet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(519, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hallo Nutzer!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Project.Properties.Resources.Spieltraum_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(437, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 273);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PBUser
            // 
            this.PBUser.Image = global::Project.Properties.Resources.Circle;
            this.PBUser.Location = new System.Drawing.Point(606, 7);
            this.PBUser.Name = "PBUser";
            this.PBUser.Size = new System.Drawing.Size(109, 91);
            this.PBUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBUser.TabIndex = 5;
            this.PBUser.TabStop = false;
            // 
            // UserProfilbild
            // 
            this.UserProfilbild.Image = global::Project.Properties.Resources.User;
            this.UserProfilbild.Location = new System.Drawing.Point(633, 27);
            this.UserProfilbild.Name = "UserProfilbild";
            this.UserProfilbild.Size = new System.Drawing.Size(54, 52);
            this.UserProfilbild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserProfilbild.TabIndex = 6;
            this.UserProfilbild.TabStop = false;
            this.UserProfilbild.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(611, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "UserTest";
            // 
            // Tabelle_Button
            // 
            this.Tabelle_Button.BackColor = System.Drawing.Color.MediumPurple;
            this.Tabelle_Button.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Tabelle_Button.ForeColor = System.Drawing.Color.White;
            this.Tabelle_Button.Location = new System.Drawing.Point(550, 636);
            this.Tabelle_Button.Name = "Tabelle_Button";
            this.Tabelle_Button.Size = new System.Drawing.Size(211, 76);
            this.Tabelle_Button.TabIndex = 11;
            this.Tabelle_Button.Text = "Zur Tabellen Übersicht wechseln";
            this.Tabelle_Button.UseVisualStyleBackColor = false;
            this.Tabelle_Button.MouseEnter += new System.EventHandler(this.Tabelle_Button_MouseEnter);
            this.Tabelle_Button.MouseLeave += new System.EventHandler(this.Tabelle_Button_MouseLeave);
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tabelle_Button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.UserProfilbild);
            this.Controls.Add(this.PBUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1349, 746);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilbild)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MonthCalendar monthCalendar1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox PBUser;
        private PictureBox UserProfilbild;
        private Label label3;
        private Button Tabelle_Button;
    }
}
