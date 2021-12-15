using EmployeeManagementSystem.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using EmployeeManagementSystem.Interface;
using System.Linq;
using EmployeeManagementSystem;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Controller
{

    public class Confirmation
    {
        public static string Title;
        public static string Subtitle;
        public static Image img;
        public static string yesDisplay;
        public static string noDisplay;
        public enum Type { Exit, DeleteEmployee }
        private static DialogYesNo control = new DialogYesNo();
        public Confirmation()
        {

        }
        private static Type _type;

        public static void Fire(Type type)
        {
            control.InitializeObject();
            _type = type;
            switch (type)
            {
                case Type.Exit:
                    control.Title = "Taking a break?";
                    control.Subtitle = "Are you sure you want to exit from system? any unsaved data will be lost!";
                    control.ImageDialog = Properties.Resources.icons8_question_mark_480px;
                    control.YesText = "Yes, let me go";
                    control.NoText = "No, i misclicked it";
                    break;
                case Type.DeleteEmployee:
                    break;
                default:
                    break;
            }
            UIController.OverrideUC(control);
        }

        public static void Yes()
        {
            switch (_type)
            {
                case Type.Exit:
                    Application.Exit();
                    break;
                case Type.DeleteEmployee:

                    break;
                default:
                    break;
            }
        }
        public static void No()
        {
            switch (_type)
            {
                case Type.Exit:
                    control.SendToBack();
                    break;
                case Type.DeleteEmployee:
                    break;
                default:
                    break;
            }
        }
    }
}
