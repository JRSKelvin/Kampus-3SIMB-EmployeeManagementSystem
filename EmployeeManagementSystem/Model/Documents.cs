using System;
using System.Data;
using System.Threading.Tasks;
using EmployeeManagementSystem.Controller;

namespace EmployeeManagementSystem.Model
{
    class Documents
    {
        public Documents()
        {

        }

        #region Properties
        public int IDDocument { get; set; }
        public Int64 OwnerDocument { get; set; }
        public string DocumentType { get; set; }
        public string DocumentName { get; set; }
        public string DocumentLocation { get; set; }

        #endregion

        #region Function
        public static void Open()
        {

        }
        public static Documents Get(int i)
        {
            DataTable dt = Query.GetDataTable("GetDocument", new string[1] { "@_iddocs" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.Int32 }, new string[1] { i.ToString() });
            if (dt.Rows.Count >=1)
            {
                Documents e = new Documents();
                e.IDDocument = Convert.ToInt32(dt.Rows[0][0].ToString());
                e.OwnerDocument = Convert.ToInt64(dt.Rows[0][1].ToString());
                e.DocumentName = dt.Rows[0][2].ToString();
                e.DocumentType = dt.Rows[0][3].ToString();
                e.DocumentLocation = dt.Rows[0][4].ToString();
                return e;
            }
            else
            {
                return null;
            }
        }


        public static DataTable GetDataTable(Int64 i)
        {
            DataTable dt = Query.GetDataTable("GetDTDocument", new string[1] { "@_ownerdocs" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.Int64 }, new string[1] { i.ToString() });
            return dt;
        }
        public static bool Insert(string[] val)
        {
            if (Query.Insert("InsertDocument", new string[4] { "@_docslocation", "@_ownerdocs", "@_docstype", "@_docsname" }, new MySql.Data.MySqlClient.MySqlDbType[4] { MySql.Data.MySqlClient.MySqlDbType.Text, MySql.Data.MySqlClient.MySqlDbType.Int64, MySql.Data.MySqlClient.MySqlDbType.VarChar, MySql.Data.MySqlClient.MySqlDbType.VarChar }, val))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Update(Documents e)
        {
            if (Query.Insert("InsertDocument",
                new string[5]
                {
                "@_IDDocs",
                "@_ownerdocs",
                "@_docsname",
                "@_docstype",
                "@_docslocation"
                },
                new MySql.Data.MySqlClient.MySqlDbType[5]
                {
                    MySql.Data.MySqlClient.MySqlDbType.Int32,
                    MySql.Data.MySqlClient.MySqlDbType.Int64,
                    MySql.Data.MySqlClient.MySqlDbType.VarChar,
                    MySql.Data.MySqlClient.MySqlDbType.VarChar,
                    MySql.Data.MySqlClient.MySqlDbType.Text
                },
                new string[5]
                {
                    e.IDDocument.ToString(),
                    e.OwnerDocument.ToString(),
                    e.DocumentName,
                    e.DocumentType,
                    e.DocumentLocation
                }))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool Delete(int e)
        {
            if (Query.Delete("DeleteDocument", new string[1] { "@_iddocs" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.Int32 }, new string[1] { e.ToString() }))
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
