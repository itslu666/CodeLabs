using System;
using System.Windows.Forms;



namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            DB_Connector connector = new DB_Connector();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        // BEI CHATGPT NACH FRAGEN!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        //MOVE THE LOGIN WINDOW
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private void Form1_Load(object sender, EventArgs e)
        {


            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 40;

            path.AddArc(0, 0, radius, radius, 180, 90); //Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); //Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); //Bottom,-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); //Bottom-left corner

            this.Region = new Region(path); //Create a region with the rounded rectangle path and apply it to the form 


        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if(tbusername.Text == "" && tbpassword.Text == "")
            {
                MessageBox.Show("Invalid Username or Password");

            }
            else
            {
                //PJ du opfer
            }

            if(tbusername.Text == "")
            {
                MessageBox.Show("Invalid Username");
                tbusername.Focus();
                return;
            }
            
            if (tbpassword.Text == "")
            {
                MessageBox.Show("Invalid Password");
                tbpassword.Focus();
                return;
            }
        }
    }
}