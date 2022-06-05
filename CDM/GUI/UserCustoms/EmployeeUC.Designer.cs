
namespace GUI.UserControls
{
    partial class EmployeeUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SearchText = new Guna.UI2.WinForms.Guna2TextBox();
            this.RightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AddEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.EmployeeGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.EmployeeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeEmailID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EmployeeAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.SearchText);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(1457, 68);
            this.TopPanel.TabIndex = 3;
            // 
            // SearchText
            // 
            this.SearchText.BorderRadius = 15;
            this.SearchText.BorderThickness = 2;
            this.SearchText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchText.DefaultText = "";
            this.SearchText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchText.DisabledState.Parent = this.SearchText;
            this.SearchText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchText.FocusedState.Parent = this.SearchText;
            this.SearchText.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SearchText.HoverState.Parent = this.SearchText;
            this.SearchText.Location = new System.Drawing.Point(485, 14);
            this.SearchText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchText.Name = "SearchText";
            this.SearchText.PasswordChar = '\0';
            this.SearchText.PlaceholderText = "Tìm kiếm";
            this.SearchText.SelectedText = "";
            this.SearchText.ShadowDecoration.Parent = this.SearchText;
            this.SearchText.Size = new System.Drawing.Size(457, 39);
            this.SearchText.TabIndex = 0;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RightPanel.Controls.Add(this.AddEmployee);
            this.RightPanel.Controls.Add(this.EmployeeGridView);
            this.RightPanel.Location = new System.Drawing.Point(0, 77);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.ShadowDecoration.Parent = this.RightPanel;
            this.RightPanel.Size = new System.Drawing.Size(1457, 639);
            this.RightPanel.TabIndex = 5;
            // 
            // AddEmployee
            // 
            this.AddEmployee.BorderRadius = 15;
            this.AddEmployee.BorderThickness = 2;
            this.AddEmployee.CheckedState.Parent = this.AddEmployee;
            this.AddEmployee.CustomImages.Parent = this.AddEmployee;
            this.AddEmployee.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployee.ForeColor = System.Drawing.Color.White;
            this.AddEmployee.HoverState.Parent = this.AddEmployee;
            this.AddEmployee.Image = global::GUI.Properties.Resources.plus_sign;
            this.AddEmployee.Location = new System.Drawing.Point(628, 581);
            this.AddEmployee.Name = "AddEmployee";
            this.AddEmployee.ShadowDecoration.Parent = this.AddEmployee;
            this.AddEmployee.Size = new System.Drawing.Size(180, 45);
            this.AddEmployee.TabIndex = 2;
            this.AddEmployee.Text = "Thêm";
            this.AddEmployee.Click += new System.EventHandler(this.AddEmployee_Click);
            // 
            // EmployeeGridView
            // 
            this.EmployeeGridView.AllowUserToAddRows = false;
            this.EmployeeGridView.AllowUserToDeleteRows = false;
            this.EmployeeGridView.AllowUserToResizeColumns = false;
            this.EmployeeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.EmployeeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.EmployeeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmployeeGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.EmployeeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmployeeGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.EmployeeGridView.ColumnHeadersHeight = 30;
            this.EmployeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeID,
            this.EmployeeName,
            this.EmployeeGender,
            this.EmployeeMobile,
            this.EmployeeEmailID,
            this.EmployeeAddress,
            this.Username,
            this.Password,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeeGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.EmployeeGridView.EnableHeadersVisualStyles = false;
            this.EmployeeGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeGridView.Location = new System.Drawing.Point(48, 12);
            this.EmployeeGridView.MultiSelect = false;
            this.EmployeeGridView.Name = "EmployeeGridView";
            this.EmployeeGridView.RowHeadersVisible = false;
            this.EmployeeGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.EmployeeGridView.RowTemplate.Height = 30;
            this.EmployeeGridView.RowTemplate.ReadOnly = true;
            this.EmployeeGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.EmployeeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmployeeGridView.ShowCellErrors = false;
            this.EmployeeGridView.ShowCellToolTips = false;
            this.EmployeeGridView.ShowEditingIcon = false;
            this.EmployeeGridView.ShowRowErrors = false;
            this.EmployeeGridView.Size = new System.Drawing.Size(1355, 563);
            this.EmployeeGridView.TabIndex = 0;
            this.EmployeeGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.EmployeeGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeeGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeeGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeeGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeeGridView.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.EmployeeGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeeGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeeGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmployeeGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeeGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.EmployeeGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.EmployeeGridView.ThemeStyle.ReadOnly = false;
            this.EmployeeGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeeGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeeGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmployeeGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeGridView.ThemeStyle.RowsStyle.Height = 30;
            this.EmployeeGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeeGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeeGridView_CellClick);
            this.EmployeeGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.EmployeeGridView_CellPainting);
            // 
            // EmployeeID
            // 
            this.EmployeeID.DataPropertyName = "EmployeeID";
            this.EmployeeID.FillWeight = 25F;
            this.EmployeeID.HeaderText = "ID";
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.ReadOnly = true;
            // 
            // EmployeeName
            // 
            this.EmployeeName.DataPropertyName = "EmployeeName";
            this.EmployeeName.FillWeight = 125F;
            this.EmployeeName.HeaderText = "Tên";
            this.EmployeeName.Name = "EmployeeName";
            // 
            // EmployeeGender
            // 
            this.EmployeeGender.DataPropertyName = "EmployeeGender";
            this.EmployeeGender.FillWeight = 80F;
            this.EmployeeGender.HeaderText = "Giới tính";
            this.EmployeeGender.Name = "EmployeeGender";
            // 
            // EmployeeMobile
            // 
            this.EmployeeMobile.DataPropertyName = "EmployeeMobile";
            this.EmployeeMobile.HeaderText = "Số điện thoại";
            this.EmployeeMobile.Name = "EmployeeMobile";
            // 
            // EmployeeEmailID
            // 
            this.EmployeeEmailID.DataPropertyName = "EmployeeEmailID";
            this.EmployeeEmailID.FillWeight = 125F;
            this.EmployeeEmailID.HeaderText = "Email";
            this.EmployeeEmailID.Name = "EmployeeEmailID";
            // 
            // EmployeeAddress
            // 
            this.EmployeeAddress.DataPropertyName = "EmployeeAddress";
            this.EmployeeAddress.FillWeight = 150F;
            this.EmployeeAddress.HeaderText = "Địa chỉ";
            this.EmployeeAddress.Name = "EmployeeAddress";
            // 
            // Username
            // 
            this.Username.DataPropertyName = "Username";
            this.Username.HeaderText = "Tài khoản";
            this.Username.Name = "Username";
            // 
            // Password
            // 
            this.Password.DataPropertyName = "Password";
            this.Password.HeaderText = "Mật khẩu";
            this.Password.Name = "Password";
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.FillWeight = 30F;
            this.Edit.HeaderText = "Sửa";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 30F;
            this.Delete.HeaderText = "Xoá";
            this.Delete.Name = "Delete";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.EmployeeGridView;
            // 
            // EmployeeUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "EmployeeUC";
            this.Size = new System.Drawing.Size(1457, 716);
            this.TopPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2TextBox SearchText;
        private Guna.UI2.WinForms.Guna2Panel RightPanel;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeGridView;
        private Guna.UI2.WinForms.Guna2Button AddEmployee;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeName;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeEmailID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
