using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Loeschen : Form
    {
        private DataGridView dataGridView;
        private string table;
        private string indexString;
        private string queryText;

        public Loeschen(DataGridView dataGridView1)
        {
            InitializeComponent();
            dataGridView = dataGridView1;
        }

        private int chooseIndex()
        {
            int indexin = 0;
            string chosenIndex = textbox.Text;

            try
            {
                indexin = Convert.ToInt32(chosenIndex);
            }
            catch
            {
                MessageBox.Show("Falsche eingabe, muss Zahl sein.");
            }
            return indexin;
        }

        private void Button_Click(object sender, EventArgs e)
        {
            deleteDataset();
        }

        private void deleteDataset()
        {
            DB_Connector connector = new DB_Connector();
            int index = chooseIndex();

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Name == "art_nr")
                {
                    table = "artikel";
                    indexString = "Art_Nr";
                } else if (column.Name == "k_nr")
                {
                    table = "kunden";
                    indexString = "K_NR";
                } else if (column.Name == "l_nr")
                {
                    table = "lieferant";
                    indexString = "L_Nr";
                }
            }

            queryText = $"DELETE FROM {table} WHERE {indexString} = {index};";

            connector.executeQuery(queryText);
        }



        private void CloseLoeschen_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Loeschen_Load(object sender, EventArgs e)
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

        private void panel_Loeschen_MouseDown(object sender, MouseEventArgs e)
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
    }
}
