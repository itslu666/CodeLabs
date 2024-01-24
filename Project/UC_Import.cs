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
    public partial class UC_Import : UserControl
    {
        public UC_Import()
        {
            InitializeComponent();
        }

        private void Speichern_Button_MouseEnter(object sender, EventArgs e)
        {
            Speichern_Button.BackColor = Color.DarkBlue;
        }

        private void Speichern_Button_MouseLeave(object sender, EventArgs e)
        {
            Speichern_Button.BackColor = Color.BlueViolet;
        }

        private void Löschen_Button_MouseEnter(object sender, EventArgs e)
        {
            Löschen_Button.BackColor = Color.DarkRed;
        }

        private void Löschen_Button_MouseLeave(object sender, EventArgs e)
        {
            Löschen_Button.BackColor = Color.BlueViolet;
        }
    }
}
