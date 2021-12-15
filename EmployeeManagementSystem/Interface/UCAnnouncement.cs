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
    public partial class UCAnnouncement : UserControl
    {
        private bool isLoaded = false;
        
        public UCAnnouncement()
        {

        }

        public void InitObject()
        {
            if (!isLoaded)
            {
                InitializeComponent();
                isLoaded = true;
            }
        }

        public enum EditMode
        { 
         Create, Edit, View
        }
        private EditMode _editmode = EditMode.View;
     
        
    }
}
