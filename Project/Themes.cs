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
    public partial class Themes : Form
    {
        public Themes()
        {
            InitializeComponent();
        }

        private void Graumodus_Button_Click(object sender, EventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.changeTheme(Color.White);
            mw.Close();
        }
    }
}
