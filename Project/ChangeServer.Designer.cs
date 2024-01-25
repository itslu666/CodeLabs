namespace Project
{
    partial class ChangeServer
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
            servername_tb = new TextBox();
            databasename_tb = new TextBox();
            uid_tb = new TextBox();
            pwd_tb = new TextBox();
            connectServer_btn = new Button();
            SuspendLayout();
            // 
            // servername_tb
            // 
            servername_tb.Location = new Point(12, 12);
            servername_tb.Name = "servername_tb";
            servername_tb.PlaceholderText = "Neuer Servername";
            servername_tb.Size = new Size(301, 23);
            servername_tb.TabIndex = 0;
            // 
            // databasename_tb
            // 
            databasename_tb.Location = new Point(12, 41);
            databasename_tb.Name = "databasename_tb";
            databasename_tb.PlaceholderText = "Neuer Datenbankname";
            databasename_tb.Size = new Size(301, 23);
            databasename_tb.TabIndex = 1;
            // 
            // uid_tb
            // 
            uid_tb.Location = new Point(12, 70);
            uid_tb.Name = "uid_tb";
            uid_tb.PlaceholderText = "Benutzer Identifikation der neuen Datenbank";
            uid_tb.Size = new Size(301, 23);
            uid_tb.TabIndex = 2;
            // 
            // pwd_tb
            // 
            pwd_tb.Location = new Point(12, 99);
            pwd_tb.Name = "pwd_tb";
            pwd_tb.PlaceholderText = "Passwort der neuen Datenbank";
            pwd_tb.Size = new Size(301, 23);
            pwd_tb.TabIndex = 3;
            // 
            // connectServer_btn
            // 
            connectServer_btn.Location = new Point(116, 128);
            connectServer_btn.Name = "connectServer_btn";
            connectServer_btn.Size = new Size(75, 23);
            connectServer_btn.TabIndex = 4;
            connectServer_btn.Text = "Verbinden";
            connectServer_btn.UseVisualStyleBackColor = true;
            connectServer_btn.Click += button1_Click;
            // 
            // ChangeServer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 350);
            Controls.Add(connectServer_btn);
            Controls.Add(pwd_tb);
            Controls.Add(uid_tb);
            Controls.Add(databasename_tb);
            Controls.Add(servername_tb);
            Name = "ChangeServer";
            Text = "ChangeServer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox servername_tb;
        private TextBox databasename_tb;
        private TextBox uid_tb;
        private TextBox pwd_tb;
        private Button connectServer_btn;
    }
}