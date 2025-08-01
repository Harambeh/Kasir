using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using MySql.Data.MySqlClient;

namespace Kasir
{
    internal class AdminAddUsersData
    {
        MySqlConnection connect = new MySqlConnection("server=sql12.freesqldatabase.com;user=sql12792637;database=sql12792637;password=tEu5XNaILQ;");

        public int Id { get; set; } 
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Status { get; set; }
        public string DataRegistered { get; set; }

        public List<AdminAddUsersData> usersListData()
        {
            List<AdminAddUsersData> listData = new List<AdminAddUsersData>();

            if (connect.State != ConnectionState.Open)
            {
                try
                {
                    connect.Open();

                    string selectData = "SELECT * FROM users";

                    using (MySqlCommand cmd = new MySqlCommand(selectData, connect))
                    {
                        MySqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AdminAddUsersData usersData = new AdminAddUsersData();
                            usersData.Id = (int)reader["id"];
                            usersData.Username = reader["username"].ToString();
                            usersData.Password = reader["password"].ToString();
                            usersData.Role = reader["role"].ToString();
                            usersData.Status = reader["status"].ToString();
                            usersData.DataRegistered = reader["data_reg"].ToString();

                            listData.Add(usersData);
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Koneksi gagal: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;
        }
    }
}
