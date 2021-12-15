using System;
using System.Data;
using MySql.Data.MySqlClient;
namespace EmployeeManagementSystem
{
    public class Connection
    {
        static private MySqlConnection connection = new MySqlConnection("Uid=root;Pwd=B14ngk3r0g523507!!%%;server=localhost;database=employeemanagementsystem;port=3306;");

        public Connection()
        {

        }
        
        public static MySqlConnection GetConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            return connection;
        }

        public static void OpenConnection()
        {
            if(connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        public static void CloseConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

    }
}
