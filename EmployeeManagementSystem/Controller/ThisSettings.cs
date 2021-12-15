using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeManagementSystem.Controller
{
    public class ThisSettings
    {
        #region Default
        public enum Theme
        {
            Dark, Light
        }
        public static Color Dark = Color.FromArgb(34, 40, 49);
        public static Color DarkSubtle = Color.FromArgb(48, 71, 94);
        public static Color DarkLight = Color.FromArgb(242, 163, 101);
        public static Color DarkVeryLight = Color.FromArgb(236, 236, 236);
        private static Color _backcolor;
        public static Color BackColor
        {
            get { return _backcolor; }
            set { _backcolor = value; }
        }

        #endregion
        public ThisSettings()
        {

        }
        
        public static void SetBackColor(UserControl ctrl)
        {
            ctrl.BackColor = BackColor;
        }

        public static void SetTheme(Theme theme, UserControl ctrl)
        {
            switch (theme)
            {
                case Theme.Dark:
                    ctrl.BackColor = Color.FromArgb(34, 40, 49);
                    break;
                case Theme.Light:

                    break;
                default:
                    break;
            }
        }

    }
}
