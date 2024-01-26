namespace Project
{
    partial class Loeschen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loeschen));
            this.panel_Loeschen = new System.Windows.Forms.Panel();
            this.PBLogo2 = new System.Windows.Forms.PictureBox();
            this.Spieletraum_Loeschen = new System.Windows.Forms.Label();
            this.CloseLoeschen = new System.Windows.Forms.Button();
            this.textbox = new System.Windows.Forms.TextBox();
            this.button = new System.Windows.Forms.Button();
            this.panel_Loeschen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).BeginInit();
            this.SuspendLayout();
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
            this.panel_Loeschen.Size = new System.Drawing.Size(521, 44);
            this.panel_Loeschen.TabIndex = 7;
            this.panel_Loeschen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Loeschen_MouseDown);
            // 
            // PBLogo2
            // 
            this.PBLogo2.Image = global::Project.Properties.Resources.Trash;
            this.PBLogo2.Location = new System.Drawing.Point(15, 4);
            this.PBLogo2.Name = "PBLogo2";
            this.PBLogo2.Size = new System.Drawing.Size(37, 33);
            this.PBLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo2.TabIndex = 8;
            this.PBLogo2.TabStop = false;
            this.PBLogo2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Loeschen_MouseDown);
            // 
            // Spieletraum_Loeschen
            // 
            this.Spieletraum_Loeschen.AutoSize = true;
            this.Spieletraum_Loeschen.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Spieletraum_Loeschen.ForeColor = System.Drawing.Color.White;
            this.Spieletraum_Loeschen.Location = new System.Drawing.Point(67, 4);
            this.Spieletraum_Loeschen.Name = "Spieletraum_Loeschen";
            this.Spieletraum_Loeschen.Size = new System.Drawing.Size(111, 29);
            this.Spieletraum_Loeschen.TabIndex = 1;
            this.Spieletraum_Loeschen.Text = "Löschen";
            this.Spieletraum_Loeschen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Loeschen_MouseDown);
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
            this.CloseLoeschen.Location = new System.Drawing.Point(479, 0);
            this.CloseLoeschen.Name = "CloseLoeschen";
            this.CloseLoeschen.Size = new System.Drawing.Size(49, 44);
            this.CloseLoeschen.TabIndex = 0;
            this.CloseLoeschen.UseVisualStyleBackColor = false;
            this.CloseLoeschen.Click += new System.EventHandler(this.CloseLoeschen_Click);
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(101, 104);
            this.textbox.Name = "textbox";
            this.textbox.PlaceholderText = "Geben Sie einen Index...";
            this.textbox.Size = new System.Drawing.Size(319, 23);
            this.textbox.TabIndex = 8;
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(204, 133);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(113, 23);
            this.button.TabIndex = 9;
            this.button.Text = "Löschen";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.Button_Click);
            // 
            // Loeschen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.button);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.panel_Loeschen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Loeschen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Löschen";
            this.Load += new System.EventHandler(this.Loeschen_Load);
            this.panel_Loeschen.ResumeLayout(false);
            this.panel_Loeschen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_Loeschen;
        private PictureBox PBLogo2;
        private Label Spieletraum_Loeschen;
        private Button CloseLoeschen;
        private TextBox textbox;
        private Button button;
    }
}