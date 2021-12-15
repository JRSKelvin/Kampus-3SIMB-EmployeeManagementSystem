using System;
using System.Collections.Generic;
using EmployeeManagementSystem.Interface;
using EmployeeManagementSystem.Properties;
using System.Text;

namespace EmployeeManagementSystem.Controller
{
    public class MenuController
    {
        public MenuController()
        {

        }
        public static List<UCMenu> MenuHR = new List<UCMenu>
        {   UCMenu.AddMenu(Properties.Resources.InsertNewEmployee, "Register new employee", UIController.Controls.RegisterNewEmployee),
            UCMenu.AddMenu(Resources.EmployeeDirectory, "Employee Directory", UIController.Controls.Employee),
            UCMenu.AddMenu(Resources.announcethum, "Announcement", UIController.Controls.Announcement),
            UCMenu.AddMenu(Resources.derpartment, "Department", UIController.Controls.Department),
            UCMenu.AddMenu(Resources.ManageUserAccount, "User Account", UIController.Controls.UserAccount)
        };

        public static List<UCMenu> MenuEmployee = null;

        

    }
}
