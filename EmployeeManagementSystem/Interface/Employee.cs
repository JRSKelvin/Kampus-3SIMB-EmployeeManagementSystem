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
using EmployeeManagementSystem.Model;
using EmployeeManagementSystem.Properties;
using Guna.UI2.WinForms;
using Telerik.WinControls.FileDialogs;

namespace EmployeeManagementSystem.Interface
{
    public partial class Employee : UserControl
    {
        private bool isLoad = false, isSaved = false;
        private Model.Employee CurrentEmployee = null;
        private OpenFileDialog opfPicEmployee = null;
        private Int64 idCurrEmployee = 0;
        private string picpath = null;
        public Employee()
        {

        }
        public void InitializeObject(state state)
        {
            if(isLoad)
            {

            }
            else
            {
                InitializeComponent();
                InitData();
                InitDropBox();
                NavigateCreate(stateCreate.personal);
            }
            Navigate(state);
            isLoad = true;
        }

        private void InitDropBox()
        {
            eDropDept.DataSource = Model.Department.GetDataTable();
            eDropDept.DisplayMember = "Department Name";
        }

        public enum state { View, Create, Update, Detailed}
        public enum stateCreate { personal, document }
        private stateCreate _stateCreate;
        private state _state;

        private void InitDGDocument()
        {
            dgDocument.DataSource = Model.Documents.GetDataTable(CurrentEmployee.idEmployee);
            if (dgDocument.Rows.Count<=0)
            {
                lblnodocs.Visible = true;
                dgDocument.Visible = false;
            }
            else
            {
                lblnodocs.Visible = false;
                dgDocument.Visible = true;

            }
        }

        private void NavigateCreate(stateCreate state)
        {
            _stateCreate = state;
            switch (state)
            {
                case stateCreate.personal:
                    CtrPersonal.BringToFront();
                    btnPersonal.FillColor = Color.Black;
                    btnPersonal.ForeColor = Color.White;
                    btnDocuments.FillColor = Color.White;
                    btnDocuments.ForeColor = Color.Black;
                    break;
                case stateCreate.document:
                    CtrlDocuments.BringToFront();
                    InitDGDocument();
                    btnDocuments.FillColor = Color.Black;
                    btnDocuments.ForeColor = Color.White;
                    btnPersonal.FillColor = Color.White;
                    btnPersonal.ForeColor = Color.Black;
                    break;
            }
        }

        private void InitData()
        {
            dgEmployee.DataSource = Model.Employee.GetDataTable();
            if (dgEmployee.Rows.Count<1)
            {
                panelnotemployee.Visible = true;
                panelnotemployee.BringToFront();
                dgEmployee.Visible = false;
            }
            else
            {
                panelnotemployee.Visible = false;
                panelnotemployee.SendToBack();
                dgEmployee.Visible = true;
                CtrlEmployeeView.BringToFront();
            }
        }

