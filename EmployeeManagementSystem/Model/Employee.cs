using EmployeeManagementSystem.Controller;
using EmployeeManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Tracing;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Model
{


    public class Employee
    {
        public Employee()
        {

        }
        #region Properties
        public Int64 idEmployee
        {
            get;
            set;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string ResAddress { get; set; }
        public string ResPostCode { get; set; }
        public string Mobile { get; set; }
        public string HomePhone { get; set; }
        public string Nik { get; set; }
        public string Department { get; set; }
        public string JobTitle { get; set; }
        public string Desc { get; set; }
        public string Role { get; set; }
        public string picLocation { get; set; }
        public Employee CurrentEmployee = null;
        #endregion

        #region Function
        public static int TotalEmployeeRecorded()
        {
            int i = 0;
            DataTable dt = Query.GetDataTable("GetStatEmployee", new string[1] { "noparam" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[1] { "" });
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
        public static bool UpdatePhoto(Employee e)
        {
            if (Query.Insert("EmployeePicUpload", new string[2] { "@_idemployee", "@_employeepic" }, new MySql.Data.MySqlClient.MySqlDbType[2] { MySql.Data.MySqlClient.MySqlDbType.Int64, MySql.Data.MySqlClient.MySqlDbType.Text }, new string[2] { e.idEmployee.ToString(), e.picLocation }))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Employee Get(Int64 id)
        {
            DataTable dt =  Query.GetDataTable("GetEmployee", new string[1] { "@_IDEmployee" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.Int64 }, new string[1] { id.ToString() });
            if (dt.Rows.Count>=1)
            {
                Employee e = new Employee();
                e.idEmployee = id;
                e.FirstName = dt.Rows[0][1].ToString();
                e.LastName = dt.Rows[0][2].ToString();
                e.FullName = e.FirstName + " " + e.LastName;
                e.ResAddress = dt.Rows[0][3].ToString(); 
                e.ResPostCode = dt.Rows[0][4].ToString(); 
                e.Mobile = dt.Rows[0][5].ToString();
                e.HomePhone = dt.Rows[0][6].ToString();
                e.Nik = dt.Rows[0][7].ToString();
                e.JobTitle = dt.Rows[0][8].ToString();
                e.Desc = dt.Rows[0][9].ToString();
                e.picLocation = dt.Rows[0][10].ToString(); 
                e.Department = dt.Rows[0][11].ToString();
                return e;
            }
            else
            {
                return null;
            }
        }
        public static DataTable GetDataTable()
        {
            DataTable dt = Query.GetDataTable("GetDTEmployee", new string[1] { "noparam" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[1] { "" });
            return dt;
        }
        public static bool Insert(Employee e)
        {
            if (Query.Insert("InsertEmployee", new string[11] { "@_FirstNameEmployee",
                                                                "@_LastNameEmployee",
                                                                "@_ResidentialAddressEmployee",
                                                                "@_ResidentialPostCodeEmployee",
                                                                "@_MobileEmployee",
                                                                "@_HomePhoneEmployee",
                                                                "@_NIK",
                                                                "@_EmployeeDepartment",
                                                                "@_EmployeeJobTitle",
                                                                "@_EmployeeDesc",
                                                                "@_EmployeePic" }, 
                                                                new MySql.Data.MySqlClient.MySqlDbType[11] { MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar,
                                                                MySql.Data.MySqlClient.MySqlDbType.Text, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar,
                                                                 MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar,
                                                                MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.Text, MySql.Data.MySqlClient.MySqlDbType.Text}, 
                                                                new string[11] { e.FirstName, e.LastName, e.ResAddress, e.ResPostCode, e.Mobile, e.HomePhone, e.Nik, e.Department,
                                                                e.JobTitle, e.Desc, e.picLocation}))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Update(Employee e)
        {
            if (Query.Insert("UpdateEmployee", new string[12] { "@_IDEmployee",
                                                                "@_FirstNameEmployee",
                                                                "@_LastNameEmployee",
                                                                "@_ResidentialAddressEmployee",
                                                                "@_ResidentialPostCodeEmployee",
                                                                "@_MobileEmployee",
                                                                "@_HomePhoneEmployee",
                                                                "@_NIK",
                                                                "@_EmployeeDepartment",
                                                                "@_EmployeeJobTitle",
                                                                "@_EmployeeDesc",
                                                                "@_EmployeePic" },
                                                                new MySql.Data.MySqlClient.MySqlDbType[12] { MySql.Data.MySqlClient.MySqlDbType.Int64 ,MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar,
                                                                MySql.Data.MySqlClient.MySqlDbType.Text, MySql.Data.MySqlClient.MySqlDbType.VarChar,
                                                                 MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar,
                                                                MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.Text, MySql.Data.MySqlClient.MySqlDbType.Text},
                                                                new string[12] { e.idEmployee.ToString(), e.FirstName, e.LastName, e.ResAddress, e.ResPostCode, e.Mobile, e.HomePhone, e.Nik, e.Department,
                                                                e.JobTitle, e.Desc, e.picLocation}))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Delete(Int64 i)
        {
            if (Query.Delete("DeleteEmployee", new string[1] { "@_IDEmployee" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.Int64 }, new string[1] { i.ToString() }))
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
