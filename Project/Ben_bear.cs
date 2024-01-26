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
    public partial class Ben_bear : Form
    {
        public Ben_bear()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connector connector= new DB_Connector();
            connector.executeQuery($"UPDATE mitarbeiter SET M_Nr = '{nummer.Text}', anrede = '{anrede.Text}', name = '{name.Text}', vorname = '{vorname.Text}', passwort = '{pw.Text}' WHERE M_Nr = '{benutzernummer.Text}'");
            MessageBox.Show("Benutzer erfolgreich bearbeitet.");
            this.Close();
        }
    }
}
