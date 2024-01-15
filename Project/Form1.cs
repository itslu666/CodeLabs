using System.Diagnostics;

namespace Project
{
    public partial class Form1 : Form
    {
        DB_Connector connector = new DB_Connector();

        public Form1()
        {
            InitializeComponent();

            List<string> resultData = connector.GetData("server=localhost;database=test;uid=root;pwd=;", "SELECT * FROM mitarbeiter");

            string messageToShow = string.Join(Environment.NewLine, resultData);
            MessageBox.Show(messageToShow);

            foreach(string item in resultData)
            {
                dataGridView1.Rows.Add(item.Split(" "));
            }
        }

        public void buttonclick()
        {
            List<string> resultData = connector.GetData("server=localhost;database=test;uid=root;pwd=;", "SELECT * FROM mitarbeiter");
        }
    }
}