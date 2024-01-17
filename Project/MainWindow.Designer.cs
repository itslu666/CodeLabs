﻿namespace Project
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Dashboard_Panel = new System.Windows.Forms.Panel();
            this.Dashboard = new System.Windows.Forms.Label();
            this.PBDashboard = new System.Windows.Forms.PictureBox();
            this.Import_Panel = new System.Windows.Forms.Panel();
            this.PBImport = new System.Windows.Forms.PictureBox();
            this.Import = new System.Windows.Forms.Label();
            this.ChatBot_Panel = new System.Windows.Forms.Panel();
            this.PBChatBot = new System.Windows.Forms.PictureBox();
            this.ChatBot = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Settings_Panel = new System.Windows.Forms.Panel();
            this.PBSettings = new System.Windows.Forms.PictureBox();
            this.settings = new System.Windows.Forms.Label();
            this.Logout_Panel = new System.Windows.Forms.Panel();
            this.PBLogout = new System.Windows.Forms.PictureBox();
            this.Logout = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CloseMain = new System.Windows.Forms.Button();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Dashboard_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDashboard)).BeginInit();
            this.Import_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImport)).BeginInit();
            this.ChatBot_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBChatBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Settings_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSettings)).BeginInit();
            this.Logout_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogout)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.Dashboard_Panel);
            this.panel1.Controls.Add(this.Import_Panel);
            this.panel1.Controls.Add(this.ChatBot_Panel);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Settings_Panel);
            this.panel1.Controls.Add(this.Logout_Panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 790);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // Dashboard_Panel
            // 
            this.Dashboard_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Dashboard_Panel.Controls.Add(this.Dashboard);
            this.Dashboard_Panel.Controls.Add(this.PBDashboard);
            this.Dashboard_Panel.Location = new System.Drawing.Point(0, 261);
            this.Dashboard_Panel.Name = "Dashboard_Panel";
            this.Dashboard_Panel.Size = new System.Drawing.Size(218, 75);
            this.Dashboard_Panel.TabIndex = 6;
            this.Dashboard_Panel.MouseEnter += new System.EventHandler(this.Dashboard_MouseHover);
            this.Dashboard_Panel.MouseLeave += new System.EventHandler(this.Dashboard_Panel_MouseLeave);
            // 
            // Dashboard
            // 
            this.Dashboard.AutoSize = true;
            this.Dashboard.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Dashboard.ForeColor = System.Drawing.Color.White;
            this.Dashboard.Location = new System.Drawing.Point(58, 25);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(125, 23);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Dashboard";
            this.Dashboard.MouseEnter += new System.EventHandler(this.Dashboard_MouseHover);
            this.Dashboard.MouseLeave += new System.EventHandler(this.Dashboard_Panel_MouseLeave);
            // 
            // PBDashboard
            // 
            this.PBDashboard.Image = ((System.Drawing.Image)(resources.GetObject("PBDashboard.Image")));
            this.PBDashboard.Location = new System.Drawing.Point(3, 14);
            this.PBDashboard.Name = "PBDashboard";
            this.PBDashboard.Size = new System.Drawing.Size(49, 47);
            this.PBDashboard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBDashboard.TabIndex = 1;
            this.PBDashboard.TabStop = false;
            this.PBDashboard.MouseEnter += new System.EventHandler(this.Dashboard_MouseHover);
            this.PBDashboard.MouseLeave += new System.EventHandler(this.Dashboard_Panel_MouseLeave);
            // 
            // Import_Panel
            // 
            this.Import_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Import_Panel.Controls.Add(this.PBImport);
            this.Import_Panel.Controls.Add(this.Import);
            this.Import_Panel.Location = new System.Drawing.Point(0, 342);
            this.Import_Panel.Name = "Import_Panel";
            this.Import_Panel.Size = new System.Drawing.Size(218, 75);
            this.Import_Panel.TabIndex = 9;
            this.Import_Panel.MouseEnter += new System.EventHandler(this.Import_Panel_MouseEnter);
            this.Import_Panel.MouseLeave += new System.EventHandler(this.Import_Panel_MouseLeave);
            // 
            // PBImport
            // 
            this.PBImport.Image = ((System.Drawing.Image)(resources.GetObject("PBImport.Image")));
            this.PBImport.Location = new System.Drawing.Point(3, 14);
            this.PBImport.Name = "PBImport";
            this.PBImport.Size = new System.Drawing.Size(49, 47);
            this.PBImport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBImport.TabIndex = 1;
            this.PBImport.TabStop = false;
            this.PBImport.MouseEnter += new System.EventHandler(this.Import_Panel_MouseEnter);
            this.PBImport.MouseLeave += new System.EventHandler(this.Import_Panel_MouseLeave);
            // 
            // Import
            // 
            this.Import.AutoSize = true;
            this.Import.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Import.ForeColor = System.Drawing.Color.White;
            this.Import.Location = new System.Drawing.Point(67, 25);
            this.Import.Name = "Import";
            this.Import.Size = new System.Drawing.Size(84, 23);
            this.Import.TabIndex = 0;
            this.Import.Text = "Import";
            this.Import.MouseEnter += new System.EventHandler(this.Import_Panel_MouseEnter);
            this.Import.MouseLeave += new System.EventHandler(this.Import_Panel_MouseLeave);
            // 
            // ChatBot_Panel
            // 
            this.ChatBot_Panel.BackColor = System.Drawing.Color.Transparent;
            this.ChatBot_Panel.Controls.Add(this.PBChatBot);
            this.ChatBot_Panel.Controls.Add(this.ChatBot);
            this.ChatBot_Panel.Location = new System.Drawing.Point(0, 423);
            this.ChatBot_Panel.Name = "ChatBot_Panel";
            this.ChatBot_Panel.Size = new System.Drawing.Size(218, 75);
            this.ChatBot_Panel.TabIndex = 8;
            this.ChatBot_Panel.MouseEnter += new System.EventHandler(this.ChatBot_Panel_MouseEnter);
            this.ChatBot_Panel.MouseLeave += new System.EventHandler(this.ChatBot_Panel_MouseLeave);
            // 
            // PBChatBot
            // 
            this.PBChatBot.Image = ((System.Drawing.Image)(resources.GetObject("PBChatBot.Image")));
            this.PBChatBot.Location = new System.Drawing.Point(3, 14);
            this.PBChatBot.Name = "PBChatBot";
            this.PBChatBot.Size = new System.Drawing.Size(49, 47);
            this.PBChatBot.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBChatBot.TabIndex = 1;
            this.PBChatBot.TabStop = false;
            this.PBChatBot.MouseEnter += new System.EventHandler(this.ChatBot_Panel_MouseEnter);
            this.PBChatBot.MouseLeave += new System.EventHandler(this.ChatBot_Panel_MouseLeave);
            // 
            // ChatBot
            // 
            this.ChatBot.AutoSize = true;
            this.ChatBot.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ChatBot.ForeColor = System.Drawing.Color.White;
            this.ChatBot.Location = new System.Drawing.Point(67, 25);
            this.ChatBot.Name = "ChatBot";
            this.ChatBot.Size = new System.Drawing.Size(96, 23);
            this.ChatBot.TabIndex = 0;
            this.ChatBot.Text = "ChatBot";
            this.ChatBot.MouseEnter += new System.EventHandler(this.ChatBot_Panel_MouseEnter);
            this.ChatBot.MouseLeave += new System.EventHandler(this.ChatBot_Panel_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // Settings_Panel
            // 
            this.Settings_Panel.BackColor = System.Drawing.Color.Transparent;
            this.Settings_Panel.Controls.Add(this.PBSettings);
            this.Settings_Panel.Controls.Add(this.settings);
            this.Settings_Panel.Location = new System.Drawing.Point(0, 504);
            this.Settings_Panel.Name = "Settings_Panel";
            this.Settings_Panel.Size = new System.Drawing.Size(218, 75);
            this.Settings_Panel.TabIndex = 5;
            this.Settings_Panel.MouseEnter += new System.EventHandler(this.Settings_Panel_MouseEnter);
            this.Settings_Panel.MouseLeave += new System.EventHandler(this.Settings_Panel_MouseLeave);
            // 
            // PBSettings
            // 
            this.PBSettings.Image = ((System.Drawing.Image)(resources.GetObject("PBSettings.Image")));
            this.PBSettings.Location = new System.Drawing.Point(3, 15);
            this.PBSettings.Name = "PBSettings";
            this.PBSettings.Size = new System.Drawing.Size(49, 47);
            this.PBSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBSettings.TabIndex = 1;
            this.PBSettings.TabStop = false;
            this.PBSettings.MouseEnter += new System.EventHandler(this.Settings_Panel_MouseEnter);
            this.PBSettings.MouseLeave += new System.EventHandler(this.Settings_Panel_MouseLeave);
            // 
            // settings
            // 
            this.settings.AutoSize = true;
            this.settings.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.settings.ForeColor = System.Drawing.Color.White;
            this.settings.Location = new System.Drawing.Point(61, 25);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(100, 23);
            this.settings.TabIndex = 0;
            this.settings.Text = "Settings";
            this.settings.MouseEnter += new System.EventHandler(this.Settings_Panel_MouseEnter);
            this.settings.MouseLeave += new System.EventHandler(this.Settings_Panel_MouseLeave);
            // 
            // Logout_Panel
            // 
            this.Logout_Panel.BackColor = System.Drawing.Color.MediumPurple;
            this.Logout_Panel.Controls.Add(this.PBLogout);
            this.Logout_Panel.Controls.Add(this.Logout);
            this.Logout_Panel.Location = new System.Drawing.Point(0, 724);
            this.Logout_Panel.Name = "Logout_Panel";
            this.Logout_Panel.Size = new System.Drawing.Size(218, 66);
            this.Logout_Panel.TabIndex = 4;
            this.Logout_Panel.MouseEnter += new System.EventHandler(this.Logout_Panel_MouseEnter);
            this.Logout_Panel.MouseLeave += new System.EventHandler(this.Logout_Panel_MouseLeave);
            // 
            // PBLogout
            // 
            this.PBLogout.Image = ((System.Drawing.Image)(resources.GetObject("PBLogout.Image")));
            this.PBLogout.Location = new System.Drawing.Point(12, 16);
            this.PBLogout.Name = "PBLogout";
            this.PBLogout.Size = new System.Drawing.Size(40, 47);
            this.PBLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogout.TabIndex = 1;
            this.PBLogout.TabStop = false;
            this.PBLogout.MouseEnter += new System.EventHandler(this.Logout_Panel_MouseEnter);
            this.PBLogout.MouseLeave += new System.EventHandler(this.Logout_Panel_MouseLeave);
            // 
            // Logout
            // 
            this.Logout.AutoSize = true;
            this.Logout.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Logout.ForeColor = System.Drawing.Color.White;
            this.Logout.Location = new System.Drawing.Point(67, 25);
            this.Logout.Name = "Logout";
            this.Logout.Size = new System.Drawing.Size(84, 23);
            this.Logout.TabIndex = 0;
            this.Logout.Text = "Logout";
            this.Logout.MouseEnter += new System.EventHandler(this.Logout_Panel_MouseEnter);
            this.Logout.MouseLeave += new System.EventHandler(this.Logout_Panel_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(483, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "SpielTraum";
            // 
            // CloseMain
            // 
            this.CloseMain.BackColor = System.Drawing.Color.BlueViolet;
            this.CloseMain.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CloseMain.BackgroundImage")));
            this.CloseMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CloseMain.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CloseMain.FlatAppearance.BorderSize = 0;
            this.CloseMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CloseMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseMain.Location = new System.Drawing.Point(1300, 0);
            this.CloseMain.Name = "CloseMain";
            this.CloseMain.Size = new System.Drawing.Size(49, 44);
            this.CloseMain.TabIndex = 0;
            this.CloseMain.UseVisualStyleBackColor = false;
            this.CloseMain.Click += new System.EventHandler(this.CloseMain_Click);
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.BlueViolet;
            this.panel2.Controls.Add(this.CloseMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1349, 44);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1567, 790);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                    ";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.Dashboard_Panel.ResumeLayout(false);
            this.Dashboard_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDashboard)).EndInit();
            this.Import_Panel.ResumeLayout(false);
            this.Import_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImport)).EndInit();
            this.ChatBot_Panel.ResumeLayout(false);
            this.ChatBot_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBChatBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Settings_Panel.ResumeLayout(false);
            this.Settings_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSettings)).EndInit();
            this.Logout_Panel.ResumeLayout(false);
            this.Logout_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel Logout_Panel;
        private Label Logout;
        private PictureBox PBLogout;
        private Panel Settings_Panel;
        private PictureBox PBSettings;
        private Label settings;
        private PictureBox pictureBox2;
        private Panel Dashboard_Panel;
        private PictureBox PBDashboard;
        private Panel ChatBot_Panel;
        private PictureBox PBChatBot;
        private Label ChatBot;
        private Panel Import_Panel;
        private PictureBox PBImport;
        private Label Import;
        private Button CloseMain;
        private Label Dashboard;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private Panel panel2;
    }
}