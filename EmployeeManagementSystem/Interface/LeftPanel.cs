using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem.Controller;
using Telerik.WinControls;
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Properties;
using Guna.UI2.WinForms;

namespace EmployeeManagementSystem.Interface
{
    public partial class LeftPanel : UserControl
    {
        public LeftPanel()
        {
            InitializeComponent();
            ThisSettings.SetTheme(ThisSettings.Theme.Dark, this);
        }

        public void InitializeObject()
        {
            FocusButton(btnHome);
        }

        #region Properties

        #endregion

        #region Function
        private void FocusButton(Guna2Button btn)
        {
            btnHome.FillColor = ThisSettings.DarkLight;
            btnEmploye.FillColor = ThisSettings.DarkLight;
            btnDept.FillColor = ThisSettings.DarkLight;
            btnUserAcc.FillColor = ThisSettings.DarkLight;
            btn.FillColor = Color.Coral;
        }
        #endregion

        #region Event
        private void btnHome_Click(object sender, EventArgs e)
        {
            FocusButton(btnHome);
            UIController.Navigate(UIController.Controls.Dashboard);
        }

        private void btnEmploye_Click(object sender, EventArgs e)
        {
            FocusButton(btnEmploye);
            UIController.Navigate(UIController.Controls.Employee);

        }

        private void btnDept_Click(object sender, EventArgs e)
        {
            FocusButton(btnDept);
           // UIController.Navigate(UIController.Controls.)
        }

        private void btnUserAcc_Click(object sender, EventArgs e)
        {
            FocusButton(btnUserAcc);

        }
        #endregion
    }
}
