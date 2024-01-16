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
        public List<string> GetData(string conString, string query)
        {
            List<string> resultData = new List<string>();

            using (MySqlConnection conn = new MySqlConnection(conString))
            {
                try
                {
                    conn.Open();
                    MessageBox.Show("Connection Open!");

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int columnCount = reader.FieldCount;

                        while (reader.Read())
                        {
                            StringBuilder rowStringBuilder = new StringBuilder();

                            for (int i = 0; i < columnCount; i++)
                            {
                                rowStringBuilder.Append(reader[i].ToString() + " ");
                            }

                            resultData.Add(rowStringBuilder.ToString());
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
