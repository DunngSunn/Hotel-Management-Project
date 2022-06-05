
namespace GUI.UserControls
{
    partial class ServiceUC
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.RightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PriceText = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ServiceTypeCb = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ServiceNameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddService = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServicePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EditService = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteService = new System.Windows.Forms.DataGridViewButtonColumn();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SearchText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ServiceTypeText = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddServiceType = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceTypeGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.ServiceTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceTypeName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RightPanel.BorderRadius = 15;
            this.RightPanel.Controls.Add(this.label2);
            this.RightPanel.Controls.Add(this.PriceText);
            this.RightPanel.Controls.Add(this.label4);
            this.RightPanel.Controls.Add(this.label1);
            this.RightPanel.Controls.Add(this.ServiceTypeCb);
            this.RightPanel.Controls.Add(this.ServiceNameText);
            this.RightPanel.Controls.Add(this.AddService);
            this.RightPanel.Controls.Add(this.ServiceGridView);
            this.RightPanel.Location = new System.Drawing.Point(0, 77);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.ShadowDecoration.Parent = this.RightPanel;
            this.RightPanel.Size = new System.Drawing.Size(816, 639);
            this.RightPanel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(185, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 52;
            this.label2.Text = "Giá:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PriceText
            // 
            this.PriceText.BackColor = System.Drawing.Color.Transparent;
            this.PriceText.BorderColor = System.Drawing.Color.LightGray;
            this.PriceText.BorderRadius = 18;
            this.PriceText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PriceText.DefaultText = "";
            this.PriceText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PriceText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PriceText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceText.DisabledState.Parent = this.PriceText;
            this.PriceText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PriceText.Enabled = false;
            this.PriceText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceText.FocusedState.Parent = this.PriceText;
            this.PriceText.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PriceText.HoverState.Parent = this.PriceText;
            this.PriceText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.PriceText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.PriceText.Location = new System.Drawing.Point(317, 525);
            this.PriceText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PriceText.Name = "PriceText";
            this.PriceText.PasswordChar = '\0';
            this.PriceText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.PriceText.PlaceholderText = "Giá";
            this.PriceText.SelectedText = "";
            this.PriceText.ShadowDecoration.Parent = this.PriceText;
            this.PriceText.Size = new System.Drawing.Size(326, 36);
            this.PriceText.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(186, 569);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 36);
            this.label4.TabIndex = 49;
            this.label4.Text = "Loại dịch vụ:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 479);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 48;
            this.label1.Text = "Tên dịch vụ:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServiceTypeCb
            // 
            this.ServiceTypeCb.Animated = true;
            this.ServiceTypeCb.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTypeCb.BorderRadius = 18;
            this.ServiceTypeCb.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ServiceTypeCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ServiceTypeCb.Enabled = false;
            this.ServiceTypeCb.FocusedColor = System.Drawing.Color.Empty;
            this.ServiceTypeCb.FocusedState.Parent = this.ServiceTypeCb;
            this.ServiceTypeCb.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ServiceTypeCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.ServiceTypeCb.FormattingEnabled = true;
            this.ServiceTypeCb.HoverState.Parent = this.ServiceTypeCb;
            this.ServiceTypeCb.ItemHeight = 30;
            this.ServiceTypeCb.ItemsAppearance.Parent = this.ServiceTypeCb;
            this.ServiceTypeCb.Location = new System.Drawing.Point(317, 569);
            this.ServiceTypeCb.Name = "ServiceTypeCb";
            this.ServiceTypeCb.ShadowDecoration.Parent = this.ServiceTypeCb;
            this.ServiceTypeCb.Size = new System.Drawing.Size(326, 36);
            this.ServiceTypeCb.TabIndex = 5;
            // 
            // ServiceNameText
            // 
            this.ServiceNameText.BackColor = System.Drawing.Color.Transparent;
            this.ServiceNameText.BorderColor = System.Drawing.Color.LightGray;
            this.ServiceNameText.BorderRadius = 18;
            this.ServiceNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServiceNameText.DefaultText = "";
            this.ServiceNameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServiceNameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServiceNameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceNameText.DisabledState.Parent = this.ServiceNameText;
            this.ServiceNameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceNameText.Enabled = false;
            this.ServiceNameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceNameText.FocusedState.Parent = this.ServiceNameText;
            this.ServiceNameText.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceNameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceNameText.HoverState.Parent = this.ServiceNameText;
            this.ServiceNameText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ServiceNameText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.ServiceNameText.Location = new System.Drawing.Point(317, 479);
            this.ServiceNameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServiceNameText.Name = "ServiceNameText";
            this.ServiceNameText.PasswordChar = '\0';
            this.ServiceNameText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ServiceNameText.PlaceholderText = "Tên dịch vụ";
            this.ServiceNameText.SelectedText = "";
            this.ServiceNameText.ShadowDecoration.Parent = this.ServiceNameText;
            this.ServiceNameText.Size = new System.Drawing.Size(326, 36);
            this.ServiceNameText.TabIndex = 3;
            // 
            // AddService
            // 
            this.AddService.BorderRadius = 15;
            this.AddService.BorderThickness = 2;
            this.AddService.CheckedState.Parent = this.AddService;
            this.AddService.CustomImages.Parent = this.AddService;
            this.AddService.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddService.ForeColor = System.Drawing.Color.White;
            this.AddService.HoverState.Parent = this.AddService;
            this.AddService.Location = new System.Drawing.Point(308, 416);
            this.AddService.Name = "AddService";
            this.AddService.ShadowDecoration.Parent = this.AddService;
            this.AddService.Size = new System.Drawing.Size(180, 45);
            this.AddService.TabIndex = 1;
            this.AddService.Text = "Thêm";
            this.AddService.Click += new System.EventHandler(this.AddService_Click);
            // 
            // ServiceGridView
            // 
            this.ServiceGridView.AllowUserToAddRows = false;
            this.ServiceGridView.AllowUserToDeleteRows = false;
            this.ServiceGridView.AllowUserToResizeColumns = false;
            this.ServiceGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.ServiceGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ServiceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.ServiceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServiceGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ServiceGridView.ColumnHeadersHeight = 30;
            this.ServiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceID,
            this.ServiceName,
            this.ServicePrice,
            this.ServiceType,
            this.EditService,
            this.DeleteService});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.ServiceGridView.EnableHeadersVisualStyles = false;
            this.ServiceGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceGridView.Location = new System.Drawing.Point(12, 10);
            this.ServiceGridView.MultiSelect = false;
            this.ServiceGridView.Name = "ServiceGridView";
            this.ServiceGridView.RowHeadersVisible = false;
            this.ServiceGridView.RowTemplate.Height = 30;
            this.ServiceGridView.RowTemplate.ReadOnly = true;
            this.ServiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceGridView.Size = new System.Drawing.Size(791, 400);
            this.ServiceGridView.TabIndex = 0;
            this.ServiceGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ServiceGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ServiceGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ServiceGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ServiceGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ServiceGridView.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.ServiceGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ServiceGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ServiceGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ServiceGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ServiceGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ServiceGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.ServiceGridView.ThemeStyle.ReadOnly = false;
            this.ServiceGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServiceGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ServiceGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServiceGridView.ThemeStyle.RowsStyle.Height = 30;
            this.ServiceGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServiceGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceGridView_CellClick);
            this.ServiceGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ServiceGridView_CellPainting);
            // 
            // ServiceID
            // 
            this.ServiceID.DataPropertyName = "ServiceID";
            this.ServiceID.FillWeight = 25F;
            this.ServiceID.HeaderText = "ID";
            this.ServiceID.Name = "ServiceID";
            this.ServiceID.ReadOnly = true;
            // 
            // ServiceName
            // 
            this.ServiceName.DataPropertyName = "ServiceName";
            this.ServiceName.HeaderText = "Tên dịch vụ";
            this.ServiceName.Name = "ServiceName";
            // 
            // ServicePrice
            // 
            this.ServicePrice.DataPropertyName = "ServicePrice";
            this.ServicePrice.HeaderText = "Giá ";
            this.ServicePrice.Name = "ServicePrice";
            // 
            // ServiceType
            // 
            this.ServiceType.DataPropertyName = "ServiceType";
            this.ServiceType.HeaderText = "Loại dịch vụ";
            this.ServiceType.Name = "ServiceType";
            this.ServiceType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // EditService
            // 
            this.EditService.FillWeight = 30F;
            this.EditService.HeaderText = "Sửa";
            this.EditService.Name = "EditService";
            // 
            // DeleteService
            // 
            this.DeleteService.FillWeight = 30F;
            this.DeleteService.HeaderText = "Xoá";
            this.DeleteService.Name = "DeleteService";
            this.DeleteService.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DeleteService.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.SearchText);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(1457, 68);
            this.TopPanel.TabIndex = 6;
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
            this.SearchText.Location = new System.Drawing.Point(1012, 14);
            this.SearchText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SearchText.Name = "SearchText";
            this.SearchText.PasswordChar = '\0';
            this.SearchText.PlaceholderText = "Tìm kiếm dịch vụ";
            this.SearchText.SelectedText = "";
            this.SearchText.ShadowDecoration.Parent = this.SearchText;
            this.SearchText.Size = new System.Drawing.Size(372, 39);
            this.SearchText.TabIndex = 10;
            this.SearchText.TextChanged += new System.EventHandler(this.SearchText_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.ServiceGridView;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.guna2Panel1.BorderRadius = 15;
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.ServiceTypeText);
            this.guna2Panel1.Controls.Add(this.AddServiceType);
            this.guna2Panel1.Controls.Add(this.ServiceTypeGridView);
            this.guna2Panel1.Location = new System.Drawing.Point(822, 77);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(635, 639);
            this.guna2Panel1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tên loại dịch vụ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ServiceTypeText
            // 
            this.ServiceTypeText.BackColor = System.Drawing.Color.Transparent;
            this.ServiceTypeText.BorderColor = System.Drawing.Color.LightGray;
            this.ServiceTypeText.BorderRadius = 18;
            this.ServiceTypeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ServiceTypeText.DefaultText = "";
            this.ServiceTypeText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ServiceTypeText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ServiceTypeText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceTypeText.DisabledState.Parent = this.ServiceTypeText;
            this.ServiceTypeText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ServiceTypeText.Enabled = false;
            this.ServiceTypeText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeText.FocusedState.Parent = this.ServiceTypeText;
            this.ServiceTypeText.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceTypeText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ServiceTypeText.HoverState.Parent = this.ServiceTypeText;
            this.ServiceTypeText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.ServiceTypeText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.ServiceTypeText.Location = new System.Drawing.Point(230, 479);
            this.ServiceTypeText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ServiceTypeText.Name = "ServiceTypeText";
            this.ServiceTypeText.PasswordChar = '\0';
            this.ServiceTypeText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.ServiceTypeText.PlaceholderText = "Tên loại dịch vụ";
            this.ServiceTypeText.SelectedText = "";
            this.ServiceTypeText.ShadowDecoration.Parent = this.ServiceTypeText;
            this.ServiceTypeText.Size = new System.Drawing.Size(326, 36);
            this.ServiceTypeText.TabIndex = 2;
            // 
            // AddServiceType
            // 
            this.AddServiceType.BorderRadius = 15;
            this.AddServiceType.BorderThickness = 2;
            this.AddServiceType.CheckedState.Parent = this.AddServiceType;
            this.AddServiceType.CustomImages.Parent = this.AddServiceType;
            this.AddServiceType.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddServiceType.ForeColor = System.Drawing.Color.White;
            this.AddServiceType.HoverState.Parent = this.AddServiceType;
            this.AddServiceType.Location = new System.Drawing.Point(230, 416);
            this.AddServiceType.Name = "AddServiceType";
            this.AddServiceType.ShadowDecoration.Parent = this.AddServiceType;
            this.AddServiceType.Size = new System.Drawing.Size(180, 45);
            this.AddServiceType.TabIndex = 2;
            this.AddServiceType.Text = "Thêm";
            this.AddServiceType.Click += new System.EventHandler(this.AddServiceType_Click);
            // 
            // ServiceTypeGridView
            // 
            this.ServiceTypeGridView.AllowUserToAddRows = false;
            this.ServiceTypeGridView.AllowUserToDeleteRows = false;
            this.ServiceTypeGridView.AllowUserToResizeColumns = false;
            this.ServiceTypeGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.ServiceTypeGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.ServiceTypeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ServiceTypeGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.ServiceTypeGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceTypeGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServiceTypeGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceTypeGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.ServiceTypeGridView.ColumnHeadersHeight = 30;
            this.ServiceTypeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ServiceTypeGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServiceTypeID,
            this.ServiceTypeName,
            this.Edit,
            this.Delete});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceTypeGridView.DefaultCellStyle = dataGridViewCellStyle12;
            this.ServiceTypeGridView.EnableHeadersVisualStyles = false;
            this.ServiceTypeGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceTypeGridView.Location = new System.Drawing.Point(12, 10);
            this.ServiceTypeGridView.MultiSelect = false;
            this.ServiceTypeGridView.Name = "ServiceTypeGridView";
            this.ServiceTypeGridView.RowHeadersVisible = false;
            this.ServiceTypeGridView.RowTemplate.Height = 30;
            this.ServiceTypeGridView.RowTemplate.ReadOnly = true;
            this.ServiceTypeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceTypeGridView.Size = new System.Drawing.Size(607, 400);
            this.ServiceTypeGridView.TabIndex = 0;
            this.ServiceTypeGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ServiceTypeGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceTypeGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ServiceTypeGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ServiceTypeGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ServiceTypeGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ServiceTypeGridView.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.ServiceTypeGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceTypeGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ServiceTypeGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ServiceTypeGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ServiceTypeGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ServiceTypeGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.ServiceTypeGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.ServiceTypeGridView.ThemeStyle.ReadOnly = false;
            this.ServiceTypeGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceTypeGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServiceTypeGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.ServiceTypeGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServiceTypeGridView.ThemeStyle.RowsStyle.Height = 30;
            this.ServiceTypeGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceTypeGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServiceTypeGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ServiceTypeGridView_CellClick);
            this.ServiceTypeGridView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.ServiceTypeGridView_CellPainting);
            // 
            // ServiceTypeID
            // 
            this.ServiceTypeID.DataPropertyName = "ServiceTypeID";
            this.ServiceTypeID.FillWeight = 25F;
            this.ServiceTypeID.HeaderText = "ID";
            this.ServiceTypeID.Name = "ServiceTypeID";
            this.ServiceTypeID.ReadOnly = true;
            // 
            // ServiceTypeName
            // 
            this.ServiceTypeName.DataPropertyName = "ServiceTypeName";
            this.ServiceTypeName.HeaderText = "Tên loại dịch vụ";
            this.ServiceTypeName.Name = "ServiceTypeName";
            // 
            // Edit
            // 
            this.Edit.FillWeight = 30F;
            this.Edit.HeaderText = "Sửa";
            this.Edit.Name = "Edit";
            // 
            // Delete
            // 
            this.Delete.FillWeight = 30F;
            this.Delete.HeaderText = "Xoá";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.ServiceTypeGridView;
            // 
            // ServiceUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "ServiceUC";
            this.Size = new System.Drawing.Size(1457, 716);
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel RightPanel;
        private Guna.UI2.WinForms.Guna2Button AddService;
        private Guna.UI2.WinForms.Guna2DataGridView ServiceGridView;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2TextBox SearchText;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button AddServiceType;
        private Guna.UI2.WinForms.Guna2DataGridView ServiceTypeGridView;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServicePrice;
        private System.Windows.Forms.DataGridViewComboBoxColumn ServiceType;
        private System.Windows.Forms.DataGridViewButtonColumn EditService;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteService;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceTypeName;
        private System.Windows.Forms.DataGridViewButtonColumn Edit;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox PriceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox ServiceTypeCb;
        private Guna.UI2.WinForms.Guna2TextBox ServiceNameText;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox ServiceTypeText;
    }
}
