using EmployeeManagementSystem.Controller;
using EmployeeManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Model
{
    public class User
    {
        #region Variable

        #endregion

        #region Properties
        public enum Roles
        {
            HR, Employee
        }

        public int Uid { get; set; }
        public string EmpsName { get; set; }
        public Int64 OwnerId { get; set; }
        public string Username { get; set; }
        private string _password;
        public string SecretQuestion { get; set; }
        public string SecretAnswer { get; set; }
        public string Role { get; set; }
        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private string _UserPicLocation;

        public string UserPicLocation
        {
            get { return _UserPicLocation; }
            set { _UserPicLocation = value; }
        }

        public Image userPic { get; set; }

        public static User CurrentUser = null;

        public Employee Employee { get; set; }

        #endregion
        public User()
        {

        }

        #region Function
       
        
        private static void FillCurrentUser(DataTable dt)
        {
            CurrentUser = new User();
            CurrentUser.Uid = Convert.ToInt32(dt.Rows[0][0].ToString());
            CurrentUser.OwnerId = Convert.ToInt64(dt.Rows[0][1].ToString());
            CurrentUser.Username = dt.Rows[0][2].ToString();
            CurrentUser.Password = dt.Rows[0][3].ToString();
            CurrentUser.SecretQuestion = dt.Rows[0][4].ToString();
            CurrentUser.SecretAnswer = dt.Rows[0][5].ToString();
            CurrentUser.Employee = Employee.Get(CurrentUser.OwnerId);
        }

        public static bool ValidationByUnameAndSecret(string username, string question, string answer)
        {
            DataTable dt = Query.GetDataTable("UserResetValidation", new string[3] { "@_username", "@_secretquestion", "@_answer" }, new MySql.Data.MySqlClient.MySqlDbType[3] { MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[3] { username, question, answer });
            if (dt.Rows.Count>=1)
            {
                FillCurrentUser(dt);
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool ResetPassword(User user)
        {
            if (Query.Insert("UserUpdatePassword", new string[2] { "@_uid", "@_password" }, new MySql.Data.MySqlClient.MySqlDbType[2] { MySql.Data.MySqlClient.MySqlDbType.Int32, MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[2] { user.Uid.ToString(), user.Password }))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static DataTable GetDataSource()
        {
            DataTable dt = Query.GetDataTable("GetDTUser", new string[1] { "noparam" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[1] { "" });
            return dt;
        }

        public static string GetOwnerNameByID(Int64 i)
        {
            string e = "";
            DataTable dt = Query.GetDataTable("GetUserNamebyID", new string[1] { "@_i" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.Int32 }, new string[1] { i.ToString() });
            if (dt.Rows.Count >= 1)
            {
                e = dt.Rows[0][0].ToString();
            }
            return e;
        }

        public static Int64 GetOwnerIDByName(string e)
        {
            Int64 ez = 0;
            DataTable dt = Query.GetDataTable("GetOwnerIDByName", new string[1] { "@_name" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[1] { e });
            if (dt.Rows.Count>=1)
            {
                ez = Convert.ToInt64(dt.Rows[0][0].ToString());
            }
            return ez;
        }

        public static bool Auth(string username, string password)
        {
            Int64 id;
            try
            {
                DataTable dt = Query.GetDataTable("Login", new string[2] { "@_usr", "@_pass" }, new MySql.Data.MySqlClient.MySqlDbType[2] { MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[2] { username, password });
                if (dt.Rows.Count >= 1)
                {
                    FillCurrentUser(dt);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Notification.Alert("Something is wrong!" + "Error details: " + ex.Message, Interface.PopUp.AlertType.Error);
                return false;
            }
        }
        public static bool Insert(User e)
        {
            if (Query.Insert("InsertUser", new string[5] { "@_idOwner", "@_username", "@_pass", "@_secretquestion", "@_answer" }, new MySql.Data.MySqlClient.MySqlDbType[5] { MySql.Data.MySqlClient.MySqlDbType.Int32, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[5] { e.OwnerId.ToString(), e.Username, e.Password, e.SecretQuestion, e.SecretAnswer }))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Update(User e)
        {
            if (Query.Insert("UpdateUser", new string[6] { "@_Uid", "@_idOwner", "@_username", "@_pass", "@_secretquestion", "@_answer" }, new MySql.Data.MySqlClient.MySqlDbType[6] { MySql.Data.MySqlClient.MySqlDbType.Int32, MySql.Data.MySqlClient.MySqlDbType.Int64, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[6] { e.Uid.ToString() ,e.OwnerId.ToString(), e.Username, e.Password, e.SecretQuestion, e.SecretAnswer }))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static User Get(Int64 e)
        {
            DataTable dt = Query.GetDataTable("GetUser", new string[1] { "@_uid" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.Int32 }, new string[1] { e.ToString() });
            if (dt.Rows.Count>=1)
            {
                User u = new User();
                u.Uid = Convert.ToInt32(dt.Rows[0][0].ToString());
                try
                {
                    u.OwnerId = Convert.ToInt64(dt.Rows[0][1].ToString());

                }
                catch (Exception)
                {
                    u.OwnerId = 0;
                }
                u.Username = dt.Rows[0][2].ToString();
                u.Password = dt.Rows[0][3].ToString();
                u.SecretQuestion = dt.Rows[0][4].ToString();
                u.SecretAnswer = dt.Rows[0][5].ToString();
                return u;
            }
            else
            {
                return null;
            }
        }
        public static bool Delete(User e)
        {
            if (Query.Delete("DeleteUser", new string[1] { "@_uid" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.Int32 }, new string[1] { e.Uid.ToString() }))
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
        #endregion


    }
}
