namespace Project
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Mainpage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Dashboard_Panel = new System.Windows.Forms.Panel();
            this.Dashboard = new System.Windows.Forms.Label();
            this.PBDashboard = new System.Windows.Forms.PictureBox();
            this.Import_Panel = new System.Windows.Forms.Panel();
            this.PBImport = new System.Windows.Forms.PictureBox();
            this.Import = new System.Windows.Forms.Label();
            this.ChatBot_Panel = new System.Windows.Forms.Panel();
            this.PBChatBot = new System.Windows.Forms.PictureBox();
            this.ChatBot = new System.Windows.Forms.Label();
            this.PBLogo = new System.Windows.Forms.PictureBox();
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
            this.PBLogo2 = new System.Windows.Forms.PictureBox();
            this.Spieletraum_Mainwindow = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.PanelContainer = new System.Windows.Forms.Panel();
            this.Export_Button = new System.Windows.Forms.Button();
            this.Bearbeiten_Button = new System.Windows.Forms.Button();
            this.Loeschen_Button = new System.Windows.Forms.Button();
            this.Hinzufügen_Button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Kunden_Panel = new System.Windows.Forms.Panel();
            this.Kunden_Label = new System.Windows.Forms.Label();
            this.Lieferant_Panel = new System.Windows.Forms.Panel();
            this.Lieferant_Label = new System.Windows.Forms.Label();
            this.Artikel_Panel = new System.Windows.Forms.Panel();
            this.Artikel_Label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Dashboard_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDashboard)).BeginInit();
            this.Import_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImport)).BeginInit();
            this.ChatBot_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBChatBot)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.Settings_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSettings)).BeginInit();
            this.Logout_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogout)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).BeginInit();
            this.PanelContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Kunden_Panel.SuspendLayout();
            this.Lieferant_Panel.SuspendLayout();
            this.Artikel_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.Dashboard_Panel);
            this.panel1.Controls.Add(this.Import_Panel);
            this.panel1.Controls.Add(this.ChatBot_Panel);
            this.panel1.Controls.Add(this.PBLogo);
            this.panel1.Controls.Add(this.Settings_Panel);
            this.panel1.Controls.Add(this.Logout_Panel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 790);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.Mainpage);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Location = new System.Drawing.Point(0, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(218, 75);
            this.panel3.TabIndex = 10;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Mainpage
            // 
            this.Mainpage.AutoSize = true;
            this.Mainpage.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Mainpage.ForeColor = System.Drawing.Color.White;
            this.Mainpage.Location = new System.Drawing.Point(67, 26);
            this.Mainpage.Name = "Mainpage";
            this.Mainpage.Size = new System.Drawing.Size(72, 23);
            this.Mainpage.TabIndex = 0;
            this.Mainpage.Text = "Home";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 47);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.Dashboard_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_Panel_MouseDown);
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
            this.Dashboard.Size = new System.Drawing.Size(103, 23);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "Tabellen";
            this.Dashboard.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Dashboard_MouseDown);
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
            // PBLogo
            // 
            this.PBLogo.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo.Image")));
            this.PBLogo.Location = new System.Drawing.Point(51, 48);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(100, 96);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo.TabIndex = 7;
            this.PBLogo.TabStop = false;
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
            this.settings.Location = new System.Drawing.Point(53, 24);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(159, 23);
            this.settings.TabIndex = 0;
            this.settings.Text = "Einstellungen";
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
            this.panel2.Controls.Add(this.PBLogo2);
            this.panel2.Controls.Add(this.Spieletraum_Mainwindow);
            this.panel2.Controls.Add(this.CloseMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(218, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1349, 44);
            this.panel2.TabIndex = 5;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // PBLogo2
            // 
            this.PBLogo2.Image = ((System.Drawing.Image)(resources.GetObject("PBLogo2.Image")));
            this.PBLogo2.Location = new System.Drawing.Point(15, 4);
            this.PBLogo2.Name = "PBLogo2";
            this.PBLogo2.Size = new System.Drawing.Size(37, 33);
            this.PBLogo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBLogo2.TabIndex = 8;
            this.PBLogo2.TabStop = false;
            // 
            // Spieletraum_Mainwindow
            // 
            this.Spieletraum_Mainwindow.AutoSize = true;
            this.Spieletraum_Mainwindow.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Spieletraum_Mainwindow.ForeColor = System.Drawing.Color.White;
            this.Spieletraum_Mainwindow.Location = new System.Drawing.Point(67, 4);
            this.Spieletraum_Mainwindow.Name = "Spieletraum_Mainwindow";
            this.Spieletraum_Mainwindow.Size = new System.Drawing.Size(427, 29);
            this.Spieletraum_Mainwindow.TabIndex = 1;
            this.Spieletraum_Mainwindow.Text = "SpieleTraum Management Program";
            // 
            // PanelContainer
            // 
            this.PanelContainer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.PanelContainer.Controls.Add(this.Export_Button);
            this.PanelContainer.Controls.Add(this.Bearbeiten_Button);
            this.PanelContainer.Controls.Add(this.Loeschen_Button);
            this.PanelContainer.Controls.Add(this.Hinzufügen_Button);
            this.PanelContainer.Controls.Add(this.textBox1);
            this.PanelContainer.Controls.Add(this.pictureBox2);
            this.PanelContainer.Controls.Add(this.Kunden_Panel);
            this.PanelContainer.Controls.Add(this.Lieferant_Panel);
            this.PanelContainer.Controls.Add(this.Artikel_Panel);
            this.PanelContainer.Controls.Add(this.dataGridView1);
            this.PanelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContainer.Location = new System.Drawing.Point(218, 44);
            this.PanelContainer.Name = "PanelContainer";
            this.PanelContainer.Size = new System.Drawing.Size(1349, 746);
            this.PanelContainer.TabIndex = 6;
            // 
            // Export_Button
            // 
            this.Export_Button.BackColor = System.Drawing.Color.BlueViolet;
            this.Export_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Export_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Export_Button.ForeColor = System.Drawing.Color.White;
            this.Export_Button.Location = new System.Drawing.Point(592, 592);
            this.Export_Button.Name = "Export_Button";
            this.Export_Button.Size = new System.Drawing.Size(337, 65);
            this.Export_Button.TabIndex = 20;
            this.Export_Button.Text = "Export Tabelle";
            this.Export_Button.UseVisualStyleBackColor = false;
            // 
            // Bearbeiten_Button
            // 
            this.Bearbeiten_Button.BackColor = System.Drawing.Color.BlueViolet;
            this.Bearbeiten_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.Bearbeiten_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Bearbeiten_Button.ForeColor = System.Drawing.Color.White;
            this.Bearbeiten_Button.Location = new System.Drawing.Point(900, 35);
            this.Bearbeiten_Button.Name = "Bearbeiten_Button";
            this.Bearbeiten_Button.Size = new System.Drawing.Size(194, 65);
            this.Bearbeiten_Button.TabIndex = 19;
            this.Bearbeiten_Button.Text = "Bearbeiten";
            this.Bearbeiten_Button.UseVisualStyleBackColor = false;
            this.Bearbeiten_Button.Click += new System.EventHandler(this.Bearbeiten_Button_Click);
            // 
            // Loeschen_Button
            // 
            this.Loeschen_Button.BackColor = System.Drawing.Color.BlueViolet;
            this.Loeschen_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.Loeschen_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Loeschen_Button.ForeColor = System.Drawing.Color.White;
            this.Loeschen_Button.Location = new System.Drawing.Point(660, 35);
            this.Loeschen_Button.Name = "Loeschen_Button";
            this.Loeschen_Button.Size = new System.Drawing.Size(194, 65);
            this.Loeschen_Button.TabIndex = 18;
            this.Loeschen_Button.Text = "Löschen";
            this.Loeschen_Button.UseVisualStyleBackColor = false;
            this.Loeschen_Button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Loeschen_Button_MouseDown);
            // 
            // Hinzufügen_Button
            // 
            this.Hinzufügen_Button.BackColor = System.Drawing.Color.BlueViolet;
            this.Hinzufügen_Button.FlatAppearance.BorderSize = 5;
            this.Hinzufügen_Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumPurple;
            this.Hinzufügen_Button.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Hinzufügen_Button.ForeColor = System.Drawing.Color.White;
            this.Hinzufügen_Button.Location = new System.Drawing.Point(402, 35);
            this.Hinzufügen_Button.Name = "Hinzufügen_Button";
            this.Hinzufügen_Button.Size = new System.Drawing.Size(194, 65);
            this.Hinzufügen_Button.TabIndex = 17;
            this.Hinzufügen_Button.Text = "Hinzufügen";
            this.Hinzufügen_Button.UseVisualStyleBackColor = false;
            this.Hinzufügen_Button.Click += new System.EventHandler(this.Hinzufügen_Button_Click);
            this.Hinzufügen_Button.MouseEnter += new System.EventHandler(this.Hinzufügen_Button_MouseEnter);
            this.Hinzufügen_Button.MouseLeave += new System.EventHandler(this.Hinzufügen_Button_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(249, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Suchen...";
            this.textBox1.Size = new System.Drawing.Size(1051, 27);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.pictureBox2.Image = global::Project.Properties.Resources.Search;
            this.pictureBox2.Location = new System.Drawing.Point(1306, 129);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Kunden_Panel
            // 
            this.Kunden_Panel.BackColor = System.Drawing.Color.BlueViolet;
            this.Kunden_Panel.Controls.Add(this.Kunden_Label);
            this.Kunden_Panel.Location = new System.Drawing.Point(16, 448);
            this.Kunden_Panel.Name = "Kunden_Panel";
            this.Kunden_Panel.Size = new System.Drawing.Size(218, 75);
            this.Kunden_Panel.TabIndex = 13;
            this.Kunden_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kunden_Panel_MouseDown);
            this.Kunden_Panel.MouseEnter += new System.EventHandler(this.Kunden_Panel_MouseEnter);
            this.Kunden_Panel.MouseLeave += new System.EventHandler(this.Kunden_Panel_MouseLeave);
            // 
            // Kunden_Label
            // 
            this.Kunden_Label.AutoSize = true;
            this.Kunden_Label.BackColor = System.Drawing.Color.Transparent;
            this.Kunden_Label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Kunden_Label.ForeColor = System.Drawing.Color.White;
            this.Kunden_Label.Location = new System.Drawing.Point(66, 25);
            this.Kunden_Label.Name = "Kunden_Label";
            this.Kunden_Label.Size = new System.Drawing.Size(93, 23);
            this.Kunden_Label.TabIndex = 0;
            this.Kunden_Label.Text = "Kunden";
            this.Kunden_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Kunden_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Kunden_Label_MouseDown);
            // 
            // Lieferant_Panel
            // 
            this.Lieferant_Panel.BackColor = System.Drawing.Color.BlueViolet;
            this.Lieferant_Panel.Controls.Add(this.Lieferant_Label);
            this.Lieferant_Panel.Location = new System.Drawing.Point(16, 318);
            this.Lieferant_Panel.Name = "Lieferant_Panel";
            this.Lieferant_Panel.Size = new System.Drawing.Size(218, 75);
            this.Lieferant_Panel.TabIndex = 12;
            this.Lieferant_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lieferant_Panel_MouseDown);
            this.Lieferant_Panel.MouseEnter += new System.EventHandler(this.Lieferant_Panel_MouseEnter);
            this.Lieferant_Panel.MouseLeave += new System.EventHandler(this.Lieferant_Panel_MouseLeave);
            // 
            // Lieferant_Label
            // 
            this.Lieferant_Label.AutoSize = true;
            this.Lieferant_Label.BackColor = System.Drawing.Color.Transparent;
            this.Lieferant_Label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lieferant_Label.ForeColor = System.Drawing.Color.White;
            this.Lieferant_Label.Location = new System.Drawing.Point(57, 28);
            this.Lieferant_Label.Name = "Lieferant_Label";
            this.Lieferant_Label.Size = new System.Drawing.Size(108, 23);
            this.Lieferant_Label.TabIndex = 0;
            this.Lieferant_Label.Text = "Lieferant";
            this.Lieferant_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Lieferant_Label_MouseDown);
            // 
            // Artikel_Panel
            // 
            this.Artikel_Panel.BackColor = System.Drawing.Color.BlueViolet;
            this.Artikel_Panel.Controls.Add(this.Artikel_Label);
            this.Artikel_Panel.Location = new System.Drawing.Point(16, 189);
            this.Artikel_Panel.Name = "Artikel_Panel";
            this.Artikel_Panel.Size = new System.Drawing.Size(218, 79);
            this.Artikel_Panel.TabIndex = 11;
            this.Artikel_Panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Artikel_Panel_MouseDown);
            this.Artikel_Panel.MouseEnter += new System.EventHandler(this.Artikel_Panel_MouseHover);
            this.Artikel_Panel.MouseLeave += new System.EventHandler(this.Artikel_Panel_MouseLeave);
            // 
            // Artikel_Label
            // 
            this.Artikel_Label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Artikel_Label.AutoSize = true;
            this.Artikel_Label.BackColor = System.Drawing.Color.Transparent;
            this.Artikel_Label.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Artikel_Label.ForeColor = System.Drawing.Color.White;
            this.Artikel_Label.Location = new System.Drawing.Point(67, 26);
            this.Artikel_Label.Name = "Artikel_Label";
            this.Artikel_Label.Size = new System.Drawing.Size(83, 23);
            this.Artikel_Label.TabIndex = 0;
            this.Artikel_Label.Text = "Artikel";
            this.Artikel_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Artikel_Label_MouseDown);
            this.Artikel_Label.MouseEnter += new System.EventHandler(this.Artikel_Panel_MouseHover);
            this.Artikel_Label.MouseLeave += new System.EventHandler(this.Artikel_Panel_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(249, 162);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 400);
            this.dataGridView1.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1567, 790);
            this.Controls.Add(this.PanelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                    ";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Dashboard_Panel.ResumeLayout(false);
            this.Dashboard_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBDashboard)).EndInit();
            this.Import_Panel.ResumeLayout(false);
            this.Import_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBImport)).EndInit();
            this.ChatBot_Panel.ResumeLayout(false);
            this.ChatBot_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBChatBot)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.Settings_Panel.ResumeLayout(false);
            this.Settings_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBSettings)).EndInit();
            this.Logout_Panel.ResumeLayout(false);
            this.Logout_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo2)).EndInit();
            this.PanelContainer.ResumeLayout(false);
            this.PanelContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Kunden_Panel.ResumeLayout(false);
            this.Kunden_Panel.PerformLayout();
            this.Lieferant_Panel.ResumeLayout(false);
            this.Lieferant_Panel.PerformLayout();
            this.Artikel_Panel.ResumeLayout(false);
            this.Artikel_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private PictureBox PBLogo;
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
        private PictureBox PBLogo2;
        private Label Spieletraum_Mainwindow;
        private Panel panel3;
        private Label Mainpage;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private Panel PanelContainer;
        private DataGridView dataGridView1;
        private Panel Artikel_Panel;
        private Label Artikel_Label;
        private Panel Kunden_Panel;
        private Label Kunden_Label;
        private Panel Lieferant_Panel;
        private Label Lieferant_Label;
        private TextBox textBox1;
        private PictureBox pictureBox2;
        private Button Export_Button;
        private Button Bearbeiten_Button;
        private Button Loeschen_Button;
        private Button Hinzufügen_Button;
    }
}