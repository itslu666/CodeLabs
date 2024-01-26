namespace Project
{
    partial class Bearbeiten
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bearbeiten));
            this.panel_Bearbeiten = new System.Windows.Forms.Panel();
            this.PBLogo2 = new System.Windows.Forms.PictureBox();
            this.Spieletraum_Bearbeiten = new System.Windows.Forms.Label();
            this.CloseBearbeiten = new System.Windows.Forms.Button();
            this.panel_Bearbeiten.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_Bearbeiten
            // 
            this.panel_Bearbeiten.BackColor = System.Drawing.Color.BlueViolet;
            this.panel_Bearbeiten.Controls.Add(this.PBLogo2);
            this.panel_Bearbeiten.Controls.Add(this.Spieletraum_Bearbeiten);
            this.panel_Bearbeiten.Controls.Add(this.CloseBearbeiten);
            this.panel_Bearbeiten.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Bearbeiten.Location = new System.Drawing.Point(0, 0);
            this.panel_Bearbeiten.Name = "panel_Bearbeiten";
            this.panel_Bearbeiten.Size = new System.Drawing.Size(527, 44);
            this.panel_Bearbeiten.TabIndex = 8;
            this.panel_Bearbeiten.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Bearbeiten_MouseDown);
            // 
            // PBLogo2
            // 
            this.PBLogo2.Image = global::Project.Properties.Resources.Create;
            this.PBLogo2.Location = new System.Drawing.Point(15, 4);
            this.PBLogo2.Name = "PBLogo2";
            this.PBLogo2.Size = new System.Drawing.Size(37, 33);
            this.PBLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo2.TabIndex = 8;
            this.PBLogo2.TabStop = false;
            this.PBLogo2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Bearbeiten_MouseDown);
            // 
            // Spieletraum_Bearbeiten
            // 
            this.Spieletraum_Bearbeiten.AutoSize = true;
            this.Spieletraum_Bearbeiten.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Spieletraum_Bearbeiten.ForeColor = System.Drawing.Color.White;
            this.Spieletraum_Bearbeiten.Location = new System.Drawing.Point(67, 4);
            this.Spieletraum_Bearbeiten.Name = "Spieletraum_Bearbeiten";
            this.Spieletraum_Bearbeiten.Size = new System.Drawing.Size(140, 29);
            this.Spieletraum_Bearbeiten.TabIndex = 1;
            this.Spieletraum_Bearbeiten.Text = "Bearbeiten";
            this.Spieletraum_Bearbeiten.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_Bearbeiten_MouseDown);
            // 
            // CloseBearbeiten
            // 
            this.CloseBearbeiten.BackColor = System.Drawing.Color.BlueViolet;
            this.CloseBearbeiten.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseBearbeiten.BackgroundImage")));
            this.CloseBearbeiten.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseBearbeiten.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseBearbeiten.FlatAppearance.BorderSize = 0;
            this.CloseBearbeiten.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseBearbeiten.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseBearbeiten.Location = new System.Drawing.Point(485, 1);
            this.CloseBearbeiten.Name = "CloseBearbeiten";
            this.CloseBearbeiten.Size = new System.Drawing.Size(49, 44);
            this.CloseBearbeiten.TabIndex = 0;
            this.CloseBearbeiten.UseVisualStyleBackColor = false;
            this.CloseBearbeiten.Click += new System.EventHandler(this.CloseBearbeiten_Click);
            // 
            // Bearbeiten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.panel_Bearbeiten);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Bearbeiten";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bearbeiten";
            this.Load += new System.EventHandler(this.Bearbeiten_Load);
            this.panel_Bearbeiten.ResumeLayout(false);
            this.panel_Bearbeiten.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Bearbeiten;
        private PictureBox PBLogo2;
        private Label Spieletraum_Bearbeiten;
        private Button CloseBearbeiten;
    }
}