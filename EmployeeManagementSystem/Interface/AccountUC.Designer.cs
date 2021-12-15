
namespace EmployeeManagementSystem.Interface
{
    partial class AccountUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnback = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCreate = new Guna.UI2.WinForms.Guna2Button();
            this.btnAction = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelete = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.CtrlEmployeeView = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblFullName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtusername = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgUserAccount = new Guna.UI2.WinForms.Guna2DataGridView();
            this.txtpassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSecretAnswer = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dropsecquestion = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnconfirm = new Guna.UI2.WinForms.Guna2Button();
            this.dropOwner = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.CtrlEmployeeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnback
            // 
            this.btnback.Animated = true;
            this.btnback.AutoRoundedCorners = true;
            this.btnback.BorderRadius = 18;
            this.btnback.CheckedState.Parent = this.btnback;
            this.btnback.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnback.CustomImages.Parent = this.btnback;
            this.btnback.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnback.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnback.ForeColor = System.Drawing.Color.Black;
            this.btnback.HoverState.Parent = this.btnback;
            this.btnback.Location = new System.Drawing.Point(1133, 3);
            this.btnback.Name = "btnback";
            this.btnback.ShadowDecoration.Parent = this.btnback;
            this.btnback.Size = new System.Drawing.Size(134, 38);
            this.btnback.TabIndex = 22;
            this.btnback.Text = "Back";
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCreate);
            this.panel1.Controls.Add(this.btnAction);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.guna2VSeparator1);
            this.panel1.Controls.Add(this.CtrlEmployeeView);
            this.panel1.Controls.Add(this.dgUserAccount);
            this.panel1.Location = new System.Drawing.Point(17, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1217, 575);
            this.panel1.TabIndex = 23;
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
            this.CtrlEmployeeView.Controls.Add(this.label4);
            this.CtrlEmployeeView.Controls.Add(this.dropOwner);
            this.CtrlEmployeeView.Controls.Add(this.btnconfirm);
            this.CtrlEmployeeView.Controls.Add(this.label3);
            this.CtrlEmployeeView.Controls.Add(this.dropsecquestion);
            this.CtrlEmployeeView.Controls.Add(this.txtSecretAnswer);
            this.CtrlEmployeeView.Controls.Add(this.label2);
            this.CtrlEmployeeView.Controls.Add(this.txtpassword);
            this.CtrlEmployeeView.Controls.Add(this.lblFullName);
            this.CtrlEmployeeView.Controls.Add(this.label1);
            this.CtrlEmployeeView.Controls.Add(this.txtusername);
            this.CtrlEmployeeView.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.CtrlEmployeeView.Location = new System.Drawing.Point(611, 23);
            this.CtrlEmployeeView.Name = "CtrlEmployeeView";
            this.CtrlEmployeeView.ShadowColor = System.Drawing.Color.Black;
            this.CtrlEmployeeView.Size = new System.Drawing.Size(586, 458);
            this.CtrlEmployeeView.TabIndex = 19;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(29, 73);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(81, 21);
            this.lblFullName.TabIndex = 14;
            this.lblFullName.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "Password:";
            // 
            // txtusername
            // 
            this.txtusername.Animated = true;
            this.txtusername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.txtusername.BorderRadius = 5;
            this.txtusername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtusername.DefaultText = "";
            this.txtusername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtusername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtusername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.DisabledState.Parent = this.txtusername;
            this.txtusername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtusername.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtusername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.FocusedState.Parent = this.txtusername;
            this.txtusername.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.ForeColor = System.Drawing.Color.White;
            this.txtusername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtusername.HoverState.Parent = this.txtusername;
            this.txtusername.Location = new System.Drawing.Point(149, 73);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtusername.Name = "txtusername";
            this.txtusername.PasswordChar = '\0';
            this.txtusername.PlaceholderText = "Username";
            this.txtusername.ReadOnly = true;
            this.txtusername.SelectedText = "";
            this.txtusername.ShadowDecoration.Parent = this.txtusername;
            this.txtusername.Size = new System.Drawing.Size(341, 34);
            this.txtusername.TabIndex = 15;
            // 
            // dgUserAccount
            // 
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgUserAccount.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgUserAccount.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgUserAccount.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgUserAccount.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.dgUserAccount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgUserAccount.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgUserAccount.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgUserAccount.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgUserAccount.ColumnHeadersHeight = 20;
            this.dgUserAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgUserAccount.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgUserAccount.EnableHeadersVisualStyles = false;
            this.dgUserAccount.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgUserAccount.Location = new System.Drawing.Point(20, 22);
            this.dgUserAccount.MultiSelect = false;
            this.dgUserAccount.Name = "dgUserAccount";
            this.dgUserAccount.ReadOnly = true;
            this.dgUserAccount.RowHeadersVisible = false;
            this.dgUserAccount.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgUserAccount.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgUserAccount.Size = new System.Drawing.Size(544, 458);
            this.dgUserAccount.TabIndex = 1;
            this.dgUserAccount.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgUserAccount.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgUserAccount.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgUserAccount.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgUserAccount.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgUserAccount.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgUserAccount.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.dgUserAccount.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgUserAccount.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgUserAccount.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgUserAccount.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgUserAccount.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgUserAccount.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgUserAccount.ThemeStyle.HeaderStyle.Height = 20;
            this.dgUserAccount.ThemeStyle.ReadOnly = true;
            this.dgUserAccount.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgUserAccount.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgUserAccount.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgUserAccount.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgUserAccount.ThemeStyle.RowsStyle.Height = 22;
            this.dgUserAccount.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgUserAccount.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgUserAccount.SelectionChanged += new System.EventHandler(this.dgUserAccount_SelectionChanged);
            // 
            // txtpassword
            // 
            this.txtpassword.Animated = true;
            this.txtpassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.txtpassword.BorderRadius = 5;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.DefaultText = "";
            this.txtpassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtpassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtpassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.DisabledState.Parent = this.txtpassword;
            this.txtpassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtpassword.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtpassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.FocusedState.Parent = this.txtpassword;
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.White;
            this.txtpassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtpassword.HoverState.Parent = this.txtpassword;
            this.txtpassword.Location = new System.Drawing.Point(149, 131);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '\0';
            this.txtpassword.PlaceholderText = "Password";
            this.txtpassword.ReadOnly = true;
            this.txtpassword.SelectedText = "";
            this.txtpassword.ShadowDecoration.Parent = this.txtpassword;
            this.txtpassword.Size = new System.Drawing.Size(341, 34);
            this.txtpassword.TabIndex = 21;
            // 
            // txtSecretAnswer
            // 
            this.txtSecretAnswer.Animated = true;
            this.txtSecretAnswer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(163)))), ((int)(((byte)(101)))));
            this.txtSecretAnswer.BorderRadius = 5;
            this.txtSecretAnswer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSecretAnswer.DefaultText = "";
            this.txtSecretAnswer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSecretAnswer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSecretAnswer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecretAnswer.DisabledState.Parent = this.txtSecretAnswer;
            this.txtSecretAnswer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSecretAnswer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(71)))), ((int)(((byte)(94)))));
            this.txtSecretAnswer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecretAnswer.FocusedState.Parent = this.txtSecretAnswer;
            this.txtSecretAnswer.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretAnswer.ForeColor = System.Drawing.Color.White;
            this.txtSecretAnswer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSecretAnswer.HoverState.Parent = this.txtSecretAnswer;
            this.txtSecretAnswer.Location = new System.Drawing.Point(149, 232);
            this.txtSecretAnswer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSecretAnswer.Name = "txtSecretAnswer";
            this.txtSecretAnswer.PasswordChar = '\0';
            this.txtSecretAnswer.PlaceholderText = "Answer";
            this.txtSecretAnswer.ReadOnly = true;
            this.txtSecretAnswer.SelectedText = "";
            this.txtSecretAnswer.ShadowDecoration.Parent = this.txtSecretAnswer;
            this.txtSecretAnswer.Size = new System.Drawing.Size(341, 34);
            this.txtSecretAnswer.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(29, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 21);
            this.label2.TabIndex = 22;
            this.label2.Text = "Secret Answer";
            // 
            // dropsecquestion
            // 
            this.dropsecquestion.Animated = true;
            this.dropsecquestion.AutoRoundedCorners = true;
            this.dropsecquestion.BackColor = System.Drawing.Color.Transparent;
            this.dropsecquestion.BorderRadius = 17;
            this.dropsecquestion.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropsecquestion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropsecquestion.Enabled = false;
            this.dropsecquestion.FillColor = System.Drawing.Color.Coral;
            this.dropsecquestion.FocusedColor = System.Drawing.Color.Empty;
            this.dropsecquestion.FocusedState.Parent = this.dropsecquestion;
            this.dropsecquestion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropsecquestion.ForeColor = System.Drawing.Color.Black;
            this.dropsecquestion.FormattingEnabled = true;
            this.dropsecquestion.HoverState.Parent = this.dropsecquestion;
            this.dropsecquestion.ItemHeight = 30;
            this.dropsecquestion.Items.AddRange(new object[] {
            "What is the name of your first pet?",
            "What was your first car?",
            "What elementary school did you attend?",
            "What is the name of the town where you were born?",
            "What is your mother name?"});
            this.dropsecquestion.ItemsAppearance.Parent = this.dropsecquestion;
            this.dropsecquestion.Location = new System.Drawing.Point(149, 181);
            this.dropsecquestion.Name = "dropsecquestion";
            this.dropsecquestion.ShadowDecoration.Parent = this.dropsecquestion;
            this.dropsecquestion.Size = new System.Drawing.Size(341, 36);
            this.dropsecquestion.StartIndex = 0;
            this.dropsecquestion.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(29, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 21);
            this.label3.TabIndex = 28;
            this.label3.Text = "Secret Question";
            // 
            // btnconfirm
            // 
            this.btnconfirm.Animated = true;
            this.btnconfirm.AutoRoundedCorners = true;
            this.btnconfirm.BorderRadius = 21;
            this.btnconfirm.CheckedState.Parent = this.btnconfirm;
            this.btnconfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfirm.CustomImages.Parent = this.btnconfirm;
            this.btnconfirm.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.btnconfirm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconfirm.ForeColor = System.Drawing.Color.Black;
            this.btnconfirm.HoverState.Parent = this.btnconfirm;
            this.btnconfirm.Location = new System.Drawing.Point(351, 341);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.ShadowDecoration.Parent = this.btnconfirm;
            this.btnconfirm.Size = new System.Drawing.Size(137, 45);
            this.btnconfirm.TabIndex = 29;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dropOwner
            // 
            this.dropOwner.Animated = true;
            this.dropOwner.AutoRoundedCorners = true;
            this.dropOwner.BackColor = System.Drawing.Color.Transparent;
            this.dropOwner.BorderRadius = 17;
            this.dropOwner.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropOwner.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropOwner.Enabled = false;
            this.dropOwner.FillColor = System.Drawing.Color.Coral;
            this.dropOwner.FocusedColor = System.Drawing.Color.Empty;
            this.dropOwner.FocusedState.Parent = this.dropOwner;
            this.dropOwner.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropOwner.ForeColor = System.Drawing.Color.Black;
            this.dropOwner.FormattingEnabled = true;
            this.dropOwner.HoverState.Parent = this.dropOwner;
            this.dropOwner.ItemHeight = 30;
            this.dropOwner.ItemsAppearance.Parent = this.dropOwner;
            this.dropOwner.Location = new System.Drawing.Point(147, 280);
            this.dropOwner.Name = "dropOwner";
            this.dropOwner.ShadowDecoration.Parent = this.dropOwner;
            this.dropOwner.Size = new System.Drawing.Size(341, 36);
            this.dropOwner.StartIndex = 0;
            this.dropOwner.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(29, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 31;
            this.label4.Text = "Owner";
            // 
            // AccountUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.panel1);
            this.Name = "AccountUC";
            this.Size = new System.Drawing.Size(1280, 611);
            this.panel1.ResumeLayout(false);
            this.CtrlEmployeeView.ResumeLayout(false);
            this.CtrlEmployeeView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgUserAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnback;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCreate;
        private Guna.UI2.WinForms.Guna2Button btnAction;
        private Guna.UI2.WinForms.Guna2Button btnDelete;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2ShadowPanel CtrlEmployeeView;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtusername;
        private Guna.UI2.WinForms.Guna2DataGridView dgUserAccount;
        private Guna.UI2.WinForms.Guna2TextBox txtSecretAnswer;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtpassword;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox dropsecquestion;
        private Guna.UI2.WinForms.Guna2Button btnconfirm;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox dropOwner;
    }
}
