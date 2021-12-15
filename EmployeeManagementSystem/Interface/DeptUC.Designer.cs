
namespace EmployeeManagementSystem.Interface
{
    partial class DeptUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbltitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAction = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.CtrlEmployeeView = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.btnConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.txtdeptdesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdeptname = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgDept = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnback = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.CtrlEmployeeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDept)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitle
            // 
            this.lbltitle.AutoSize = true;
            this.lbltitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitle.ForeColor = System.Drawing.Color.White;
            this.lbltitle.Location = new System.Drawing.Point(25, 19);
            this.lbltitle.Name = "lbltitle";
            this.lbltitle.Size = new System.Drawing.Size(357, 32);
            this.lbltitle.TabIndex = 1;
            this.lbltitle.Text = "Department Directory Service";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnAction);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.guna2VSeparator1);
            this.panel1.Controls.Add(this.CtrlEmployeeView);
            this.panel1.Controls.Add(this.dgDept);
            this.panel1.Location = new System.Drawing.Point(31, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 575);
            this.panel1.TabIndex = 2;
            // 
            // btnCreate
            // 
            this.btnCreate.Animated = true;
            this.btnCreate.AutoRoundedCorners = true;
            this.btnCreate.BorderRadius = 21;
            this.btnCreate.CheckedState.Parent = this.btnCreate;
            this.btnCreate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreate.CustomImages.Parent = this.btnCreate;
            this.btnCreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnCreate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.Color.Black;
            this.btnCreate.HoverState.Parent = this.btnCreate;
            this.btnCreate.Location = new System.Drawing.Point(53, 500);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.ShadowDecoration.Parent = this.btnCreate;
            this.btnCreate.Size = new System.Drawing.Size(137, 45);
            this.btnCreate.TabIndex = 20;
            this.btnCreate.Text = "Create";
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAction
            // 
            this.btnAction.Animated = true;
            this.btnAction.AutoRoundedCorners = true;
            this.btnAction.BorderRadius = 21;
            this.btnAction.CheckedState.Parent = this.btnAction;
            this.btnAction.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAction.CustomImages.Parent = this.btnAction;
            this.btnAction.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnAction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAction.ForeColor = System.Drawing.Color.Black;
            this.btnAction.HoverState.Parent = this.btnAction;
            this.btnAction.Location = new System.Drawing.Point(196, 500);
            this.btnAction.Name = "btnAction";
            this.btnAction.ShadowDecoration.Parent = this.btnAction;
            this.btnAction.Size = new System.Drawing.Size(137, 45);
            this.btnAction.TabIndex = 18;
            this.btnAction.Text = "Edit";
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Animated = true;
            this.btnDelete.AutoRoundedCorners = true;
            this.btnDelete.BorderRadius = 21;
            this.btnDelete.CheckedState.Parent = this.btnDelete;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.CustomImages.Parent = this.btnDelete;
            this.btnDelete.FillColor = System.Drawing.Color.Salmon;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.HoverState.Parent = this.btnDelete;
            this.btnDelete.Location = new System.Drawing.Point(339, 500);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.Parent = this.btnDelete;
            this.btnDelete.Size = new System.Drawing.Size(137, 45);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(585, 167);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 200);
            this.guna2VSeparator1.TabIndex = 1;
            // 
            // CtrlEmployeeView
            // 
            this.CtrlEmployeeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CtrlEmployeeView.BackColor = System.Drawing.Color.Transparent;
            this.CtrlEmployeeView.Controls.Add(this.btnConfirm);
            this.CtrlEmployeeView.Controls.Add(this.txtdeptdesc);
            this.CtrlEmployeeView.Controls.Add(this.lblFullName);
            this.CtrlEmployeeView.Controls.Add(this.label1);
            this.CtrlEmployeeView.Controls.Add(this.txtdeptname);
            this.CtrlEmployeeView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.CtrlEmployeeView.Location = new System.Drawing.Point(611, 22);
            this.CtrlEmployeeView.Name = "CtrlEmployeeView";
            this.CtrlEmployeeView.ShadowColor = System.Drawing.Color.Black;
            this.CtrlEmployeeView.Size = new System.Drawing.Size(586, 458);
            this.CtrlEmployeeView.TabIndex = 19;
            // 
            // btnConfirm
            // 
            this.btnConfirm.Animated = true;
            this.btnConfirm.AutoRoundedCorners = true;
            this.btnConfirm.BorderRadius = 21;
            this.btnConfirm.CheckedState.Parent = this.btnConfirm;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.CustomImages.Parent = this.btnConfirm;
            this.btnConfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.HoverState.Parent = this.btnConfirm;
            this.btnConfirm.Location = new System.Drawing.Point(276, 336);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.ShadowDecoration.Parent = this.btnConfirm;
            this.btnConfirm.Size = new System.Drawing.Size(137, 45);
            this.btnConfirm.TabIndex = 20;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtdeptdesc
            // 
            this.txtdeptdesc.Animated = true;
            this.txtdeptdesc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.txtdeptdesc.BorderRadius = 5;
            this.txtdeptdesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdeptdesc.DefaultText = "";
            this.txtdeptdesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdeptdesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdeptdesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdeptdesc.DisabledState.Parent = this.txtdeptdesc;
            this.txtdeptdesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdeptdesc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtdeptdesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdeptdesc.FocusedState.Parent = this.txtdeptdesc;
            this.txtdeptdesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeptdesc.ForeColor = System.Drawing.Color.White;
            this.txtdeptdesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdeptdesc.HoverState.Parent = this.txtdeptdesc;
            this.txtdeptdesc.Location = new System.Drawing.Point(184, 166);
            this.txtdeptdesc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdeptdesc.Multiline = true;
            this.txtdeptdesc.Name = "txtdeptdesc";
            this.txtdeptdesc.PasswordChar = '\0';
            this.txtdeptdesc.PlaceholderText = "Description";
            this.txtdeptdesc.ReadOnly = true;
            this.txtdeptdesc.SelectedText = "";
            this.txtdeptdesc.ShadowDecoration.Parent = this.txtdeptdesc;
            this.txtdeptdesc.Size = new System.Drawing.Size(341, 143);
            this.txtdeptdesc.TabIndex = 17;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(29, 114);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(140, 21);
            this.lblFullName.TabIndex = 14;
            this.lblFullName.Text = "Department Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Department Desc:";
            // 
            // txtdeptname
            // 
            this.txtdeptname.Animated = true;
            this.txtdeptname.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.txtdeptname.BorderRadius = 5;
            this.txtdeptname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdeptname.DefaultText = "";
            this.txtdeptname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtdeptname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtdeptname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdeptname.DisabledState.Parent = this.txtdeptname;
            this.txtdeptname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtdeptname.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtdeptname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdeptname.FocusedState.Parent = this.txtdeptname;
            this.txtdeptname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdeptname.ForeColor = System.Drawing.Color.White;
            this.txtdeptname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtdeptname.HoverState.Parent = this.txtdeptname;
            this.txtdeptname.Location = new System.Drawing.Point(184, 107);
            this.txtdeptname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtdeptname.Name = "txtdeptname";
            this.txtdeptname.PasswordChar = '\0';
            this.txtdeptname.PlaceholderText = "Department name";
            this.txtdeptname.ReadOnly = true;
            this.txtdeptname.SelectedText = "";
            this.txtdeptname.ShadowDecoration.Parent = this.txtdeptname;
            this.txtdeptname.Size = new System.Drawing.Size(341, 34);
            this.txtdeptname.TabIndex = 15;
            // 
            // dgDept
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgDept.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgDept.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDept.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgDept.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.dgDept.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgDept.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDept.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDept.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgDept.ColumnHeadersHeight = 20;
            this.dgDept.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDept.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgDept.EnableHeadersVisualStyles = false;
            this.dgDept.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDept.Location = new System.Drawing.Point(20, 22);
            this.dgDept.MultiSelect = false;
            this.dgDept.Name = "dgDept";
            this.dgDept.ReadOnly = true;
            this.dgDept.RowHeadersVisible = false;
            this.dgDept.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgDept.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDept.Size = new System.Drawing.Size(544, 458);
            this.dgDept.TabIndex = 1;
            this.dgDept.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgDept.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgDept.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgDept.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgDept.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgDept.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgDept.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.dgDept.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDept.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgDept.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgDept.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDept.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgDept.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgDept.ThemeStyle.HeaderStyle.Height = 20;
            this.dgDept.ThemeStyle.ReadOnly = true;
            this.dgDept.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgDept.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgDept.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgDept.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgDept.ThemeStyle.RowsStyle.Height = 22;
            this.dgDept.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgDept.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgDept.SelectionChanged += new System.EventHandler(this.dgDept_SelectionChanged);
            // 
            // btnback
            // 
            this.btnback.Animated = true;
            this.btnback.AutoRoundedCorners = true;
            this.btnback.BorderRadius = 21;
            this.btnback.CheckedState.Parent = this.btnback;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.CustomImages.Parent = this.btnback;
            this.btnback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.HoverState.Parent = this.btnback;
            this.btnback.Location = new System.Drawing.Point(1111, 10);
            this.btnback.Name = "btnback";
            this.btnback.ShadowDecoration.Parent = this.btnback;
            this.btnback.Size = new System.Drawing.Size(137, 45);
            this.btnback.TabIndex = 21;
            this.btnback.Text = "Back";
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // DeptUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbltitle);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DeptUC";
            this.Size = new System.Drawing.Size(1280, 675);
            this.panel1.ResumeLayout(false);
            this.CtrlEmployeeView.ResumeLayout(false);
            this.CtrlEmployeeView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDept)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltitle;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtdeptdesc;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtdeptname;
        private System.Windows.Forms.Label lblFullName;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2Button btnAction;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2ShadowPanel CtrlEmployeeView;
        private Guna.UI2.WinForms.Guna2DataGridView dgDept;
        private Guna.UI2.WinForms.Guna2Button btnConfirm;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnback;
    }
}
