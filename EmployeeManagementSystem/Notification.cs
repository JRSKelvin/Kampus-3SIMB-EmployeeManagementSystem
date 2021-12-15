using EmployeeManagementSystem.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagementSystem
{
    public class Notification
    {
        public Notification()
        {

        }
        public static void Alert(string msg, Interface.PopUp.AlertType type)
        {
            var f = new Interface.PopUp();
            f.setAlert(msg, type);
        }
    }
}
