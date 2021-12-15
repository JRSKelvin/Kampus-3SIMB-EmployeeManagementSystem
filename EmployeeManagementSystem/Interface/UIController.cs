using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EmployeeManagementSystem.Interface;
using System.Net.Http.Headers;
using EmployeeManagementSystem.Controller;
using Guna.UI2.WinForms;
using EmployeeManagementSystem.Properties;

namespace EmployeeManagementSystem.Interface
{
    public class UIController
    {
        #region Properties
        #region InterfaceComponent
        private static Login login = new Login();
        private static Guna2Transition Transition = new Guna2Transition();
        private static UpperPanel upperDefault = new UpperPanel();
        private static LeftPanel leftPanel = new LeftPanel();
        private static Dashboard dashboard = new Dashboard();
        private static DialogYesNo dialog = new DialogYesNo();
        private static Employee employee = new Employee();
        private static DeptUC DepartmentUC = new DeptUC();
        private static AccountUC UserAcc = new AccountUC();
        private static UCAnnouncement AnnouncementUC = new UCAnnouncement();
        #endregion

        public enum Controls { LeftPanel, LeftPanelExpand, Login, UpperPanel, Dashboard, Employee, Department, RegisterNewEmployee, Announcement, UserAccount }
        private static Controls _controls;
        public enum DockType { top, fill, left }
        private static DockType _dock;
        public enum UpperPanelEnum { def }
        private static UpperPanelEnum _up;
        static Form mainform = Application.OpenForms[0];
        private static UserControl ctrl;
        #endregion

        public UIController()
        {

        }

        #region Function
        //navigate
        private static void SetControl(Control control, DockStyle dock)
        {
            if (mainform.Controls.Contains(control))
            {
                //mainform.Controls[mainform.Controls.IndexOf(control)].BringToFront();
                control.BringToFront();
            }
            else
            {
                mainform.Controls.Add(control);
                control.Dock = dock;
                control.BringToFront();
            }
        }
        public static void OverrideUC(Control control)
        {
            SetControl(control, DockStyle.Fill);
        }
        public static void AnimateControl(Control control, Guna.UI2.AnimatorNS.AnimationType animationType)
        {
            control.Hide();
            Transition.AnimationType = animationType;
            Transition.Show(control);
        }
        public static void AnimateHideControl(Control control, Guna.UI2.AnimatorNS.AnimationType animationType)
        {
            control.Show();
            Transition.AnimationType = animationType;
            Transition.Hide(control);
        }

        public static void Navigate(Controls ctr)
        {
            _controls = ctr;
            switch (ctr)
            {
                case Controls.UserAccount:
                    SetControl(UserAcc, DockStyle.Fill);
                    UserAcc.InitObject();

                    break;
                case Controls.Announcement:
                    SetControl(AnnouncementUC, DockStyle.Fill);
                    AnnouncementUC.InitObject();
                    break;
                case Controls.LeftPanel:

                    break;
                case Controls.LeftPanelExpand:
                    
                    break;
                case Controls.Login:
                    SetControl(login, DockStyle.Fill);
                    login.InitializeObject();
                    AnimateControl(login, Guna.UI2.AnimatorNS.AnimationType.Transparent);
                    break;
                case Controls.UpperPanel:
                    SetControl(upperDefault, DockStyle.Top);
                    upperDefault.InitObject();
                    AnimateControl(upperDefault, Guna.UI2.AnimatorNS.AnimationType.HorizSlide);
                    break;
                case Controls.Dashboard:
                    AnimateHideControl(login, Guna.UI2.AnimatorNS.AnimationType.Transparent);
                    SetControl(dashboard, DockStyle.Fill);
                    dashboard.InitializeObject();
                    break;
                case Controls.Employee:
                    SetControl(employee, DockStyle.Fill);
                    employee.InitializeObject(Employee.state.View);
                    AnimateControl(employee, Guna.UI2.AnimatorNS.AnimationType.HorizSlide);
                    break;
                case Controls.Department:
                    SetControl(DepartmentUC, DockStyle.Fill);
                    DepartmentUC.InitObject(DeptUC.Action.View);
                    break;
                case Controls.RegisterNewEmployee:
                    SetControl(employee, DockStyle.Fill);
                    employee.InitializeObject(Employee.state.Create);
                    break;
            }
        }
        private int _enlargeimgVal = 0;
        public static void EnlargeImage(PictureBox picture, int sizeaddition)
        {
            picture.Height += sizeaddition;
            picture.Width += sizeaddition;
        }
        public static void ReduceImageSize(PictureBox picture, int sizeaddition)
        {
            picture.Height -= sizeaddition;
            picture.Width -= sizeaddition;
        }
        public static void ResetControl(Control ctrl)
        {
            foreach (var item in ctrl.Controls)
            {
                if (item is Guna2TextBox)
                {
                    var textbox = (Guna2TextBox)item;
                    textbox.Clear();
                }
                if (item is Guna2ComboBox)
                {
                    var combo = (Guna2ComboBox)item;
                    combo.SelectedIndex = -1;
                }
                if (item is Guna2CirclePictureBox)
                {
                    var picture = (Guna2CirclePictureBox)item;
                    picture.Image = Resources.icons8_male_user_52px;
                }
            }
        }
        #endregion
    }
}
