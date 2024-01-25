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
    public partial class Hinzufuegen : Form
    {
        private DataGridView dataGridView;
        List<TextBox> textbox_list = new List<TextBox>();
        private string table;

        public Hinzufuegen(DataGridView dataGridView1)
        {
            InitializeComponent();
            dataGridView = dataGridView1;
            ShowLabels();
        }

        public void ShowLabels()
        {
            int y = 50;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                // making labels
                Label label = new Label();
                label.Text = column.Name;
                label.Font = new Font("Segoe UI", 15, FontStyle.Bold);
                label.ForeColor = Color.White;
                label.Location = new System.Drawing.Point(20, y);
                label.AutoSize = false;
                label.Height = 30;
                this.Controls.Add(label);

                // making textboxes
                TextBox textbox = new TextBox();
                textbox.Name = "textbox_" + column.Name;
                textbox.Font = new Font("Segoe UI", 15);
                textbox.Location = new System.Drawing.Point(150, y);
                textbox.AutoSize = false;
                textbox.Size = new Size(350, 30);
                this.Controls.Add(textbox);

                textbox_list.Add(textbox);

                y += 32;
            }
        }

        private void HinzufügenWindow_Button_Click(object sender, EventArgs e)
        {
            DB_Connector connector = new DB_Connector();
            StringBuilder queryText = new StringBuilder();
            int current_index = 0;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Name == "art_nr")
                {
                    table = "artikel";
                }
                else if (column.Name == "k_nr")
                {
                    table = "kunden";
                }
                else if (column.Name == "l_nr")
                {
                    table = "lieferant";
                }
            }

            queryText.Append($"INSERT INTO {table} VALUES (");
            foreach (TextBox textbox in textbox_list)
            {
                current_index++;
                queryText.Append($"'{textbox.Text}'");
                if (current_index < textbox_list.Count)
                {
                    queryText.Append(", ");
                }
            }

            queryText.Append(");");

            MessageBox.Show(queryText.ToString());
            connector.executeQuery("server=localhost;database=spieletraum;uid=root;pwd=;", queryText.ToString());

            this.Close();
        }

        private void Hinzufuegen_Load(object sender, EventArgs e)
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

        private void panel_Hinzufuegen_MouseDown(object sender, MouseEventArgs e)
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
    }
}
