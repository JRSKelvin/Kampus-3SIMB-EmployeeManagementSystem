using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeManagementSystem.Properties;

namespace EmployeeManagementSystem.Interface
{
    public partial class PopUp : Form
    {
        public PopUp()
        {
            InitializeComponent();
        }
        public enum AlertType
        {
            Success,
            Warning,
            Info,
            Error
        }

        private int x, y;

        public void setAlert(string message, PopUp.AlertType type)
        {
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string fname;

            for (int i = 1; i < 10; i++)
            {
                fname = "alert" + i.ToString();
                PopUp f = (PopUp)Application.OpenForms[fname];
                if (f == null)
                {
                    this.Name = fname;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.y = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i - 5 * i;
                    this.Location = new Point(this.x, this.y);
                    break;
                }
            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            switch (type)
            {
                case PopUp.AlertType.Success:
                    this.alertPic.Image = Resources.icons8_checkmark_52px;
                    this.BackColor = Color.FromArgb(42, 171, 160);
                    break;

                case PopUp.AlertType.Warning:
                    this.alertPic.Image = Resources.icons8_Warning_48px;
                    this.BackColor = Color.FromArgb(255, 179, 2);
                    break;

                case PopUp.AlertType.Error:
                    this.alertPic.Image = Resources.icons8_high_risk_40px;
                    this.BackColor = Color.FromArgb(255, 121, 70);
                    break;

                case PopUp.AlertType.Info:
                    this.alertPic.Image = Resources.icons8_info_48px;
                    this.BackColor = Color.FromArgb(71, 169, 248);
                    break;
            }

            this.TopMost = true;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            this.lblMsg.Text = message;
            this.Show();
            this.action = actionEnum.Start;
            this.timer1.Interval = 1;
            this.timer1.Start();
        }

        public enum actionEnum
        {
            Wait,
            Start,
            Close
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch (this.action)
            {
                case PopUp.actionEnum.Wait:
                    this.timer1.Interval = 5000;
                    this.action = PopUp.actionEnum.Close;
                    break;
                case PopUp.actionEnum.Start:
                    this.timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X)
                    {
                        this.Left--;
                    }
                    else
                    {
                        if (this.Opacity == 1.0)
                        {
                            this.action = PopUp.actionEnum.Wait;
                        }
                    }
                    break;
                case PopUp.actionEnum.Close:
                    this.timer1.Interval = 1;
                    this.Opacity -= 0.1;
                    this.Left -= 3;
                    if (base.Opacity == 0.0)
                    {
                        base.Close();
                    }
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.timer1.Interval = 1;
            this.action = PopUp.actionEnum.Close;
        }

        private void PopUp_Load(object sender, EventArgs e)
        {

        }

        private PopUp.actionEnum action;


    }
}
