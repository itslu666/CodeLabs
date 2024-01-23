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
            this.UserTB = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilbild)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.DarkMagenta;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(1, 4);
            this.monthCalendar1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.monthCalendar1.ForeColor = System.Drawing.Color.BlueViolet;
            this.monthCalendar1.Location = new System.Drawing.Point(1171, 139);
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
            this.label1.Location = new System.Drawing.Point(511, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hallo Nutzer!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.Spieltraum_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(487, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 174);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // PBUser
            // 
            this.PBUser.Image = global::Project.Properties.Resources.Circle;
            this.PBUser.Location = new System.Drawing.Point(1210, 16);
            this.PBUser.Name = "PBUser";
            this.PBUser.Size = new System.Drawing.Size(109, 91);
            this.PBUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBUser.TabIndex = 5;
            this.PBUser.TabStop = false;
            // 
            // UserProfilbild
            // 
            this.UserProfilbild.Image = global::Project.Properties.Resources.User;
            this.UserProfilbild.Location = new System.Drawing.Point(1237, 36);
            this.UserProfilbild.Name = "UserProfilbild";
            this.UserProfilbild.Size = new System.Drawing.Size(54, 52);
            this.UserProfilbild.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UserProfilbild.TabIndex = 6;
            this.UserProfilbild.TabStop = false;
            this.UserProfilbild.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // UserTB
            // 
            this.UserTB.Location = new System.Drawing.Point(1171, 113);
            this.UserTB.Name = "UserTB";
            this.UserTB.Size = new System.Drawing.Size(175, 23);
            this.UserTB.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(239, 305);
            this.textBox1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(16, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 351);
            this.panel1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(88, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Notizen";
            // 
            // UC_Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.UserTB);
            this.Controls.Add(this.UserProfilbild);
            this.Controls.Add(this.PBUser);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(1349, 746);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilbild)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MonthCalendar monthCalendar1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox PBUser;
        private PictureBox UserProfilbild;
        private TextBox UserTB;
        private TextBox textBox1;
        private Panel panel1;
        private Label label2;
    }
}
