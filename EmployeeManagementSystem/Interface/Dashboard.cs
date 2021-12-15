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

namespace EmployeeManagementSystem.Interface
{
    public partial class Dashboard : UserControl
    {
        private Timer timer = new Timer();
        private bool isLoaded = false;
        private int xinit = 1280;
        private int xmax = 0;
        public Dashboard()
        {
            ThisSettings.SetTheme(ThisSettings.Theme.Dark, this);

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            xinit--;
            lblannouncement.Location = new Point(xinit, 8);
            if (xinit == -45)
            {
                xinit = 1280;
            }
        }

        public enum AnnouncementStat
        {
            Collapsed,
            Expanded
        }
        private AnnouncementStat _announce = AnnouncementStat.Collapsed;

        public enum ProfileStat
        { 
            View,
            Edit
        }
        private ProfileStat _profile = ProfileStat.View;

        public void InitializeObject()
        {
            if (!isLoaded)
            {
                InitializeComponent();
                timer.Tick += Timer_Tick;
                timer.Enabled = true;
                timer.Interval = 10;
                lblannouncement.Text = GetRunningText();
                FillStats();
                isLoaded = true;
            }
            else
            {

            }
        }

        private string GetRunningText()
        {
            string a = "";
            DataTable dt = Query.GetDataTable("GetRunningText", new string[1] { "noparam" }, new MySql.Data.MySqlClient.MySqlDbType[1] { MySql.Data.MySqlClient.MySqlDbType.VarChar }, new string[1] { "" });
            if (dt.Rows.Count>=1)
            {
                
            }
            else
            {
                a = "You can make an announcement here!";
            }
            return a;
        }

        private void FillProfileData()
        {
            pictureUser.Image = Utilities.GetImage(employee.picLocation);
            lbldashname.Text = employee.FullName;
            lbldashrole.Text = employee.Role;
            lbldashdepartment.Text = employee.Department;
            lbldashjobtitle.Text = employee.JobTitle;
            if (user.SecretQuestion != null && user.SecretQuestion != "")
            {
                SecurityQuestDrop.SelectedIndex = SecurityQuestDrop.Items.IndexOf(user.SecretQuestion);
            }
            else
            {
                SecurityQuestDrop.SelectedIndex = 0;
            }
            if (employee.FullName == "")
            {
                lbldashname.Text = PublicProperties.NoInfo;
            }
            if (employee.Role == "")
            {
                lbldashrole.Text = PublicProperties.NoInfo;
            }
            if (employee.Department == "")
            {
                lbldashdepartment.Text = PublicProperties.NoInfo;
            }
            if (employee.JobTitle == "")
            {
                lbldashjobtitle.Text = PublicProperties.NoInfo;
            }
            answerText.Text = user.SecretAnswer;
            GetMenu(user.Role);
        }

        private void GetMenu(string role)
        {
            foreach (Control item in MenuController.MenuHR)
            {
                flowMenu.Controls.Add(item);
            }
        }

        private Model.Employee employee = null;
        private Model.User user = null;

        private void FillStats()
        {
            employee = Model.User.CurrentUser.Employee;
            user = Model.User.CurrentUser;
            label2.Text = $"Total: {Model.Employee.TotalEmployeeRecorded().ToString()}";
            label3.Text = $"Total: { Model.Department.GetTotalDepartmentCount().ToString()}";
            FillProfileData();
        }

        private void EnableProfileEdit(bool o)
        {
            SecurityQuestDrop.Enabled = o;
            answerText.Enabled = o;
            passwordText.Enabled = o;
            profileaccept.Visible = o;
        }

        private void EditProfileData()
        {
            switch (_profile)
            {
                case ProfileStat.View:
                    EnableProfileEdit(true);
                    _profile = ProfileStat.Edit;
                    btnEdit.FillColor = Color.LightCoral;
                    break;
                case ProfileStat.Edit:
                    EnableProfileEdit(false);
                    _profile = ProfileStat.View;
                    btnEdit.FillColor = Color.White;
                    break;
            }
        }

        private void SwitchOnAnnouncement()
        {
            switch (_announce)
            {
                case AnnouncementStat.Collapsed:
                    UIController.AnimateControl(ContainerAnnouncement, Guna.UI2.AnimatorNS.AnimationType.HorizSlide);
                    btnAnnouncement.Location = new Point(906, 300);
                    UIController.AnimateControl(btnAnnouncement, Guna.UI2.AnimatorNS.AnimationType.Transparent);
                    _announce = AnnouncementStat.Expanded;
                    break;
                case AnnouncementStat.Expanded:
                    UIController.AnimateHideControl(ContainerAnnouncement, Guna.UI2.AnimatorNS.AnimationType.HorizSlide);
                    btnAnnouncement.Location = new Point(1258, 300);
                    UIController.AnimateControl(btnAnnouncement, Guna.UI2.AnimatorNS.AnimationType.HorizSlide);
                    _announce = AnnouncementStat.Collapsed;
                    break;
            }
        }

        private void btnAnnouncement_Click(object sender, EventArgs e)
        {
            SwitchOnAnnouncement();
        }

        private void profileaccept_Click(object sender, EventArgs e)
        {
            if (answerText.Text != "" || answerText.Text != null)
            {
                if (passwordText.Text == user.Password)
                {
                    user.SecretQuestion = SecurityQuestDrop.Text;
                    user.SecretAnswer = answerText.Text;
                    if (Model.User.Update(user))
                    {
                        Notification.Alert("Your profile is succesfully updated!", PopUp.AlertType.Success);
                        _profile = ProfileStat.View;
                        EnableProfileEdit(false);
                    }
                    else
                    {
                        Notification.Alert("Failed to update your profile!", PopUp.AlertType.Error);
                    }
                }
                else
                {
                    Notification.Alert("Wrong password, please try again", PopUp.AlertType.Error);
                }
            }
            else
            {
                Notification.Alert("Please provide more information!", PopUp.AlertType.Warning);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditProfileData();
        }
    }
}
