
namespace GUI.UserControls
{
    partial class CustomerUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SearchText = new Guna.UI2.WinForms.Guna2TextBox();
            this.RightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.AddCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerNationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerDateofbirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerIndentification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerChange = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CustomerDelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TopPanel.SuspendLayout();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).BeginInit();
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
            this.SearchText.TabIndex = 1;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RightPanel.Controls.Add(this.AddCustomer);
            this.RightPanel.Controls.Add(this.CustomerGridView);
            this.RightPanel.Location = new System.Drawing.Point(0, 77);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.ShadowDecoration.Parent = this.RightPanel;
            this.RightPanel.Size = new System.Drawing.Size(1457, 639);
            this.RightPanel.TabIndex = 4;
            // 
            // AddCustomer
            // 
            this.AddCustomer.BorderRadius = 15;
            this.AddCustomer.BorderThickness = 2;
            this.AddCustomer.CheckedState.Parent = this.AddCustomer;
            this.AddCustomer.CustomImages.Parent = this.AddCustomer;
            this.AddCustomer.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddCustomer.ForeColor = System.Drawing.Color.White;
            this.AddCustomer.HoverState.Parent = this.AddCustomer;
            this.AddCustomer.Image = global::GUI.Properties.Resources.plus_sign;
            this.AddCustomer.Location = new System.Drawing.Point(628, 581);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.ShadowDecoration.Parent = this.AddCustomer;
            this.AddCustomer.Size = new System.Drawing.Size(180, 45);
            this.AddCustomer.TabIndex = 1;
            this.AddCustomer.Text = "Thêm";
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // CustomerGridView
            // 
            this.CustomerGridView.AllowUserToAddRows = false;
            this.CustomerGridView.AllowUserToDeleteRows = false;
            this.CustomerGridView.AllowUserToResizeColumns = false;
            this.CustomerGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.CustomerGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CustomerGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustomerGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.CustomerGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CustomerGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.CustomerGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerGridView.ColumnHeadersHeight = 30;
            this.CustomerGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CustomerGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.CustomerName,
            this.CustomerMobile,
            this.CustomerAddress,
            this.CustomerNationality,
            this.CustomerDateofbirth,
            this.CustomerGender,
            this.CustomerIndentification,
            this.CustomerChange,
            this.CustomerDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.CustomerGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.CustomerGridView.EnableHeadersVisualStyles = false;
            this.CustomerGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGridView.Location = new System.Drawing.Point(48, 12);
            this.CustomerGridView.MultiSelect = false;
            this.CustomerGridView.Name = "CustomerGridView";
            this.CustomerGridView.RowHeadersVisible = false;
            this.CustomerGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.CustomerGridView.RowTemplate.Height = 30;
            this.CustomerGridView.RowTemplate.ReadOnly = true;
            this.CustomerGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.CustomerGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustomerGridView.ShowCellErrors = false;
            this.CustomerGridView.ShowCellToolTips = false;
            this.CustomerGridView.ShowEditingIcon = false;
            this.CustomerGridView.ShowRowErrors = false;
            this.CustomerGridView.Size = new System.Drawing.Size(1355, 563);
            this.CustomerGridView.TabIndex = 0;
            this.CustomerGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.CustomerGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.CustomerGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.CustomerGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.CustomerGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.CustomerGridView.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.CustomerGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CustomerGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.CustomerGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.CustomerGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.CustomerGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.CustomerGridView.ThemeStyle.ReadOnly = false;
            this.CustomerGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.CustomerGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.CustomerGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.CustomerGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGridView.ThemeStyle.RowsStyle.Height = 30;
            this.CustomerGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.CustomerGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.CustomerGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CustomerGridView_CellClick);
            this.CustomerGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.CustomerGridView_CellPainting);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.FillWeight = 25F;
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.FillWeight = 125F;
            this.CustomerName.HeaderText = "Tên";
            this.CustomerName.Name = "CustomerName";
            // 
            // CustomerMobile
            // 
            this.CustomerMobile.DataPropertyName = "CustomerMobile";
            this.CustomerMobile.HeaderText = "Điện thoại";
            this.CustomerMobile.Name = "CustomerMobile";
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "CustomerAddress";
            this.CustomerAddress.FillWeight = 150F;
            this.CustomerAddress.HeaderText = "Địa chỉ";
            this.CustomerAddress.Name = "CustomerAddress";
            // 
            // CustomerNationality
            // 
            this.CustomerNationality.DataPropertyName = "CustomerNationality";
            this.CustomerNationality.HeaderText = "Quốc tịch";
            this.CustomerNationality.Name = "CustomerNationality";
            // 
            // CustomerDateofbirth
            // 
            this.CustomerDateofbirth.DataPropertyName = "CustomerDateofbirth";
            this.CustomerDateofbirth.HeaderText = "Ngày sinh";
            this.CustomerDateofbirth.Name = "CustomerDateofbirth";
            // 
            // CustomerGender
            // 
            this.CustomerGender.DataPropertyName = "CustomerGender";
            this.CustomerGender.FillWeight = 80F;
            this.CustomerGender.HeaderText = "Giới tính";
            this.CustomerGender.Name = "CustomerGender";
            // 
            // CustomerIndentification
            // 
            this.CustomerIndentification.DataPropertyName = "CustomerIndentification";
            this.CustomerIndentification.HeaderText = "Căn cước công dân";
            this.CustomerIndentification.Name = "CustomerIndentification";
            // 
            // CustomerChange
            // 
            this.CustomerChange.DataPropertyName = "CustomerEdit";
            this.CustomerChange.FillWeight = 30F;
            this.CustomerChange.HeaderText = "Sửa";
            this.CustomerChange.Name = "CustomerChange";
            // 
            // CustomerDelete
            // 
            this.CustomerDelete.DataPropertyName = "CustomerDelete";
            this.CustomerDelete.FillWeight = 30F;
            this.CustomerDelete.HeaderText = "Xoá";
            this.CustomerDelete.Name = "CustomerDelete";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.CustomerGridView;
            // 
            // CustomerUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "CustomerUC";
            this.Size = new System.Drawing.Size(1457, 716);
            this.TopPanel.ResumeLayout(false);
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2Panel RightPanel;
        private Guna.UI2.WinForms.Guna2DataGridView CustomerGridView;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Button AddCustomer;
        private Guna.UI2.WinForms.Guna2TextBox SearchText;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerNationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerDateofbirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerIndentification;
        private System.Windows.Forms.DataGridViewButtonColumn CustomerChange;
        private System.Windows.Forms.DataGridViewButtonColumn CustomerDelete;
    }
}
