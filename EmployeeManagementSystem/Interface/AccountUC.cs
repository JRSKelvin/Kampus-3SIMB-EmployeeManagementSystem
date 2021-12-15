using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Interface
{
    public partial class AccountUC : UserControl
    {
        private bool isLoaded = false;

        public enum EditMode
        {
            Create, Edit, View
        }
        private EditMode _edit = EditMode.View;

        private void SwitchEditMode(EditMode e)
        {
            _edit = e;
            switch (e)
            {
                case EditMode.Create:
                    txtusername.Enabled = true;
                    txtpassword.Enabled = true;
                    dropsecquestion.Enabled = true;
                    txtSecretAnswer.Enabled = true;
                    dropOwner.Enabled = true;
                    txtusername.ReadOnly = false;
                    txtpassword.ReadOnly = false;
                    txtSecretAnswer.ReadOnly = false;
                    break;
                case EditMode.Edit:
                    txtusername.Enabled = true;
                    txtpassword.Enabled = true;
                    dropsecquestion.Enabled = true;
                    txtSecretAnswer.Enabled = true;
                    dropOwner.Enabled = true;
                    txtusername.ReadOnly = false;
                    txtpassword.ReadOnly = false;
                    txtSecretAnswer.ReadOnly = false;
                    break;
                case EditMode.View:
                    txtusername.Enabled = false;
                    txtpassword.Enabled = false;
                    dropsecquestion.Enabled = false;
                    txtSecretAnswer.Enabled = false;
                    dropOwner.Enabled = false;
                    break;
            }
        }

        public void InitObject()
        {
            if (!isLoaded)
            {
                InitializeComponent();
                InitDrop();
                FillDG();
                SwitchEditMode(EditMode.View);
            }
            else
            {
                FillDG();
            }
        }

        private void FillDG()
        {
            dgUserAccount.DataSource = Model.User.GetDataSource();
        }

        public AccountUC()
        {
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private Model.User CurrentUser = null;

        private void PrepData()
        {
            switch (_edit)
            {
                case EditMode.Create:
                    CurrentUser = new Model.User();
                    CurrentUser.Username = txtusername.Text;
                    CurrentUser.Password = txtpassword.Text;
                    CurrentUser.SecretQuestion = dropsecquestion.Text;
                    CurrentUser.SecretAnswer = txtSecretAnswer.Text;
                    var s = dropOwner.Text;
                    var d = s.Split(new[] { ' ' }, 2);
                    CurrentUser.OwnerId = Model.User.GetOwnerIDByName(d[0]);
                    break;
                case EditMode.Edit:
                    CurrentUser.Username = txtusername.Text;
                    CurrentUser.Password = txtpassword.Text;
                    CurrentUser.SecretQuestion = dropsecquestion.Text;
                    CurrentUser.SecretAnswer = txtSecretAnswer.Text;
                    var f = dropOwner.Text;
                    var g = f.Split(new[] { ' ' }, 2);
                    CurrentUser.OwnerId = Model.User.GetOwnerIDByName(g[0]);
                    break;
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _edit = EditMode.Create;
            InitClear();
            SwitchEditMode(_edit);
            btnconfirm.Text = "Add new account";
        }

        private void SaveData()
        {
            PrepData();
            switch (_edit)
            {
                case EditMode.Create:
                    if (Model.User.Insert(CurrentUser))
                    {
                        FillDG();
                        Notification.Alert("User created succesfully!", PopUp.AlertType.Success);
                    }
                    else
                    {
                        Notification.Alert("Failed to create new user", PopUp.AlertType.Error);
                    }
                    break;
                case EditMode.Edit:
                    if (Model.User.Update(CurrentUser))
                    {
                        Notification.Alert("User updated succesfully!", PopUp.AlertType.Success);
                        FillDG();
                    }
                    else
                    {
                        Notification.Alert("Failed to update user!", PopUp.AlertType.Error);
                    }
                    break;
            }
            
        }

        private void InitDrop()
        {
            dropOwner.DataSource = Model.Employee.GetDataTable();
            dropOwner.DisplayMember = "Fullname";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtusername.Text!=""&&txtpassword.Text!=""&&dropsecquestion.Text!=""&&dropOwner.Text!=""&&txtSecretAnswer.Text!="")
            {
                SaveData();
            }
            else
            {
                Notification.Alert("Please fill the required information!", PopUp.AlertType.Error);
            } 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Model.User.Delete(CurrentUser))
            {
                Notification.Alert("User deleted succesfully!", PopUp.AlertType.Success);
                FillDG();
            }
            else
            {
                Notification.Alert("failed to delete user!", PopUp.AlertType.Warning);  
            }
        }

        private void InitClear()
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtSecretAnswer.Clear();
            dropsecquestion.SelectedIndex = 0;
            dropOwner.SelectedIndex = 0;
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            _edit = EditMode.Edit;
            SwitchEditMode(_edit);
            btnconfirm.Text = "Update";
            PrepareRightData();
        }

        private void PrepareRightData()
        {
            txtusername.Text = CurrentUser.Username;
            txtpassword.Text = CurrentUser.Password;
            dropsecquestion.SelectedIndex = dropsecquestion.Items.IndexOf(CurrentUser.SecretQuestion);
            txtSecretAnswer.Text = CurrentUser.SecretAnswer;
            dropOwner.SelectedIndex = dropOwner.Items.IndexOf(Model.User.GetOwnerNameByID(CurrentUser.OwnerId));
        }

        private void dgUserAccount_SelectionChanged(object sender, EventArgs e)
        {
            int i = 0;
            try
            {
                i = Convert.ToInt32(Controller.Utilities.GetSelectedDatagridValue(dgUserAccount, "ID"));
            }
            catch (Exception)
            {
                i = 0;
            }
            if (i!=0)
            {
                CurrentUser = Model.User.Get(i);
                PrepareRightData();
            }
        }
    }
}
