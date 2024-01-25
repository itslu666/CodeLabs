using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;

namespace Project
{
    public partial class UC_Tabelle : UserControl
    {
        List<Artikel> artikelList = new List<Artikel>();
        List<Kunde> kundenList = new List<Kunde>();
        List<Lieferant> lieferantList = new List<Lieferant>();

        public UC_Tabelle()
        {
            InitializeComponent();
        }

        private void Dashboard_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ShowArtikelTable();
        }
        private void Dashboard_MouseDown(object sender, MouseEventArgs e)
        {
            ShowArtikelTable();
        }

        private void Kunden_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ShowKundenTable();
        }
        private void Kunden_Label_MouseDown(object sender, MouseEventArgs e)
        {
            ShowKundenTable();
        }

        private void Artikel_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ShowArtikelTable();
        }
        private void Artikel_Label_MouseDown(object sender, MouseEventArgs e)
        {
            ShowArtikelTable();
        }

        private void Lieferant_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ShowLieferantTable();
        }
        private void Lieferant_Label_MouseDown(object sender, MouseEventArgs e)
        {
            ShowLieferantTable();
        }


        private void Hinzufügen_Button_Click(object sender, EventArgs e)
        {
            Hinzufuegen hinwin = new Hinzufuegen(dataGridView1);
            hinwin.Show();
        }

        private void Loeschen_Button_MouseDown(object sender, MouseEventArgs e)
        {
            Loeschen loesch = new Loeschen(dataGridView1);
            loesch.Show();
        }

        private void Bearbeiten_Button_Click(object sender, EventArgs e)
        {
            Bearbeiten beab = new Bearbeiten(dataGridView1);
            beab.Show();
        }

        private void ShowArtikelTable()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("art_nr", "Artikel Nummer"); 
                dataGridView1.Columns.Add("name", "Name");
                dataGridView1.Columns.Add("beschreibung", "Beschreibung");
                dataGridView1.Columns.Add("vk_preis", "Verkaufs Preis");
                dataGridView1.Columns.Add("wg_nr", "Warengruppe ID");
            }

            List<Artikel> artList = getArtikel();

            foreach (Artikel art in artList)
            {
                dataGridView1.Rows.Add(art.Id.ToString(), art.Bezeichnung.ToString(), art.Description.ToString(), art.Price.ToString(), art.Wg_nr.ToString());
            }
        }

        private void ShowKundenTable()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();


            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("k_nr", "Kunden Nr");
                dataGridView1.Columns.Add("anrede", "Anrede");
                dataGridView1.Columns.Add("name", "Name");
                dataGridView1.Columns.Add("vorname", "Vorname");
                dataGridView1.Columns.Add("straße", "Straße");
                dataGridView1.Columns.Add("plz", "PLZ");
                dataGridView1.Columns.Add("ort", "Ort");
                dataGridView1.Columns.Add("email", "E-Mail");
                dataGridView1.Columns.Add("tel_nr", "Tel-Nr");
                dataGridView1.Columns.Add("kat_nr", "Kat_Nr");

                List<Kunde> kundList = getKunden();

                foreach (Kunde kunde in kundList)
                {
                    dataGridView1.Rows.Add(kunde.Id.ToString(), kunde.Anrede.ToString(), kunde.Name.ToString(), kunde.Vorname.ToString(), kunde.Straße.ToString(), kunde.Plz.ToString(), kunde.Ort.ToString(), kunde.Mail.ToString(), kunde.Tel.ToString(), kunde.Kat_nr.ToString());
                }
            }
        }

        private void ShowLieferantTable()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("l_nr", "ID");
                dataGridView1.Columns.Add("name", "Name");
                dataGridView1.Columns.Add("straße", "Straße");
                dataGridView1.Columns.Add("plz", "PLZ");
                dataGridView1.Columns.Add("ort", "Ort");
                dataGridView1.Columns.Add("email", "E-Mail");
                dataGridView1.Columns.Add("tel_nr", "Tel-Nr");

                List<Lieferant> lieferList = getLieferant();

                foreach (Lieferant lieferant in lieferList)
                {
                    dataGridView1.Rows.Add(lieferant.Id.ToString(), lieferant.Name.ToString(), lieferant.Straße.ToString(), lieferant.Plz.ToString(), lieferant.Ort.ToString(), lieferant.Mail.ToString(), lieferant.Tel.ToString());
                }
            }
        }

        private List<Artikel> getArtikel()
        {
            DB_Connector connector = new DB_Connector();
            var data = connector.GetData("SELECT * FROM artikel");

            // Leere die Liste vor dem Hinzufügen neuer Daten
            artikelList.Clear();

            foreach (var values in data)
            {

                Artikel artikel = new Artikel();

                artikel.Id = Convert.ToInt32(values[0]);
                artikel.Bezeichnung = values[1];
                artikel.Description = values[2];
                artikel.Price = values[3];
                artikel.Wg_nr = int.TryParse(values[4], out int id) ? id : 0;

                artikelList.Add(artikel);
            }

            return artikelList;
        }

        private List<Kunde> getKunden()
        {
            DB_Connector connector = new DB_Connector();
            var data = connector.GetData("SELECT * FROM kunden");

            // Leere die Liste vor dem Hinzufügen neuer Daten
            kundenList.Clear();

            foreach (var values in data)
            {

                Kunde kunde = new Kunde();

                kunde.Id = Convert.ToInt32(values[0]);
                kunde.Anrede = values[1];
                kunde.Name = values[2];
                kunde.Vorname = values[3];
                kunde.Straße = values[4];
                kunde.Plz = Convert.ToInt32(values[5]);
                kunde.Ort = values[6];
                kunde.Mail = values[7];
                kunde.Tel = Convert.ToInt32(values[8]);
                kunde.Kat_nr = Convert.ToInt32(values[9]);

                kundenList.Add(kunde);
            }

            return kundenList;
        }

        private List<Lieferant> getLieferant()
        {
            DB_Connector connector = new DB_Connector();
            var data = connector.GetData("SELECT * FROM lieferant");

            lieferantList.Clear();

            foreach (var values in data)
            {
                Lieferant lieferant = new Lieferant();

                lieferant.Id = Convert.ToInt32(values[0]);
                lieferant.Name = values[1];
                lieferant.Straße = values[2];
                lieferant.Plz = values[3];
                lieferant.Ort = values[4];
                lieferant.Mail = values[5];
                lieferant.Tel = Convert.ToInt32(values[6]);

                lieferantList.Add(lieferant);
            }
            return lieferantList;
        }









        // hover events for panels
        private void Hinzufügen_Button_MouseEnter(object sender, EventArgs e)
        {
            Hinzufügen_Button.BackColor = Color.YellowGreen;
        }

        private void Hinzufügen_Button_MouseLeave(object sender, EventArgs e)
        {
            Hinzufügen_Button.BackColor = Color.BlueViolet;
        }
        private void Kunden_Panel_MouseEnter(object sender, EventArgs e)
        {
            Kunden_Panel.BackColor = Color.MediumPurple;
        }

        private void Kunden_Panel_MouseLeave(object sender, EventArgs e)
        {
            Kunden_Panel.BackColor = Color.BlueViolet;
        }
        private void Lieferant_Panel_MouseEnter(object sender, EventArgs e)
        {
            Lieferant_Panel.BackColor = Color.MediumPurple;
        }

        private void Lieferant_Panel_MouseLeave(object sender, EventArgs e)
        {
            Lieferant_Panel.BackColor = Color.BlueViolet;
        }
        private void Artikel_Panel_MouseHover(object sender, EventArgs e)
        {
            Artikel_Panel.BackColor = Color.MediumPurple;
        }
        private void Artikel_Panel_MouseLeave(object sender, EventArgs e)
        {
            Artikel_Panel.BackColor = Color.BlueViolet;
        }
        private void Loeschen_Button_MouseEnter(object sender, EventArgs e)
        {
            Loeschen_Button.BackColor = Color.DarkRed;
        }

        private void Loeschen_Button_MouseLeave(object sender, EventArgs e)
        {
            Loeschen_Button.BackColor = Color.BlueViolet;
        }
        private void Bearbeiten_Button_MouseEnter(object sender, EventArgs e)
        {
            Bearbeiten_Button.BackColor = ColorTranslator.FromHtml("#E4CD05");
        }

        private void Bearbeiten_Button_MouseLeave(object sender, EventArgs e)
        {
            Bearbeiten_Button.BackColor = Color.BlueViolet;
        }
        private void Export_Button_MouseEnter(object sender, EventArgs e)
        {
            Export_Button.BackColor = Color.DarkOliveGreen;
        }

        private void Export_Button_MouseLeave(object sender, EventArgs e)
        {
            Export_Button.BackColor = Color.BlueViolet;
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.MediumPurple;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.BlueViolet;
        }

        private void Lieferant_Label_Click(object sender, EventArgs e)
        {

        }

        private void Export_Button_Click(object sender, EventArgs e)
        {
            //Speicherort für die Excel-Datei fählen
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                DialogResult result = sfd.ShowDialog();

                if (result == DialogResult.OK)
                {
                    try
                    {
                        // Ausgabe der Anzahl der Zeilen in der DataGridView
                        Console.WriteLine($"Anzahl der Zeilen in der DataGridView: {dataGridView1.Rows.Count}");

                        if (dataGridView1 != null && dataGridView1.Rows.Count > 0)
                        {
                            // Verwenden der ClosedXML-Bibliothek zum Erstellen und Bearbeiten von Excel-Arbeitsmappen
                            using (XLWorkbook workbook = new XLWorkbook())
                            {
                                var worksheet = workbook.Worksheets.Add("Sheet1");

                                // Überschriften setzen
                                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                                {
                                    worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].Name;
                                }

                                // Daten aus DataGridView hinzufügen
                                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                                {
                                    for (int col = 0; col < dataGridView1.Columns.Count; col++)
                                    {
                                        object cellValue = dataGridView1.Rows[row].Cells[col].Value;

                                        // Überprüfe, ob der Zellenwert null ist, und ersetze ihn durch einen leeren String
                                        worksheet.Cell(row + 2, col + 1).Value = cellValue != null ? cellValue.ToString() : string.Empty;
                                    }
                                }

                                // Excel-Arbeitsmappe speichern
                                workbook.SaveAs(sfd.FileName);

                                Console.WriteLine("Daten erfolgreich in Excel-Datei exportiert.");
                                MessageBox.Show("Daten erfolgreich in Excel-Datei exportiert.", "Erfolg", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Die DataGridView enthält keine Daten zum Exportieren.");
                            MessageBox.Show("Die DataGridView enthält keine Daten zum Exportieren.", "Warnung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Fehlerbehandlung im Falle eines Exportfehlers
                        Console.WriteLine($"Fehler beim Exportieren der Daten: {ex.Message}");
                        MessageBox.Show($"Fehler beim Exportieren der Daten: {ex.Message}", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (result == DialogResult.Cancel)
                {
                    Console.WriteLine("Der Dialog wurde abgebrochen.");
                }
            }
        }

        private void MetaData_Button_MouseEnter(object sender, EventArgs e)
        {
            MetaData_Button.BackColor = Color.DarkBlue;
        }

        private void MetaData_Button_MouseLeave(object sender, EventArgs e)
        {
            MetaData_Button.BackColor = Color.BlueViolet;
        }

        private void MetaData_Button_Click(object sender, EventArgs e)
        {
            MetaData_Form metaData_Form = new MetaData_Form();
            metaData_Form.ShowDialog();
        }
    }
}
