using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Project
{
    public class DB_Connector
    {
        // 
        public List<string> GetData(string conString)
        {
            string connectionString = "server=localhost;database=a1;uid=root;pwd=;";
            List<string> resultData = new List<string>();
            
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection Open!");

                    string query = "SELECT columnName FROM yourTable";
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            resultData.Add(reader.GetString("columnName"));
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return resultData;
        }
    }
}
