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
        List<Artikel> artikelList = new List<Artikel>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseMain_Click(object sender, EventArgs e)
        { 
            Close();
        }

        private void Dashboard_Panel_Paint(object sender, PaintEventArgs e)
        {
            ShowArtikelTable();
        }

        private void ShowArtikelTable()
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("id", "ID");
                dataGridView1.Columns.Add("name", "Name");
                dataGridView1.Columns.Add("description", "Beschreibung");
                dataGridView1.Columns.Add("price", "Verkaufs Preis");
                dataGridView1.Columns.Add("wg_id", "Warengruppe ID");
            }

            List<Artikel> artList = getArtikel();

            foreach (Artikel art in artList)
            {
                dataGridView1.Rows.Add(art.Id.ToString(), art.Bezeichnung.ToString(), art.Description.ToString(), art.Price.ToString(), art.Wg_nr.ToString());
            }
        }


        private List<Artikel> getArtikel()
        {
            DB_Connector connector = new DB_Connector();

            List<string> data = connector.GetData("server=localhost;database=spieletraum;uid=root;pwd=;", "SELECT * FROM Artikel");

            foreach (string s in data)
            {
                Artikel artikel = new Artikel();

                artikel.Id = Convert.ToInt32(s[0]);
                artikel.Bezeichnung = Convert.ToString(s[1]);
                artikel.Description = Convert.ToString(s[2]);
                artikel.Price = Convert.ToString(s[3]);
                artikel.Wg_nr = int.TryParse(Convert.ToString(s[4]), out int id) ? id : 0;

                artikelList.Add(artikel);
            }

            return artikelList;
        }







        // hover events for panels
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
            Logout_Panel.BackColor = Color.MediumPurple;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 40;

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
    }
}
