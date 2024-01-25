namespace Project
{
    partial class Themes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themes));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_Loeschen = new System.Windows.Forms.Panel();
            this.PBLogo2 = new System.Windows.Forms.PictureBox();
            this.Spieletraum_Loeschen = new System.Windows.Forms.Label();
            this.CloseLoeschen = new System.Windows.Forms.Button();
            this.panel_Loeschen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(67, 103);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(67, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(67, 189);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel_Loeschen
            // 
            this.panel_Loeschen.BackColor = System.Drawing.Color.BlueViolet;
            this.panel_Loeschen.Controls.Add(this.PBLogo2);
            this.panel_Loeschen.Controls.Add(this.Spieletraum_Loeschen);
            this.panel_Loeschen.Controls.Add(this.CloseLoeschen);
            this.panel_Loeschen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Loeschen.Location = new System.Drawing.Point(0, 0);
            this.panel_Loeschen.Name = "panel_Loeschen";
            this.panel_Loeschen.Size = new System.Drawing.Size(291, 44);
            this.panel_Loeschen.TabIndex = 8;
            // 
            // PBLogo2
            // 
            this.PBLogo2.Image = global::Project.Properties.Resources.Change_Theme;
            this.PBLogo2.Location = new System.Drawing.Point(15, 4);
            this.PBLogo2.Name = "PBLogo2";
            this.PBLogo2.Size = new System.Drawing.Size(37, 33);
            this.PBLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo2.TabIndex = 8;
            this.PBLogo2.TabStop = false;
            // 
            // Spieletraum_Loeschen
            // 
            this.Spieletraum_Loeschen.AutoSize = true;
            this.Spieletraum_Loeschen.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Spieletraum_Loeschen.ForeColor = System.Drawing.Color.White;
            this.Spieletraum_Loeschen.Location = new System.Drawing.Point(67, 4);
            this.Spieletraum_Loeschen.Name = "Spieletraum_Loeschen";
            this.Spieletraum_Loeschen.Size = new System.Drawing.Size(107, 29);
            this.Spieletraum_Loeschen.TabIndex = 1;
            this.Spieletraum_Loeschen.Text = "Themes";
            // 
            // CloseLoeschen
            // 
            this.CloseLoeschen.BackColor = System.Drawing.Color.BlueViolet;
            this.CloseLoeschen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseLoeschen.BackgroundImage")));
            this.CloseLoeschen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseLoeschen.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseLoeschen.FlatAppearance.BorderSize = 0;
            this.CloseLoeschen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseLoeschen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseLoeschen.Location = new System.Drawing.Point(242, 1);
            this.CloseLoeschen.Name = "CloseLoeschen";
            this.CloseLoeschen.Size = new System.Drawing.Size(49, 44);
            this.CloseLoeschen.TabIndex = 0;
            this.CloseLoeschen.UseVisualStyleBackColor = false;
            // 
            // Themes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 281);
            this.Controls.Add(this.panel_Loeschen);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Themes";
            this.Text = "Themes";
            this.panel_Loeschen.ResumeLayout(false);
            this.panel_Loeschen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel_Loeschen;
        private PictureBox PBLogo2;
        private Label Spieletraum_Loeschen;
        private Button CloseLoeschen;
    }
}