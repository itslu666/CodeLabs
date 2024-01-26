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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            UC_Home uc_Home = new UC_Home();
            addUserControl(uc_Home);

            LoginWindow lw = new();

            string user = lw.getCred();
            Username_LAbel.Text = $"{user}";
            
        }

        private void CloseMain_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void changeTheme(Color newcolor)
        {
            MessageBox.Show(panel1.BackColor.ToString());
            panel1.BackColor = newcolor;
            MessageBox.Show(panel1.BackColor.ToString());
        }



        private void Dashboard_MouseHover(object sender, EventArgs e)
        {
            Dashboard_Panel.BackColor = Color.MediumPurple;
        }

        private void Dashboard_Panel_MouseLeave(object sender, EventArgs e)
        {
            Dashboard_Panel.BackColor = Color.Transparent;
        }

        private void Import_Panel_MouseEnter(object sender, EventArgs e)
        {
            Import_Panel.BackColor = Color.MediumPurple;
        }

        private void Import_Panel_MouseLeave(object sender, EventArgs e)
        {
            Import_Panel.BackColor = Color.Transparent;
        }

        private void ChatBot_Panel_MouseEnter(object sender, EventArgs e)
        {
            ChatBot_Panel.BackColor = Color.MediumPurple;
        }

        private void ChatBot_Panel_MouseLeave(object sender, EventArgs e)
        {
            ChatBot_Panel.BackColor = Color.Transparent;
        }

        private void Settings_Panel_MouseEnter(object sender, EventArgs e)
        {
            Settings_Panel.BackColor = Color.MediumPurple;
        }

        private void Settings_Panel_MouseLeave(object sender, EventArgs e)
        {
            Settings_Panel.BackColor = Color.Transparent;
        }

        private void Logout_Panel_MouseEnter(object sender, EventArgs e)
        {
            Logout_Panel.BackColor = Color.DarkRed;
        }

        private void Logout_Panel_MouseLeave(object sender, EventArgs e)
        {
            Logout_Panel.BackColor = Color.Transparent;
        }
        private void panel3_MouseEnter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.MediumPurple;
        }

        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Transparent;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 43;

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

        private void panel2_MouseDown(object sender, MouseEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }


        // user control stuff
        private void addUserControl(UserControl userControl)
        {
            panel4.Controls.Clear();
            panel4.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            UC_Home uc_Home = new UC_Home();
            addUserControl(uc_Home);
        }

        private void Dashboard_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            UC_Tabelle uc_Tabelle = new UC_Tabelle();
            addUserControl(uc_Tabelle);
        }

        private void settings_MouseDown(object sender, MouseEventArgs e)
        {
            UC_Einstelungen uC_Einstelungen= new UC_Einstelungen();
            addUserControl(uC_Einstelungen);
        }

        private void Import_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            UC_Import uC_Import = new UC_Import();
            addUserControl(uC_Import);
        }

        private void ChatBot_Panel_Click(object sender, EventArgs e)
        {
            ChatbotForm cb = new ChatbotForm();
            cb.Show();  
        }

        private void Logout_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Close();
        }
    }
}
