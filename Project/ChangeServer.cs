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
    public partial class ChangeServer : Form
    {
        public ChangeServer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (servername_tb.Text != "" && databasename_tb.Text != "" && uid_tb.Text != "" && uid_tb.Text != "" && pwd_tb.Text != "")
            {
                DB_Connector connector = new DB_Connector();
                connector.ChangeServer_Database(servername_tb.Text, databasename_tb.Text, uid_tb.Text, pwd_tb.Text);

                MessageBox.Show("Der Server wurde erfolgreich geändert.");
            } else
            {
                MessageBox.Show("Es müssen alle Felder ausgefüllt werden.\nVersuchen Sie es erneut.");
            }
        }
    }
}
