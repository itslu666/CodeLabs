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
    public partial class Ben_hin : Form
    {
        public Ben_hin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connector connector= new DB_Connector();
            connector.executeQuery($"INSERT INTO mitarbeiter VALUES ('{textBox1.Text}', '{textBox2.Text}', '{textBox3.Text}', '{textBox4.Text}', '{textBox5.Text}')");

            MessageBox.Show("Benutzer erfolgreich hinzugefügt.");
            this.Close();
        }
    }
}