        private void Navigate(state state)
        {
            _state = state;
            switch (state)
            {
                case state.View:
                    CtrlEmployeeView.BringToFront();
                    //btnNewRecord.FillColor = Color.White;
                    break;
                case state.Create:
                    UIController.ResetControl(CtrPersonal);
                    UIController.ResetControl(CtrlDocuments);
                    eDropDept.SelectedIndex = 0;
                    CtrCreateUpdate.Visible = true;
                    CtrCreateUpdate.BringToFront();
                    CurrentEmployee = null; 
                    NavigateCreate(stateCreate.personal);
                    isSaved = false;
                    break;
                case state.Update:
                    InitEmployee();
                    CtrCreateUpdate.BringToFront();
                    CtrCreateUpdate.Visible = true;
                    isSaved = true;
                    break;
                case state.Detailed:

                    break;
            }
        }
        private void InitEmployee()
        {

            eTxtFname.Text = CurrentEmployee.FirstName;
            eTxtLname.Text = CurrentEmployee.LastName;
            eMobile.Text = CurrentEmployee.Mobile;
            try
            {
                eDropDept.SelectedIndex = eDropDept.Items.IndexOf(CurrentEmployee.Department);
            }
            catch (Exception)
            {
                eDropDept.SelectedIndex = 0;
            }
            eJobTitle.Text = CurrentEmployee.JobTitle;
            ePic.Image = picEmp.Image;
            eAddress.Text = CurrentEmployee.ResAddress;
            ePostCode.Text = CurrentEmployee.ResPostCode;
            eHomePhone.Text = CurrentEmployee.HomePhone;
            eNik.Text = CurrentEmployee.Nik;
            eDesc.Text = CurrentEmployee.Desc;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Navigate(state.Create);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            InitDGDocument();
            Navigate(state.Update);
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            NavigateCreate(stateCreate.personal);
        }
        private void btnDocuments_Click(object sender, EventArgs e)
        {
            NavigateCreate(stateCreate.document);
        }

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            this.SendToBack();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (CheckForDataIncomplete())
            {
                SaveEmployee(CurrentEmployee);
            }
            else
            {
                Notification.Alert("Please fill the required field!", PopUp.AlertType.Error);
            }
        }
        private bool CheckForDataIncomplete()
        {
            if (eTxtFname.Text!="" &&  eMobile.Text != "" && eNik.Text != "" && eAddress.Text != "")
            {
                if (CurrentEmployee==null)
                {
                    CurrentEmployee = new Model.Employee();
                    CurrentEmployee.FirstName = eTxtFname.Text;
                    CurrentEmployee.LastName = eTxtLname.Text;
                    CurrentEmployee.ResAddress = eAddress.Text;
                    CurrentEmployee.Mobile = eMobile.Text;
                    CurrentEmployee.JobTitle = eJobTitle.Text;
                    CurrentEmployee.Department = eDropDept.Text;
                    CurrentEmployee.ResPostCode = ePostCode.Text;
                    CurrentEmployee.HomePhone = eHomePhone.Text;
                    CurrentEmployee.Nik = eNik.Text;
                    CurrentEmployee.Desc = eDesc.Text;
                }
                else
                {

                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ResetState()
        {
            isSaved = false;
            CurrentEmployee = null;
            UIController.ResetControl(CtrPersonal);
            opfPicEmployee = null;
            picpath = null;
            ePic.Image = Resources.Anonym;
        }
        private void CheckForPicture()
        {
            if (opfPicEmployee!=null)
            {
                string path = Utilities.GetFileDbLocationString(Utilities.LocType.Photo, idCurrEmployee.ToString(), opfPicEmployee);
                if (picpath != null)
                {
                    if (!isSaved)
                    {
                        Utilities.WorkerFire(Utilities.WorkerProcess.CopyFile, new string[2] { picpath, path });
                    }
                    else
                    {
                        UpdatePhoto();
                    }
                }
            }
        }
        private void UpdatePhoto()
        {
            string path = Utilities.GetFileDbLocationString(Utilities.LocType.Photo, idCurrEmployee.ToString(), opfPicEmployee);
            CurrentEmployee.picLocation = path;
            if (Model.Employee.UpdatePhoto(CurrentEmployee))
            {
                Utilities.WorkerFire(Utilities.WorkerProcess.CopyFile, new string[2] { picpath, path });
                Notification.Alert("Picture updated!", PopUp.AlertType.Success);
            }
        }
        private void SaveEmployee(Model.Employee e)
        {
            if (!isSaved)
            {
                CheckForPicture();
                //insert
                if (Model.Employee.Insert(e))
                {
                    Notification.Alert("Employee Succesfully Recorded!", PopUp.AlertType.Success);
                    ResetState();
                    InitData();
                }
                else
                {
                    Notification.Alert("Failed to insert employee!", PopUp.AlertType.Error);
                }
            }
            else
            {
                //update    
                if (Model.Employee.Update(e))
                {
                    Notification.Alert("Employee Data Revised succesfully!", PopUp.AlertType.Success);
                    CheckForPicture();
                    InitData();
                }
                else
                {
                    Notification.Alert("Failed to revise employee data! Please Try Again!", PopUp.AlertType.Error);
                }
            }
        }

        private void ePic_Click(object sender, EventArgs e)
        {
            opfPicEmployee = Utilities.OpenImage(ePic);
            if (opfPicEmployee!=null)
            {
                if (opfPicEmployee.FileName != null && opfPicEmployee.FileName != "")
                {
                    picpath = opfPicEmployee.FileName;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgEmployee.Rows.Count<=0)
            {
                Notification.Alert("Cannot delete root account!", PopUp.AlertType.Error);
            }
            else
            {
                if (Model.Employee.Delete(CurrentEmployee.idEmployee))
                {
                    Notification.Alert("Selected employee has been deleted succesfully", PopUp.AlertType.Success);
                    InitData();
                }
                else
                {
                    Notification.Alert("Failed to delete selected employee, please try again!", PopUp.AlertType.Error);
                }
            }
        }
        private void dgEmployee_SelectionChanged(object sender, EventArgs e)
        {
            Int64 i = 0;
            try
            {
                i = Convert.ToInt64(Utilities.GetSelectedDatagridValue(dgEmployee, "idemployee"));
                idCurrEmployee = i;
            }
            catch (Exception)
            {
                i = 0;
            }
            if (i!=null&&i!=0)
            {
                CurrentEmployee = Model.Employee.Get(i);
                txtFullname.Text = CurrentEmployee.FullName;
                txtAddress.Text = CurrentEmployee.ResAddress;
                txtContact.Text = CurrentEmployee.Mobile;
                txtDept.Text = CurrentEmployee.Department;
                txtJobTitle.Text = CurrentEmployee.JobTitle;
                picEmp.Image = Utilities.GetImage(CurrentEmployee.picLocation);
            }
        }

        private void btnViewDetailed_Click(object sender, EventArgs e)
        {

        }

        OpenFileDialog DocumentPath = null;

        private void UploadDocument()
        {
            DocumentPath = Utilities.OpenFile("Document Files(*.JPG; *.PNG; *.JPEG; *.PDF; *.DOCX; *.DOC; *.XLSX;) | *.JPG; *.PNG; *.JPEG; *.PDF; *.DOCX; *.DOC; *.XLSX; | All Files (*.*) | *.*");
            txtDocsPath.Text = DocumentPath.FileName;
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {
                Notification.Alert("Please save the employee before uploading document!", PopUp.AlertType.Error);
            }
            else
            {
                UploadDocument();
            }
        }

        private void btnUploadRecord_Click(object sender, EventArgs e)
        {
            if (!isSaved)
            {

                Notification.Alert("We don't know where to upload it\nPlease save student data first and retry again", PopUp.AlertType.Warning);
            }
            else
            {
                if (DocumentPath == null)
                {
                    Notification.Alert("Hey, you haven't upload anything, wakey wakey", PopUp.AlertType.Warning);
                }
                else
                {
                    if (DocumentPath.FileName == "" || DocumentPath.FileName == null)
                    {
                        Notification.Alert("Hey, you haven't upload anything, wakey wakey", PopUp.AlertType.Warning);

                    }
                    else
                    {
                        UploadDocuments();
                        btnUploadRecord.Enabled = false;

                    }
                }
            }
        }

        private void UploadDocuments()
        {
            btnUpload.Enabled = false;
            dropDocsType.Enabled = false;
            btnUploadRecord.Enabled = false;
            ProgressCopy.Visible = true;
            lblstat.Visible = true;
            lblpleasewait.Visible = true;
            picUploading.Visible = true;
            string dbString = Utilities.GetFileDbLocationString(Utilities.LocationType.EmployeeDocument, $"{CurrentEmployee.idEmployee.ToString()}_{dropDocsType.SelectedItem}_{txtDocsName.Text}", DocumentPath);
            Utilities.WorkerFire(Utilities.WorkerProcess.CopyFile, new string[2] { DocumentPath.FileName, dbString });
            Utilities.workerparam.ProgressChanged += Workerparam_ProgressChanged;
            if (Model.Documents.Insert(new string[4] { dbString, CurrentEmployee.idEmployee.ToString(), dropDocsType.SelectedItem.ToString(), txtDocsName.Text }))
            {
                Notification.Alert("Data is valid\nnow we're writing data to the server", PopUp.AlertType.Info);
            }
            else
            {
                Notification.Alert("Failed to upload document :(", PopUp.AlertType.Error);
            }
        }

        private void Workerparam_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblstat.Text = $"{e.ProgressPercentage} %";
            ProgressCopy.Value = e.ProgressPercentage;
            if (ProgressCopy.Value == 100)
            {
                Notification.Alert("We finished uploading your file\nNow you can upload some document again!", PopUp.AlertType.Success);
                UploadClear();
                InitDGDocument();
            }
        }

        private void UploadClear()
        {
            DocumentPath = null;
            txtDocsPath.Text = "";
            dropDocsType.Enabled = true;
            try
            {

            }
            catch (Exception)
            {

            }
            txtDocsName.Text = "";
            btnUpload.Enabled = true;
            txtDocsName.Enabled = true;
            btnUploadRecord.Enabled = true;
            lblstat.Visible = false;
            ProgressCopy.Visible = false;
            ProgressCopy.Value = 0;
            lblpleasewait.Visible = false;
            picUploading.Visible = false;
        }



        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (CurrentDocs!=0)
            {
                if (Model.Documents.Delete(CurrentDocs))
                {
                    Notification.Alert("Document deleted succesfully!", PopUp.AlertType.Success);
                    InitDGDocument();
                }
                else
                {
                    Notification.Alert("Failed to delete document!", PopUp.AlertType.Error);

                }
            }
            else
            {

                Notification.Alert("Failed to delete document!", PopUp.AlertType.Error);
            }
            
        }

        private int CurrentDocs = 0;

        private void dgDocument_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                CurrentDocs = Convert.ToInt32(Controller.Utilities.GetSelectedDatagridValue(dgDocument, "iddocs"));
            }
            catch (Exception)
            {
                CurrentDocs = 0;
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            string path = Utilities.GetSelectedDatagridValue(dgDocument, "docslocation");
            if (path == "" || path == null)
            {
                Notification.Alert("There is nothing to open", PopUp.AlertType.Warning);
            }
            else
            {
                Notification.Alert("We're finding the document on the server...", PopUp.AlertType.Info);
                Utilities.WorkerFire(Utilities.WorkerProcess.OpenFileNewThread, new string[1] { path });
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Navigate(state.View);
        }
    }
}
