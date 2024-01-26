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
    public partial class Check_Admin : Form
    {
        public Check_Admin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adminLogin();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adminLogin();
            }
        }

        private void adminLogin()
        {
            DB_Connector connector = new DB_Connector();
            var data = connector.GetData("SELECT M_Nr, passwort FROM mitarbeiter WHERE M_Nr = 'user' AND passwort = 'user'");

            foreach (var credentials in data)
            {
                // show employees for debug
                // MessageBox.Show(employee);

                // split username and password

                // check if username and pw
                if (textBox1.Text == credentials[0] && textBox2.Text == credentials[1])
                {
                    Benutzer_E eins = new Benutzer_E();
                    eins.ShowDialog();

                    this.Close();
                }
            }
        }

    }
}
