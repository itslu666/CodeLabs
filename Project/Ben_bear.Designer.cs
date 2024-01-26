namespace Project
{
    partial class Ben_bear
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
            this.nummer = new System.Windows.Forms.TextBox();
            this.anrede = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.vorname = new System.Windows.Forms.TextBox();
            this.pw = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.benutzernummer = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nummer
            // 
            this.nummer.Location = new System.Drawing.Point(75, 147);
            this.nummer.Name = "nummer";
            this.nummer.PlaceholderText = "Neue Nummer";
            this.nummer.Size = new System.Drawing.Size(200, 23);
            this.nummer.TabIndex = 0;
            // 
            // anrede
            // 
            this.anrede.Location = new System.Drawing.Point(75, 176);
            this.anrede.Name = "anrede";
            this.anrede.PlaceholderText = "Neue Anrede";
            this.anrede.Size = new System.Drawing.Size(200, 23);
            this.anrede.TabIndex = 1;
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(75, 205);
            this.name.Name = "name";
            this.name.PlaceholderText = "Neuer Name";
            this.name.Size = new System.Drawing.Size(200, 23);
            this.name.TabIndex = 2;
            // 
            // vorname
            // 
            this.vorname.Location = new System.Drawing.Point(75, 234);
            this.vorname.Name = "vorname";
            this.vorname.PlaceholderText = "Neuer Vorname";
            this.vorname.Size = new System.Drawing.Size(200, 23);
            this.vorname.TabIndex = 3;
            // 
            // pw
            // 
            this.pw.Location = new System.Drawing.Point(75, 263);
            this.pw.Name = "pw";
            this.pw.PlaceholderText = "Neues Passwort";
            this.pw.Size = new System.Drawing.Size(200, 23);
            this.pw.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 292);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Bearbeiten";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // benutzernummer
            // 
            this.benutzernummer.Location = new System.Drawing.Point(75, 30);
            this.benutzernummer.Name = "benutzernummer";
            this.benutzernummer.PlaceholderText = "Benutzer Nummer";
            this.benutzernummer.Size = new System.Drawing.Size(200, 23);
            this.benutzernummer.TabIndex = 6;
            // 
            // Ben_bear
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 345);
            this.Controls.Add(this.benutzernummer);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pw);
            this.Controls.Add(this.vorname);
            this.Controls.Add(this.name);
            this.Controls.Add(this.anrede);
            this.Controls.Add(this.nummer);
            this.Name = "Ben_bear";
            this.Text = "Ben_bear";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox nummer;
        private TextBox anrede;
        private TextBox name;
        private TextBox vorname;
        private TextBox pw;
        private Button button1;
        private TextBox benutzernummer;
    }
}