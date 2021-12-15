using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem.Model
{
    public class Department
    {
        public Department()
        {

        }
        public string _deptname { get; set; }
        public string DeptName { get; set; }
        public string DeptDesc { get; set; }
        public static Department CurrentDepartment = null;
        #region Function
        public static DataTable GetDataTable()
        {
            DataTable dt = Controller.Query.GetDataTable("GetDTDepartment", new string[1] { "noparam" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[1] { "" });
            return dt;
        }
        public static Department Get(string deptname)
        {
            DataTable dt = Controller.Query.GetDataTable("GetDepartment", new string[1] { "@_namedept" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[1] { deptname });
            if (dt.Rows.Count >=1)
            {
                Department d = new Department();
                d.DeptName = dt.Rows[0][0].ToString();
                d.DeptDesc = dt.Rows[0][1].ToString();
                d._deptname = d.DeptName;
                return d;
            }
            else
            {
                return null;
            }
        }
        public static int GetTotalDepartmentCount()
        {
            int i = 0;
            DataTable dt = Controller.Query.GetDataTable("GetStatDepartment", new string[1] { "noparam" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[1] { "" });
            if (dt.Rows.Count>=1)
            {
                i = Convert.ToInt32(dt.Rows[0][0].ToString());
                return i;
            }
            else
            {
                return 0;
            }
        }
        public static bool Insert(Department d)
        {
            if (Controller.Query.Insert("InsertDepartment", new string[2] { "@_namedept", "@_descdept" }, new MySql.Data.MySqlClient.MySqlDbType[2] { MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.Text }, new string[2] { d.DeptName, d.DeptDesc }))
            {
                return true;
            }
            else
            {
                return false;   
            }
        }
        public static bool update(Department d)
        {
            if (Controller.Query.Insert("UpdateDepartment", new string[3] { "@_namedept", "@_descdept", "@_oldname" }, new MySql.Data.MySqlClient.MySqlDbType[3] { MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.Text, MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[3] { d.DeptName, d.DeptDesc, d._deptname }))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Delete(string deptname)
        {
            if (Controller.Query.Delete("DeleteDepartment", new string[1] { "_namedept" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[1] { deptname }))
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
