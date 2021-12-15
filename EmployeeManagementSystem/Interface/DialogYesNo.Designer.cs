namespace EmployeeManagementSystem.Interface
{
    partial class DialogYesNo
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
            this.btnYes = new Guna.UI2.WinForms.Guna2Button();
            this.btnNo = new Guna.UI2.WinForms.Guna2Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.picDialog = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDialog)).BeginInit();
            this.SuspendLayout();
            // 
            // btnYes
            // 
            this.btnYes.Animated = true;
            this.btnYes.AutoRoundedCorners = true;
            this.btnYes.BorderRadius = 28;
            this.btnYes.CheckedState.Parent = this.btnYes;
            this.btnYes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYes.CustomImages.Parent = this.btnYes;
            this.btnYes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnYes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYes.ForeColor = System.Drawing.Color.Black;
            this.btnYes.HoverState.Parent = this.btnYes;
            this.btnYes.Location = new System.Drawing.Point(221, 562);
            this.btnYes.Name = "btnYes";
            this.btnYes.ShadowDecoration.Parent = this.btnYes;
            this.btnYes.Size = new System.Drawing.Size(286, 58);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "YES";
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Animated = true;
            this.btnNo.AutoRoundedCorners = true;
            this.btnNo.BorderRadius = 28;
            this.btnNo.CheckedState.Parent = this.btnNo;
            this.btnNo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNo.CustomImages.Parent = this.btnNo;
            this.btnNo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnNo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNo.ForeColor = System.Drawing.Color.Black;
            this.btnNo.HoverState.Parent = this.btnNo;
            this.btnNo.Location = new System.Drawing.Point(703, 562);
            this.btnNo.Name = "btnNo";
            this.btnNo.ShadowDecoration.Parent = this.btnNo;
            this.btnNo.Size = new System.Drawing.Size(286, 58);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "NO";
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(145, 32);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(65, 32);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Title";
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.White;
            this.lblSubtitle.Location = new System.Drawing.Point(146, 76);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(78, 25);
            this.lblSubtitle.TabIndex = 10;
            this.lblSubtitle.Text = "Subtitle";
            // 
            // picDialog
            // 
            this.picDialog.BackColor = System.Drawing.Color.Transparent;
            this.picDialog.Location = new System.Drawing.Point(452, 156);
            this.picDialog.Name = "picDialog";
            this.picDialog.Size = new System.Drawing.Size(307, 300);
            this.picDialog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDialog.TabIndex = 11;
            this.picDialog.TabStop = false;
            // 
            // DialogYesNo
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.picDialog);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.btnYes);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DialogYesNo";
            this.Size = new System.Drawing.Size(1280, 675);
            ((System.ComponentModel.ISupportInitialize)(this.picDialog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnYes;
        private Guna.UI2.WinForms.Guna2Button btnNo;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.PictureBox picDialog;
    }
}
