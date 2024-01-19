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
        public List<List<string?>> GetData(string conString, string query)
        {
            var resultData = new List<List<string?>>();

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();
                    Console.WriteLine("Connected");

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int columnCount = reader.FieldCount;

                        while (reader.Read())
                        {
                            var row = new List<string?>();

                            for (int i = 0; i < columnCount; i++)
                            {
                                row.Add(reader[i].ToString());
                            }

                            resultData.Add(row);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fehler: " + ex.ToString());
                }
            }

            return resultData;
        }

    }
}