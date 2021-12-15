
namespace EmployeeManagementSystem.Interface
{
    partial class AnnouncementUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Elipser = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblcontent = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblbyon = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // Elipser
            // 
            this.Elipser.TargetControl = this;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::EmployeeManagementSystem.Properties.Resources.announcethum1;
            this.pictureBox3.Location = new System.Drawing.Point(201, 54);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(37, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // lblcontent
            // 
            this.lblcontent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcontent.ForeColor = System.Drawing.Color.Black;
            this.lblcontent.Location = new System.Drawing.Point(13, 4);
            this.lblcontent.Name = "lblcontent";
            this.lblcontent.Size = new System.Drawing.Size(213, 65);
            this.lblcontent.TabIndex = 8;
            this.lblcontent.Text = "Last Modified:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 100);
            this.panel1.TabIndex = 9;
            // 
            // lblbyon
            // 
            this.lblbyon.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbyon.ForeColor = System.Drawing.Color.Black;
            this.lblbyon.Location = new System.Drawing.Point(16, 75);
            this.lblbyon.Name = "lblbyon";
            this.lblbyon.Size = new System.Drawing.Size(170, 18);
            this.lblbyon.TabIndex = 10;
            this.lblbyon.Text = "On: By:";
            // 
            // AnnouncementUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblbyon);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblcontent);
            this.Name = "AnnouncementUC";
            this.Size = new System.Drawing.Size(241, 96);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse Elipser;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblbyon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcontent;
    }
}
