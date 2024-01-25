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
    }
}
