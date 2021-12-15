using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using EmployeeManagementSystem.Controller;

namespace EmployeeManagementSystem
{
    public class Db
    {
        //declare connection path
        //port was 4409, changed to 3306
        //ais connection
        private static BackgroundWorker worker;
        private static readonly MySqlConnection Connection = new MySqlConnection($"Uid=root;Pwd=B14ngk3r0g523507!!%%;server=localhost;database=employeemanagementsystem;port=3306;");
        //private static readonly MySqlConnection Connection = new MySqlConnection("Uid=root;Pwd=fR9iMEnRxcaHjB;server=192.168.30.100;database=employeemanagementsystem;port=4409;");
        public static readonly string ServerIPAddress = @"192.168.30.100";
        //home connection
        //static private MySqlConnection Connection = new MySqlConnection("Uid=root;Pwd=B14ngk3r0g523507!!%%;server=localhost;database=aisdb;port=3306;Allow User Variables=True");

        //open connection
        static public void OpenConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                try
                {
                    Connection.Open();

                }
                catch (MySqlException e)
                {
                    Notification.Alert(e.Message, EmployeeManagementSystem.Interface.PopUp.AlertType.Error);
                }
            }
        }
        //close connection

        static public void CloseConnection()
        {
            if (Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }

        public static void DataAdapter(MySqlCommand command, DataTable dataTable)
        {
            var da = new MySqlDataAdapter(command);
            try
            {
                da.Fill(dataTable);
            }
            catch (MySqlException ex)
            {
                Notification.Alert(ex.Message, EmployeeManagementSystem.Interface.PopUp.AlertType.Error);
            }
        }

        //return connection
        static public MySqlConnection GetConnection()
        {
            if (Connection.State == ConnectionState.Closed)
            {
                OpenConnection();
            }
            return Connection;
        }

    }
}
