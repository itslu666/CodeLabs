using DocumentFormat.OpenXml.Wordprocessing;
using Spire.Xls;
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

        private void Openfile_Button_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.Title = "Excel Datei Aussuchen";
            ofd.Filter = "Excel Dateien (*.xls)|*xls*";

            // get filename
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string filepath = ofd.FileName;
                ImportExcel(filepath);
            }
        }

        private void ImportExcel(string filepath)
        {
            // import excel workbook + worksheet
            Workbook wb = new Workbook();
            wb.LoadFromFile(filepath);
            Worksheet ws = wb.Worksheets[0];

            // save to datatable + show
            DataTable dt = ws.ExportDataTable();
            Inport_Tabelle.DataSource = dt;
        }

        private void Löschen_Button_Click(object sender, EventArgs e)
        {
            // clear everything
            Inport_Tabelle.Columns.Clear();
            TB_Openfile.Text = "";
        }

        private void Speichern_Button_Click(object sender, EventArgs e)
        {
            // ask for confirmation
            DialogResult result = MessageBox.Show("Möchten Sie die Tabelle wirklich in die Datenbank einfügen?", "Bestätigung", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string tableName = TB_Openfile.Text;
                List<string> columns = new();
                List<List<string>> valueList = new();  
                
                foreach (DataGridViewColumn column in Inport_Tabelle.Columns)
                {
                    // add column names to list
                    columns.Add(column.Name);
                }

                foreach (DataGridViewRow row in Inport_Tabelle.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        // make list of values for every row
                        List<string> values = new List<string>();
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            values.Add(cell.Value.ToString());
                        }

                        // add list of values to list for values
                        valueList.Add(values);
                    }
                }

                DB_Connector connector = new DB_Connector();
                // make new table (select column name from columns list & get string of column name + VARCHAR(255) via lambda)
                connector.executeQuery($"CREATE TABLE {tableName} ({string.Join(", ", columns.Select(column => $"{column} VARCHAR(255)"))})");

                // insert data into table
                connector.addData(tableName, columns, valueList);

                MessageBox.Show("Tabelle erfolgreich hinzugefügt.");
            }
        }

        private void Speichern_Button_MouseEnter(object sender, EventArgs e)
        {
            Speichern_Button.BackColor = System.Drawing.Color.DarkBlue;
        }

        private void Speichern_Button_MouseLeave(object sender, EventArgs e)
        {
            Speichern_Button.BackColor = System.Drawing.Color.BlueViolet;
        }

        private void Löschen_Button_MouseEnter(object sender, EventArgs e)
        {
            Löschen_Button.BackColor = System.Drawing.Color.DarkRed;
        }

        private void Löschen_Button_MouseLeave(object sender, EventArgs e)
        {
            Löschen_Button.BackColor = System.Drawing.Color.BlueViolet;
        }
    }
}
