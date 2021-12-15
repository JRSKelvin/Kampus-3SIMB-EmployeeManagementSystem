using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EmployeeManagementSystem.Controller
{
    public class Query
    {
        #region Enumeration
        public enum Process
        {
            Auth, LogLoginHistory, Master, LoadStudent, LoadStudentList, GetAcademicYearList, GetClassListByYear, GetClassMember, GetClassInfo, GetAvailableTeacherToAssign, GetUnassignedStudent
        }
        #endregion

        #region Properties
        private static BackgroundWorker worker;

        private static void initWorker()
        {
            worker = new BackgroundWorker();
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.DoWork += Worker_DoWork;
            worker.WorkerReportsProgress = true;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;
        }

        public enum Do
        {
            GetDataTable, GetList, Delete, Insert
        }

        private static Do @do;

        private static void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private static void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private static void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            switch (@do)
            {
                case Do.GetDataTable:
                    break;
                case Do.GetList:

                    break;
                case Do.Delete:
                    break;
                case Do.Insert:
                    break;
                default:
                    break;
            }
        }

        public Query()
        {

        }
        #endregion

        #region Variable
        private static MySqlCommand cmd;
        private static MySqlDataAdapter da;
        Process _process;
        #endregion

        #region Function

        public static List<string> GetList(string query)
        {
            List<string> l = new List<string>();
            DataTable dt = new DataTable();
            MySqlCommand cmd = Command(query);
            Db.DataAdapter(cmd, dt);
            foreach (string item in dt.Rows)
            {
                l.Add(item);
            }   
            return l;
        }

        public static AutoCompleteStringCollection GetAutoCompleteCollection(string query)
        {
            AutoCompleteStringCollection ac = new AutoCompleteStringCollection();
            DataTable dt = new DataTable();
            MySqlCommand cmd = Command(query);
            Db.DataAdapter(cmd, dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string str = dt.Rows[i][0].ToString();
                ac.Add(str);
            }
            return ac;
        }

        public static bool Delete(string Query, string[] param, MySqlDbType[] type, string[] value)
        {
            MySqlCommand cmd = Command(Query);
            if (param[0] != "@noparam")
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i], type[i]).Value = value[i];
                }
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static DataTable GetDataTable(string Query, string[] param, MySqlDbType[] type, string[] value)
        {
            DataTable dt = new DataTable();
            MySqlCommand cmd;
            cmd = Command(Query);
            if (param[0] != "@noparam")
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i], type[i]).Value = value[i];
                }
                Db.DataAdapter(cmd, dt);
            }
            else
            {
                Db.DataAdapter(cmd, dt);
            }
            return dt;
        }

        public static bool Insert(string query, string[] param, MySqlDbType[] type, string[] value)
        {
            MySqlCommand cmd = Command(query);
            if (param[0] != "@noparam")
            {
                for (int i = 0; i < param.Length; i++)
                {
                    cmd.Parameters.Add(param[i], type[i]).Value = value[i];
                }
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Notification.Alert("Operation completed succesfully", Interface.PopUp.AlertType.Success);
                    }
                    return true;
                }
                catch (MySqlException ex)
                {
                    Notification.Alert($"Oops something wrong\n({ex.Message})", Interface.PopUp.AlertType.Error);
                    return false;
                }
            }
            else
            {
                try
                {
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Notification.Alert("Operation completed succesfully", Interface.PopUp.AlertType.Success);
                    }
                    return true;
                }
                catch (MySqlException ex)
                {
                    Notification.Alert($"Something is wrong, possibly duplicate\nTech. Detail({ex.Message})", Interface.PopUp.AlertType.Error);
                    return false;
                }
            }
        }

        public static MySqlCommand Command(string str)
        {
            MySqlCommand cmd = new MySqlCommand(str, Db.GetConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            return cmd;
        }

        public static int? GetRandomNumber(Process proc)
        {
            MySqlCommand cmd;
            DataTable table = new DataTable();
            MySqlDataReader reader;

            int? UniqueNumber = null;
            switch (proc)
            {
                case Process.Master:
                    cmd = new MySqlCommand("GetRandomNumberAY", Db.GetConnection());
                    cmd.CommandType = CommandType.StoredProcedure;
                    reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        UniqueNumber = reader.GetInt32("random_num");
                    }
                    reader.Close();
                    return UniqueNumber;
                default:
                    return null;
            }
        }
        #endregion

    }
}
