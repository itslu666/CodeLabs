using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Pw_aendern : Form
    {
        public Pw_aendern()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
            {
                try
                {
                    DB_Connector connector = new DB_Connector();
                    connector.executeQuery($"UPDATE mitarbeiter SET passwort = '{textBox3.Text}' WHERE M_Nr = '{textBox1.Text}' AND passwort = '{textBox2.Text}'");
                    
                    MessageBox.Show("Passwort erfolgreich geändert.");
                    this.Close();
                } catch
                {
                    MessageBox.Show("Falscher Benutzername oder ursprüngliches Passwort.\nVersuchen Sie es erneut.");
                }

            } else
            {
                MessageBox.Show("Sie müssen alle felder angeben.");
            }
        }
    }
}
