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
    public partial class UC_Einstelungen : UserControl
    {
        public UC_Einstelungen()
        {
            InitializeComponent();
        }

        private void PW_Button_Click(object sender, EventArgs e)
        {
            Pw_aendern pw = new Pw_aendern();
            pw.ShowDialog();
        }

        private void Server_Button_Click(object sender, EventArgs e)
        {
            ChangeServer cs = new ChangeServer();
            cs.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Themes t = new Themes();
            t.Show();
        }

        private void BEnutzer_Button_Click(object sender, EventArgs e)
        {
            Check_Admin ca = new Check_Admin();
            ca.ShowDialog();
        }

        private void PW_Button_Click_1(object sender, EventArgs e)
        {
            Pw_aendern pw = new Pw_aendern();
            pw.ShowDialog();
        }
    }
}
