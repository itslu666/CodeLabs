namespace Project
{
    partial class ChatbotForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatbotForm));
            this.panel_ChatBot = new System.Windows.Forms.Panel();
            this.PBChatBot = new System.Windows.Forms.PictureBox();
            this.ChatBot_Fenster = new System.Windows.Forms.Label();
            this.CloseBearbeiten = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel_ChatBot.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBChatBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ChatBot
            // 
            this.panel_ChatBot.BackColor = System.Drawing.Color.BlueViolet;
            this.panel_ChatBot.Controls.Add(this.PBChatBot);
            this.panel_ChatBot.Controls.Add(this.ChatBot_Fenster);
            this.panel_ChatBot.Controls.Add(this.CloseBearbeiten);
            this.panel_ChatBot.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ChatBot.Location = new System.Drawing.Point(0, 0);
            this.panel_ChatBot.Name = "panel_ChatBot";
            this.panel_ChatBot.Size = new System.Drawing.Size(342, 44);
            this.panel_ChatBot.TabIndex = 9;
            this.panel_ChatBot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_ChatBot_MouseDown);
            // 
            // PBChatBot
            // 
            this.PBChatBot.Image = global::Project.Properties.Resources.Bot1;
            this.PBChatBot.Location = new System.Drawing.Point(15, 4);
            this.PBChatBot.Name = "PBChatBot";
            this.PBChatBot.Size = new System.Drawing.Size(37, 33);
            this.PBChatBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBChatBot.TabIndex = 8;
            this.PBChatBot.TabStop = false;
            this.PBChatBot.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_ChatBot_MouseDown);
            // 
            // ChatBot_Fenster
            // 
            this.ChatBot_Fenster.AutoSize = true;
            this.ChatBot_Fenster.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChatBot_Fenster.ForeColor = System.Drawing.Color.White;
            this.ChatBot_Fenster.Location = new System.Drawing.Point(67, 4);
            this.ChatBot_Fenster.Name = "ChatBot_Fenster";
            this.ChatBot_Fenster.Size = new System.Drawing.Size(108, 29);
            this.ChatBot_Fenster.TabIndex = 1;
            this.ChatBot_Fenster.Text = "ChatBot";
            this.ChatBot_Fenster.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_ChatBot_MouseDown);
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
            this.CloseBearbeiten.Location = new System.Drawing.Point(293, 0);
            this.CloseBearbeiten.Name = "CloseBearbeiten";
            this.CloseBearbeiten.Size = new System.Drawing.Size(49, 44);
            this.CloseBearbeiten.TabIndex = 0;
            this.CloseBearbeiten.UseVisualStyleBackColor = false;
            this.CloseBearbeiten.Click += new System.EventHandler(this.CloseBearbeiten_Click);
            this.CloseBearbeiten.MouseEnter += new System.EventHandler(this.CloseBearbeiten_MouseEnter);
            this.CloseBearbeiten.MouseLeave += new System.EventHandler(this.CloseBearbeiten_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.sentweiß;
            this.pictureBox1.Location = new System.Drawing.Point(305, 420);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 420);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(282, 23);
            this.textBox1.TabIndex = 11;
            // 
            // ChatbotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(342, 456);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel_ChatBot);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ChatbotForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChatbotForm";
            this.Load += new System.EventHandler(this.ChatbotForm_Load);
            this.panel_ChatBot.ResumeLayout(false);
            this.panel_ChatBot.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBChatBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_ChatBot;
        private PictureBox PBChatBot;
        private Label ChatBot_Fenster;
        private Button CloseBearbeiten;
        private PictureBox pictureBox1;
        private TextBox textBox1;
    }
}