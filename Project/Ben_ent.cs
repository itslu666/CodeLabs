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
    public partial class Ben_ent : Form
    {
        public Ben_ent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DB_Connector connector = new DB_Connector();
            connector.executeQuery($"DELETE FROM mitarbeiter WHERE M_Nr = '{textBox1.Text}'");
            MessageBox.Show("Mitarbeiter erfolgreich entfernt.");
            this.Close();
        }
    }
}
