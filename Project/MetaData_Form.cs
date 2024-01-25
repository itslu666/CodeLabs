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
    public partial class MetaData_Form : Form
    {
        public MetaData_Form()
        {
            InitializeComponent();
            showMetadata();
        }

        private void showMetadata()
        {
            DB_Connector connector = new DB_Connector();

            var tables = connector.GetData("SHOW TABLES");

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("col", "Alle Tabellen");

            dataGridView2.Columns.Add("field", "Field");
            dataGridView2.Columns.Add("type", "Type");
            dataGridView2.Columns.Add("null", "Null");
            dataGridView2.Columns.Add("key", "Key");
            dataGridView2.Columns.Add("default", "Default");
            dataGridView2.Columns.Add("extra", "Extra");

            foreach (var item in tables)
            {
                List<(string, string, string, string, string, string)> metadata = new();

                var table = item[0];
                dataGridView1.Rows.Add(table);

                var metaDataString = connector.GetData($"DESCRIBE {table}");

                foreach (var entry in metaDataString)
                {
                    metadata.Add((entry[0], entry[1], entry[2], entry[3], entry[4], entry[5]));
                }

                foreach (var tuple in metadata)
                {
                    dataGridView2.Rows.Add(tuple.Item1, tuple.Item2, tuple.Item3, tuple.Item4, tuple.Item5, tuple.Item6);
                }

                dataGridView2.Rows.Add();
            }
            
        }
    }
}
