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
    public partial class Bearbeiten : Form
    {
        private int index;
        private string chosenIndex;
        private TextBox textbox = new TextBox();
        DataGridView dataGridView;
        List<TextBox> textbox_list = new List<TextBox>();
        Button button = new Button();
        string table;
        string indexString;

        public Bearbeiten(DataGridView dataGridView1)
        {
            InitializeComponent();

            dataGridView = dataGridView1;
            textbox.PlaceholderText = "Geben Sie einen Index ein...";
            textbox.Location = new System.Drawing.Point(101, 104);
            textbox.AutoSize = false;
            this.Controls.Add(textbox);

            button.Text = "Bearbeiten";
            button.Location = new System.Drawing.Point(204, 133);
            button.AutoSize = false;
            button.Click += Button_Click;
            this.Controls.Add(button);
        }

        private void CloseBearbeiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int y = 50;

            // hide first
            textbox.Visible = false;
            button.Visible = false;

            DB_Connector connector = new DB_Connector();
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

            Button bearbButton = new Button();
            bearbButton.Text = "Senden";
            bearbButton.Location = new System.Drawing.Point(204, 400);
            bearbButton.AutoSize = false;
            bearbButton.Click += edit;
            this.Controls.Add(bearbButton);
        }

        private void edit(object sender, EventArgs e)
        {
            chosenIndex = textbox.Text;
            index = Convert.ToInt32(chosenIndex);

            DB_Connector connector = new DB_Connector();
            StringBuilder queryText = new StringBuilder();

            string table = string.Empty;
            string indexString = string.Empty;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.Name == "art_nr")
                {
                    table = "artikel";
                    indexString = "Art_Nr";
                }
                else if (column.Name == "k_nr")
                {
                    table = "kunden";
                    indexString = "K_NR";
                }
                else if (column.Name == "l_nr")
                {
                    table = "lieferant";
                    indexString = "L_Nr";
                }
            }

            queryText.Append($"UPDATE {table} SET ");

            foreach (TextBox textBox in textbox_list)
            {
                queryText.Append($"{textBox.Name.Substring(8)} = '{textBox.Text}', ");
            }
            queryText.Length -= 2;

            queryText.Append($"WHERE {indexString} = {index}");

            connector.executeQuery(queryText.ToString());
        }






        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern bool ReleaseCapture();


        private void panel_Bearbeiten_MouseDown(object sender, MouseEventArgs e)
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

        private void Bearbeiten_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int radius = 40;

            path.AddArc(0, 0, radius, radius, 180, 90); //Top-left corner
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90); //Top-right corner
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90); //Bottom,-right corner
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90); //Bottom-left corner

            this.Region = new Region(path); //Create a region with the rounded rectangle path and apply it to the form 
        }
    }
}
