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

namespace EmployeeManagementSystem.Interface
{
    public partial class DialogYesNo : UserControl
    {
        private bool isloaded = false;
        private string _title;
        private string _yes;
        public string YesText
        {
            get { return _yes; }
            set { _yes = value; btnYes.Text = value; }
        }
        private string _no;
        public string NoText
        {
            get { return _no; }
            set { _no = value;btnNo.Text = value; }
        }
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }
        private string _subtitle;
        public string Subtitle
        {
            get { return _subtitle; }
            set { _subtitle = value; lblSubtitle.Text = value; }
        }
        private Image _imagedialog;
        public Image ImageDialog
        {
            get { return _imagedialog; }
            set { _imagedialog = value; picDialog.Image = value; }
        }
        public DialogYesNo()
        {

        }

        public void InitializeObject()
        {
            if (!isloaded)
            {
                InitializeComponent();
                isloaded = true;
            }

        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            Confirmation.Yes();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            Confirmation.No();
        }


    }
}
