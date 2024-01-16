using System;
using System.Windows.Forms;



namespace Project
{
    public partial class Form1 : Form
    {
        DB_Connector connector = new DB_Connector();

        public Form1()
        {
            InitializeComponent();
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
            List<string> loginData = connector.GetData("server=localhost;database=spieletraum;uid=root;pwd=;", "SELECT M_Nr, passwort FROM mitarbeiter");

            foreach (string item in loginData)
            {
                string employee = item;

                if (tbusername.Text == employee.Split(" ")[0] && tbpassword.Text == employee.Split(" ")[0])
                {
                    MainWindow mw = new MainWindow();
                    mw.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }
            
            if (tbpassword.Text == "")
            {
                MessageBox.Show("Invalid Password");
                tbpassword.Focus();
                return;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            
        }
    }
}