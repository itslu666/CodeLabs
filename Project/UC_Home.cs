﻿using System;
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
    public partial class UC_Home : UserControl
    {
        public UC_Home()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Tabelle_Button_MouseEnter(object sender, EventArgs e)
        {
            Tabelle_Button.BackColor = Color.MediumOrchid;
        }

        private void Tabelle_Button_MouseLeave(object sender, EventArgs e)
        {
            Tabelle_Button.BackColor = Color.MediumPurple;
        }
    }
}
