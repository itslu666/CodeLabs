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
    public partial class Benutzer_E : Form
    {
        public Benutzer_E()
        {
            InitializeComponent();
        }

        private void Benutzer_E_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 35;

            path.AddArc(0, 0, radius, radius, 180, 90); //Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); //Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); //Bottom,-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); //Bottom-left corner
            this.Region = new Region(path); //Create a region with the rounded rectangle path and apply it to the form
        }
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void panel_PW_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //Check if the click was on the title bar
                if (e.Clicks == 1 && e.Y <= this.Height && e.Y >= 0)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
            }
        }

        private void CloseHinzufuegen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BenutzerHIN_button_Click(object sender, EventArgs e)
        {
            Ben_hin bh = new Ben_hin();
            bh.ShowDialog();
        }

        private void BenutzerBEA_button_Click(object sender, EventArgs e)
        {
            Ben_bear be = new Ben_bear();
            be.ShowDialog();
        }

        private void BenutzerENT_button_Click(object sender, EventArgs e)
        {
            Ben_ent be = new Ben_ent();
            be.ShowDialog();
        }
    }
}
