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
    public partial class DeptUC : UserControl
    {
        private bool isLoaded = false;

        public enum Action
        {
            Create, Update, View
        }
        private Action _action;


        public DeptUC()
        {
        
        }

        public void InitObject(Action action)
        {
            if (!isLoaded)
            {
                InitializeComponent();
                isLoaded = true;
                _action = action;
                InitEdit(action);
                LoadDGDept();

            }
        }

        private void InitEdit(Action action)
        {
            switch (action)
            {
                case Action.Create:
                    txtdeptdesc.ReadOnly = false;
                    txtdeptname.ReadOnly = false;
                    break;
                case Action.Update:
                    txtdeptname.ReadOnly = false;
                    txtdeptdesc.ReadOnly = false;
                    break;
                case Action.View:
                    txtdeptdesc.ReadOnly = true;
                    txtdeptname.ReadOnly = true;
                    break;
            }
        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            _action = Action.Update;
            btnCreate.Enabled = false;
            btnDelete.Enabled = false;
            btnConfirm.Visible = true;
            btnConfirm.Text = "Revise Department";
            InitEdit(_action);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _action = Action.Create;
            btnAction.Enabled = false;
            btnDelete.Enabled = false;
            txtdeptname.Clear();
            txtdeptdesc.Clear();
            btnConfirm.Visible = true;
            InitEdit(_action);
            btnConfirm.Text = "Add department";
        }

        private void LoadDGDept()
        {
            dgDept.DataSource = Model.Department.GetDataTable();
        }

        private Model.Department deptcurr = null;

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            switch (_action)
            {
                case Action.Create:
                    Model.Department dept = new Model.Department();
                    dept.DeptName = txtdeptname.Text;
                    dept.DeptDesc = txtdeptdesc.Text;
                    if (Model.Department.Insert(dept))
                    {
                        Notification.Alert("Department added succesfully!", PopUp.AlertType.Success);
                        btnAction.Enabled = true;
                        btnDelete.Enabled = true;
                        btnConfirm.Visible = false;
                        LoadDGDept();
                        InitEdit(Action.View);
                    }
                    else
                    {
                        Notification.Alert("Something is wrong", PopUp.AlertType.Error);
                    }
                    break;
                case Action.Update:
                    if (deptcurr!=null)
                    {
                        if (Model.Department.update(deptcurr))
                        {
                            btnCreate.Enabled = true;
                            btnDelete.Enabled = true;
                            btnConfirm.Visible = false;
                            LoadDGDept();
                        }
                        else
                        {
                            Notification.Alert("Something is wrong", PopUp.AlertType.Error);
                        }
                    }
                    else
                    {
                        Notification.Alert("Something is wrong!", PopUp.AlertType.Warning);
                    }
                    break;
            }
        }
        private string oldName = "";
        private void dgDept_SelectionChanged(object sender, EventArgs e)
        {
            string i = "";
            try
            {
                i = Controller.Utilities.GetSelectedDatagridValue(dgDept, "Department Name");
            }
            catch (Exception)
            {
                i = "";
            }
            if (i!="")
            {
                deptcurr = Model.Department.Get(i);
                oldName = deptcurr.DeptName;
                txtdeptdesc.Text = deptcurr.DeptDesc;
                txtdeptname.Text = deptcurr.DeptName;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (oldName!=""&&dgDept.Rows.Count!=1)
            {
                if (Model.Department.Delete(oldName))
                {
                    Notification.Alert("Department deleted succesfully!", PopUp.AlertType.Success);
                    LoadDGDept();
                }
                else
                {
                    Notification.Alert("Failed to delete department!", PopUp.AlertType.Error);
                }
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }
    }
}
