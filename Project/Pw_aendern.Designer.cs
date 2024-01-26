namespace Project
{
    partial class Pw_aendern
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pw_aendern));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.panel_PW = new System.Windows.Forms.Panel();
            this.PBLogo2 = new System.Windows.Forms.PictureBox();
            this.Spieletraum_PW = new System.Windows.Forms.Label();
            this.CloseHinzufuegen = new System.Windows.Forms.Button();
            this.panel_PW.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Benutzername...";
            this.textBox1.Size = new System.Drawing.Size(248, 23);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(27, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '*';
            this.textBox2.PlaceholderText = "Altes Passwort";
            this.textBox2.Size = new System.Drawing.Size(248, 23);
            this.textBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(114, 188);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ändern";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(27, 159);
            this.textBox3.Name = "textBox3";
            this.textBox3.PasswordChar = '*';
            this.textBox3.PlaceholderText = "Neus Passwort";
            this.textBox3.Size = new System.Drawing.Size(248, 23);
            this.textBox3.TabIndex = 3;
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
            this.panel_PW.Size = new System.Drawing.Size(314, 44);
            this.panel_PW.TabIndex = 7;
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
            this.Spieletraum_PW.Location = new System.Drawing.Point(58, 8);
            this.Spieletraum_PW.Name = "Spieletraum_PW";
            this.Spieletraum_PW.Size = new System.Drawing.Size(211, 29);
            this.Spieletraum_PW.TabIndex = 1;
            this.Spieletraum_PW.Text = "Passwort ändern";
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
            this.CloseHinzufuegen.Location = new System.Drawing.Point(270, 0);
            this.CloseHinzufuegen.Name = "CloseHinzufuegen";
            this.CloseHinzufuegen.Size = new System.Drawing.Size(49, 44);
            this.CloseHinzufuegen.TabIndex = 0;
            this.CloseHinzufuegen.UseVisualStyleBackColor = false;
            this.CloseHinzufuegen.Click += new System.EventHandler(this.CloseHinzufuegen_Click);
            // 
            // Pw_aendern
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 278);
            this.Controls.Add(this.panel_PW);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Pw_aendern";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pw_aendern";
            this.Load += new System.EventHandler(this.Pw_aendern_Load);
            this.panel_PW.ResumeLayout(false);
            this.panel_PW.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Panel panel_PW;
        private PictureBox PBLogo2;
        private Label Spieletraum_PW;
        private Button CloseHinzufuegen;
    }
}