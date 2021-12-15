using System;
using System.Windows.Forms;
using EmployeeManagementSystem.Model;

namespace EmployeeManagementSystem.Interface
{
    public partial class Login : UserControl
    {
        private bool isloaded = false;
        public Login()
        {


        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            if (User.Auth(txtUsername.Text, txtPassword.Text))
            {
                Notification.Alert($"Hello, {User.CurrentUser.Employee.FullName}! You're logged in!", PopUp.AlertType.Info);
                UIController.Navigate(UIController.Controls.Dashboard);
            }
            else
            {
                Notification.Alert("We couldn't recognise you, mind to reintroduce?", PopUp.AlertType.Warning);
            }
        }

        public void InitializeObject()
        {
            if (!isloaded)
            {
                InitializeComponent();
                isloaded = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            PanelResetPasswordValidation.BringToFront();
            PanelResetPasswordValidation.Visible = true;
            UIController.AnimateControl(PanelResetPasswordValidation, Guna.UI2.AnimatorNS.AnimationType.HorizSlide);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PanelResetPasswordValidation.BringToFront();
            PanelResetPasswordValidation.Visible = true;

            UIController.AnimateControl(PanelResetPasswordValidation, Guna.UI2.AnimatorNS.AnimationType.HorizSlide);
        }

        User curruser = null;

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (User.ValidationByUnameAndSecret(txtUnameforgot.Text, SecurityQuestDrop.Text, txtANswer.Text))
            {
                PanelResetNow.BringToFront();
                UIController.AnimateControl(PanelResetNow, Guna.UI2.AnimatorNS.AnimationType.HorizSlide);
            }
            else
            {
                Notification.Alert("The information you provided is not valid!", PopUp.AlertType.Error);
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (txtpass1.Text == txtpass2.Text)
            {
                if (txtpass1.Text != "" && txtpass2.Text != "")
                {
                    User.CurrentUser.Password = txtpass1.Text;
                    if (User.ResetPassword(User.CurrentUser))
                    {
                        Notification.Alert("Your password has been reset succesfully!", PopUp.AlertType.Success);
                        ContainerLogin.BringToFront();
                        UIController.AnimateControl(ContainerLogin, Guna.UI2.AnimatorNS.AnimationType.HorizSlide);
                        txtpass1.Clear();
                        txtpass2.Clear();
                        txtUnameforgot.Clear();
                        txtANswer.Clear();
                        SecurityQuestDrop.SelectedIndex = 0;
                    }
                    else
                    {
                        Notification.Alert("Something is wrong, we couldn't update your password", PopUp.AlertType.Error);
                    }
                }
                else
                {
                    Notification.Alert("Please enter your password!", PopUp.AlertType.Error);
                }
            }
            else
            {
                Notification.Alert("Both password must be match!", PopUp.AlertType.Error);
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ContainerLogin.BringToFront();
            UIController.AnimateControl(ContainerLogin, Guna.UI2.AnimatorNS.AnimationType.HorizSlide);
        }
    }
}
