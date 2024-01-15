namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            DB_Connector connector = new DB_Connector();

            connector.connect();
        }
    }
}