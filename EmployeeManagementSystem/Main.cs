using EmployeeManagementSystem.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagementSystem.Interface;
using System.Windows.Forms;

namespace EmployeeManagementSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            UIController.Navigate(UIController.Controls.UpperPanel);
            UIController.Navigate(UIController.Controls.Login);
        }
    }
}
