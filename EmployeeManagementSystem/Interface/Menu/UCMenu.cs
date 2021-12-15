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
    public partial class UCMenu : UserControl
    {
        private Image _img;

        public Image Image
        {
            get { return _img; }
            set { _img = value; pic.Image = value; }
        }
        private string _title;

        public string Title
        {
            get { return _title; }
            set { _title = value; lbltitle.Text = value;     }
        }
        public UIController.Controls ctrls { get; set; }
        public static UCMenu AddMenu(Image img, string title, UIController.Controls ctrl)
        {
            UCMenu menu = new UCMenu();
            menu.Image = img;
            menu.Title = title;
            menu.ctrls = ctrl;
            return menu;
        }

        public UCMenu()
        {
            InitializeComponent();
        }

        private void OnClick()
        {
            UIController.Navigate(this.ctrls);
        }

        private void UCMenu_Click(object sender, EventArgs e)
        {
            OnClick();
        }

        private void pic_Click(object sender, EventArgs e)
        {
            OnClick();

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {
            OnClick();

        }

        private void UCMenu_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
        }

        private void UCMenu_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.Gainsboro;
        }
    }
}
