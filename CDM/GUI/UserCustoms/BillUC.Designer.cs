
namespace GUI.UserControls
{
    partial class BillUC
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
            this.RightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.BillGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.SearchText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Checkout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoomNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RightPanel
            // 
            this.RightPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RightPanel.Controls.Add(this.BillGridView);
            this.RightPanel.Location = new System.Drawing.Point(0, 77);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.ShadowDecoration.Parent = this.RightPanel;
            this.RightPanel.Size = new System.Drawing.Size(1457, 639);
            this.RightPanel.TabIndex = 6;
            // 
            // BillGridView
            // 
            this.BillGridView.AllowUserToAddRows = false;
            this.BillGridView.AllowUserToDeleteRows = false;
            this.BillGridView.AllowUserToResizeColumns = false;
            this.BillGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.BillGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BillGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.BillGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.BillGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.BillGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BillGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.BillGridView.ColumnHeadersHeight = 30;
            this.BillGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BillGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BillID,
            this.CustomerName,
            this.Checkin,
            this.Checkout,
            this.RoomNo,
            this.Price});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BillGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.BillGridView.EnableHeadersVisualStyles = false;
            this.BillGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.Location = new System.Drawing.Point(48, 12);
            this.BillGridView.MultiSelect = false;
            this.BillGridView.Name = "BillGridView";
            this.BillGridView.ReadOnly = true;
            this.BillGridView.RowHeadersVisible = false;
            this.BillGridView.RowTemplate.Height = 30;
            this.BillGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.BillGridView.Size = new System.Drawing.Size(1355, 608);
            this.BillGridView.TabIndex = 0;
            this.BillGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.BillGridView.ThemeStyle.BackColor = System.Drawing.Color.Silver;
            this.BillGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.BillGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.BillGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.BillGridView.ThemeStyle.HeaderStyle.Height = 30;
            this.BillGridView.ThemeStyle.ReadOnly = true;
            this.BillGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.BillGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.BillGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BillGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.BillGridView.ThemeStyle.RowsStyle.Height = 30;
            this.BillGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BillGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.SearchText);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(1457, 68);
            this.TopPanel.TabIndex = 5;
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
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.BillGridView;
            // 
            // BillID
            // 
            this.BillID.DataPropertyName = "BillID";
            this.BillID.FillWeight = 50F;
            this.BillID.HeaderText = "ID";
            this.BillID.Name = "BillID";
            this.BillID.ReadOnly = true;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.FillWeight = 150F;
            this.CustomerName.HeaderText = "Tên khách hàng";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            // 
            // Checkin
            // 
            this.Checkin.DataPropertyName = "Checkin";
            this.Checkin.HeaderText = "Checkin";
            this.Checkin.Name = "Checkin";
            this.Checkin.ReadOnly = true;
            // 
            // Checkout
            // 
            this.Checkout.DataPropertyName = "Checkout";
            this.Checkout.HeaderText = "Checkout";
            this.Checkout.Name = "Checkout";
            this.Checkout.ReadOnly = true;
            // 
            // RoomNo
            // 
            this.RoomNo.DataPropertyName = "RoomNo";
            this.RoomNo.HeaderText = "Tên phòng";
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Tổng giá hoá đơn";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // BillUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.TopPanel);
            this.Name = "BillUC";
            this.Size = new System.Drawing.Size(1457, 716);
            this.RightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BillGridView)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel RightPanel;
        private Guna.UI2.WinForms.Guna2DataGridView BillGridView;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2TextBox SearchText;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkin;
        private System.Windows.Forms.DataGridViewTextBoxColumn Checkout;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoomNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}
