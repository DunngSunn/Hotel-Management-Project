
namespace GUI.UserControls
{
    partial class RoomManagerUC
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
            this.LeftPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnAddRoom = new Guna.UI2.WinForms.Guna2Button();
            this.GroupStatusRoom = new Guna.UI2.WinForms.Guna2GroupBox();
            this.RBBooked = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RBAll = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RBNotBooked = new Guna.UI2.WinForms.Guna2RadioButton();
            this.GroupTypeRoom = new Guna.UI2.WinForms.Guna2GroupBox();
            this.RBSingleRoom = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RBDoubleRoom = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RBFamilyRoom = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RBAllRoom = new Guna.UI2.WinForms.Guna2RadioButton();
            this.RightPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.GroupFamilyRoom = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LayoutPanelFamilyRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupDoubleRoom = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LayoutPanelDoubleRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.GroupSingleRoom = new Guna.UI2.WinForms.Guna2GroupBox();
            this.LayoutPanelSingleRoom = new System.Windows.Forms.FlowLayoutPanel();
            this.TopPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.TextSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.LeftPanel.SuspendLayout();
            this.GroupStatusRoom.SuspendLayout();
            this.GroupTypeRoom.SuspendLayout();
            this.RightPanel.SuspendLayout();
            this.GroupFamilyRoom.SuspendLayout();
            this.GroupDoubleRoom.SuspendLayout();
            this.GroupSingleRoom.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeftPanel.Controls.Add(this.BtnAddRoom);
            this.LeftPanel.Controls.Add(this.GroupStatusRoom);
            this.LeftPanel.Controls.Add(this.GroupTypeRoom);
            this.LeftPanel.Location = new System.Drawing.Point(3, 74);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.ShadowDecoration.Parent = this.LeftPanel;
            this.LeftPanel.Size = new System.Drawing.Size(207, 639);
            this.LeftPanel.TabIndex = 0;
            // 
            // BtnAddRoom
            // 
            this.BtnAddRoom.BorderRadius = 15;
            this.BtnAddRoom.CheckedState.Parent = this.BtnAddRoom;
            this.BtnAddRoom.CustomImages.Parent = this.BtnAddRoom;
            this.BtnAddRoom.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddRoom.ForeColor = System.Drawing.Color.White;
            this.BtnAddRoom.HoverState.Parent = this.BtnAddRoom;
            this.BtnAddRoom.Location = new System.Drawing.Point(3, 442);
            this.BtnAddRoom.Name = "BtnAddRoom";
            this.BtnAddRoom.ShadowDecoration.Parent = this.BtnAddRoom;
            this.BtnAddRoom.Size = new System.Drawing.Size(201, 45);
            this.BtnAddRoom.TabIndex = 17;
            this.BtnAddRoom.Text = "Thêm phòng mới";
            this.BtnAddRoom.Click += new System.EventHandler(this.BtnAddRoom_Click);
            // 
            // GroupStatusRoom
            // 
            this.GroupStatusRoom.BorderRadius = 15;
            this.GroupStatusRoom.BorderThickness = 2;
            this.GroupStatusRoom.Controls.Add(this.RBBooked);
            this.GroupStatusRoom.Controls.Add(this.RBAll);
            this.GroupStatusRoom.Controls.Add(this.RBNotBooked);
            this.GroupStatusRoom.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.GroupStatusRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GroupStatusRoom.Location = new System.Drawing.Point(3, 274);
            this.GroupStatusRoom.Name = "GroupStatusRoom";
            this.GroupStatusRoom.ShadowDecoration.Parent = this.GroupStatusRoom;
            this.GroupStatusRoom.Size = new System.Drawing.Size(201, 162);
            this.GroupStatusRoom.TabIndex = 16;
            this.GroupStatusRoom.Text = "Trạng thái:";
            // 
            // RBBooked
            // 
            this.RBBooked.AutoSize = true;
            this.RBBooked.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBBooked.CheckedState.BorderThickness = 0;
            this.RBBooked.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBBooked.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RBBooked.CheckedState.InnerOffset = -4;
            this.RBBooked.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBBooked.Location = new System.Drawing.Point(35, 57);
            this.RBBooked.Name = "RBBooked";
            this.RBBooked.Size = new System.Drawing.Size(82, 23);
            this.RBBooked.TabIndex = 11;
            this.RBBooked.Text = "Đã thuê";
            this.RBBooked.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RBBooked.UncheckedState.BorderThickness = 2;
            this.RBBooked.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBBooked.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RBBooked.UseVisualStyleBackColor = true;
            this.RBBooked.CheckedChanged += new System.EventHandler(this.RBStatus_StateChanged);
            // 
            // RBAll
            // 
            this.RBAll.AutoSize = true;
            this.RBAll.Checked = true;
            this.RBAll.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBAll.CheckedState.BorderThickness = 0;
            this.RBAll.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBAll.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RBAll.CheckedState.InnerOffset = -4;
            this.RBAll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBAll.Location = new System.Drawing.Point(35, 115);
            this.RBAll.Name = "RBAll";
            this.RBAll.Size = new System.Drawing.Size(70, 23);
            this.RBAll.TabIndex = 13;
            this.RBAll.TabStop = true;
            this.RBAll.Text = "Tất cả";
            this.RBAll.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RBAll.UncheckedState.BorderThickness = 2;
            this.RBAll.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBAll.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RBAll.UseVisualStyleBackColor = true;
            this.RBAll.CheckedChanged += new System.EventHandler(this.RBStatus_StateChanged);
            // 
            // RBNotBooked
            // 
            this.RBNotBooked.AutoSize = true;
            this.RBNotBooked.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBNotBooked.CheckedState.BorderThickness = 0;
            this.RBNotBooked.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBNotBooked.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RBNotBooked.CheckedState.InnerOffset = -4;
            this.RBNotBooked.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBNotBooked.Location = new System.Drawing.Point(35, 86);
            this.RBNotBooked.Name = "RBNotBooked";
            this.RBNotBooked.Size = new System.Drawing.Size(107, 23);
            this.RBNotBooked.TabIndex = 12;
            this.RBNotBooked.Text = "Đang trống";
            this.RBNotBooked.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RBNotBooked.UncheckedState.BorderThickness = 2;
            this.RBNotBooked.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBNotBooked.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RBNotBooked.UseVisualStyleBackColor = true;
            this.RBNotBooked.CheckedChanged += new System.EventHandler(this.RBStatus_StateChanged);
            // 
            // GroupTypeRoom
            // 
            this.GroupTypeRoom.BorderRadius = 15;
            this.GroupTypeRoom.BorderThickness = 2;
            this.GroupTypeRoom.Controls.Add(this.RBSingleRoom);
            this.GroupTypeRoom.Controls.Add(this.RBDoubleRoom);
            this.GroupTypeRoom.Controls.Add(this.RBFamilyRoom);
            this.GroupTypeRoom.Controls.Add(this.RBAllRoom);
            this.GroupTypeRoom.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.GroupTypeRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GroupTypeRoom.Location = new System.Drawing.Point(3, 81);
            this.GroupTypeRoom.Name = "GroupTypeRoom";
            this.GroupTypeRoom.ShadowDecoration.Parent = this.GroupTypeRoom;
            this.GroupTypeRoom.Size = new System.Drawing.Size(201, 187);
            this.GroupTypeRoom.TabIndex = 14;
            this.GroupTypeRoom.Text = "Loại phòng:";
            // 
            // RBSingleRoom
            // 
            this.RBSingleRoom.AutoSize = true;
            this.RBSingleRoom.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBSingleRoom.CheckedState.BorderThickness = 0;
            this.RBSingleRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBSingleRoom.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RBSingleRoom.CheckedState.InnerOffset = -4;
            this.RBSingleRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBSingleRoom.Location = new System.Drawing.Point(29, 62);
            this.RBSingleRoom.Name = "RBSingleRoom";
            this.RBSingleRoom.Size = new System.Drawing.Size(104, 23);
            this.RBSingleRoom.TabIndex = 1;
            this.RBSingleRoom.Text = "Phòng đơn";
            this.RBSingleRoom.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RBSingleRoom.UncheckedState.BorderThickness = 2;
            this.RBSingleRoom.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBSingleRoom.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RBSingleRoom.UseVisualStyleBackColor = true;
            this.RBSingleRoom.CheckedChanged += new System.EventHandler(this.RBRoom_StateChanged);
            // 
            // RBDoubleRoom
            // 
            this.RBDoubleRoom.AutoSize = true;
            this.RBDoubleRoom.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBDoubleRoom.CheckedState.BorderThickness = 0;
            this.RBDoubleRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBDoubleRoom.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RBDoubleRoom.CheckedState.InnerOffset = -4;
            this.RBDoubleRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBDoubleRoom.Location = new System.Drawing.Point(29, 91);
            this.RBDoubleRoom.Name = "RBDoubleRoom";
            this.RBDoubleRoom.Size = new System.Drawing.Size(99, 23);
            this.RBDoubleRoom.TabIndex = 2;
            this.RBDoubleRoom.Text = "Phòng đôi";
            this.RBDoubleRoom.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RBDoubleRoom.UncheckedState.BorderThickness = 2;
            this.RBDoubleRoom.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBDoubleRoom.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RBDoubleRoom.UseVisualStyleBackColor = true;
            this.RBDoubleRoom.CheckedChanged += new System.EventHandler(this.RBRoom_StateChanged);
            // 
            // RBFamilyRoom
            // 
            this.RBFamilyRoom.AutoSize = true;
            this.RBFamilyRoom.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBFamilyRoom.CheckedState.BorderThickness = 0;
            this.RBFamilyRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBFamilyRoom.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RBFamilyRoom.CheckedState.InnerOffset = -4;
            this.RBFamilyRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBFamilyRoom.Location = new System.Drawing.Point(29, 120);
            this.RBFamilyRoom.Name = "RBFamilyRoom";
            this.RBFamilyRoom.Size = new System.Drawing.Size(134, 23);
            this.RBFamilyRoom.TabIndex = 3;
            this.RBFamilyRoom.Text = "Phòng gia đình";
            this.RBFamilyRoom.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RBFamilyRoom.UncheckedState.BorderThickness = 2;
            this.RBFamilyRoom.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBFamilyRoom.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RBFamilyRoom.UseVisualStyleBackColor = true;
            this.RBFamilyRoom.CheckedChanged += new System.EventHandler(this.RBRoom_StateChanged);
            // 
            // RBAllRoom
            // 
            this.RBAllRoom.AutoSize = true;
            this.RBAllRoom.Checked = true;
            this.RBAllRoom.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBAllRoom.CheckedState.BorderThickness = 0;
            this.RBAllRoom.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RBAllRoom.CheckedState.InnerColor = System.Drawing.Color.White;
            this.RBAllRoom.CheckedState.InnerOffset = -4;
            this.RBAllRoom.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBAllRoom.Location = new System.Drawing.Point(29, 149);
            this.RBAllRoom.Name = "RBAllRoom";
            this.RBAllRoom.Size = new System.Drawing.Size(70, 23);
            this.RBAllRoom.TabIndex = 4;
            this.RBAllRoom.TabStop = true;
            this.RBAllRoom.Text = "Tất cả";
            this.RBAllRoom.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.RBAllRoom.UncheckedState.BorderThickness = 2;
            this.RBAllRoom.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.RBAllRoom.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.RBAllRoom.UseVisualStyleBackColor = true;
            this.RBAllRoom.CheckedChanged += new System.EventHandler(this.RBRoom_StateChanged);
            // 
            // RightPanel
            // 
            this.RightPanel.AutoScroll = true;
            this.RightPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RightPanel.Controls.Add(this.GroupFamilyRoom);
            this.RightPanel.Controls.Add(this.GroupDoubleRoom);
            this.RightPanel.Controls.Add(this.GroupSingleRoom);
            this.RightPanel.Location = new System.Drawing.Point(216, 74);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.Padding = new System.Windows.Forms.Padding(7);
            this.RightPanel.ShadowDecoration.Parent = this.RightPanel;
            this.RightPanel.Size = new System.Drawing.Size(1238, 639);
            this.RightPanel.TabIndex = 1;
            // 
            // GroupFamilyRoom
            // 
            this.GroupFamilyRoom.AllowDrop = true;
            this.GroupFamilyRoom.BorderRadius = 15;
            this.GroupFamilyRoom.BorderThickness = 0;
            this.GroupFamilyRoom.Controls.Add(this.LayoutPanelFamilyRoom);
            this.GroupFamilyRoom.CustomBorderColor = System.Drawing.Color.Transparent;
            this.GroupFamilyRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupFamilyRoom.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.GroupFamilyRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GroupFamilyRoom.Location = new System.Drawing.Point(7, 319);
            this.GroupFamilyRoom.MinimumSize = new System.Drawing.Size(1224, 156);
            this.GroupFamilyRoom.Name = "GroupFamilyRoom";
            this.GroupFamilyRoom.ShadowDecoration.Parent = this.GroupFamilyRoom;
            this.GroupFamilyRoom.Size = new System.Drawing.Size(1224, 156);
            this.GroupFamilyRoom.TabIndex = 17;
            this.GroupFamilyRoom.Text = "Phòng gia đình";
            // 
            // LayoutPanelFamilyRoom
            // 
            this.LayoutPanelFamilyRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanelFamilyRoom.AutoSize = true;
            this.LayoutPanelFamilyRoom.Location = new System.Drawing.Point(5, 45);
            this.LayoutPanelFamilyRoom.Name = "LayoutPanelFamilyRoom";
            this.LayoutPanelFamilyRoom.Padding = new System.Windows.Forms.Padding(10);
            this.LayoutPanelFamilyRoom.Size = new System.Drawing.Size(1216, 102);
            this.LayoutPanelFamilyRoom.TabIndex = 0;
            // 
            // GroupDoubleRoom
            // 
            this.GroupDoubleRoom.AllowDrop = true;
            this.GroupDoubleRoom.BorderRadius = 15;
            this.GroupDoubleRoom.BorderThickness = 0;
            this.GroupDoubleRoom.Controls.Add(this.LayoutPanelDoubleRoom);
            this.GroupDoubleRoom.CustomBorderColor = System.Drawing.Color.Transparent;
            this.GroupDoubleRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupDoubleRoom.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.GroupDoubleRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GroupDoubleRoom.Location = new System.Drawing.Point(7, 163);
            this.GroupDoubleRoom.MinimumSize = new System.Drawing.Size(1224, 156);
            this.GroupDoubleRoom.Name = "GroupDoubleRoom";
            this.GroupDoubleRoom.ShadowDecoration.Parent = this.GroupDoubleRoom;
            this.GroupDoubleRoom.Size = new System.Drawing.Size(1224, 156);
            this.GroupDoubleRoom.TabIndex = 16;
            this.GroupDoubleRoom.Text = "Phòng đôi";
            // 
            // LayoutPanelDoubleRoom
            // 
            this.LayoutPanelDoubleRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanelDoubleRoom.AutoSize = true;
            this.LayoutPanelDoubleRoom.Location = new System.Drawing.Point(5, 45);
            this.LayoutPanelDoubleRoom.Name = "LayoutPanelDoubleRoom";
            this.LayoutPanelDoubleRoom.Padding = new System.Windows.Forms.Padding(10);
            this.LayoutPanelDoubleRoom.Size = new System.Drawing.Size(1216, 102);
            this.LayoutPanelDoubleRoom.TabIndex = 0;
            // 
            // GroupSingleRoom
            // 
            this.GroupSingleRoom.AllowDrop = true;
            this.GroupSingleRoom.BorderRadius = 15;
            this.GroupSingleRoom.BorderThickness = 0;
            this.GroupSingleRoom.Controls.Add(this.LayoutPanelSingleRoom);
            this.GroupSingleRoom.CustomBorderColor = System.Drawing.Color.Transparent;
            this.GroupSingleRoom.Dock = System.Windows.Forms.DockStyle.Top;
            this.GroupSingleRoom.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold);
            this.GroupSingleRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GroupSingleRoom.Location = new System.Drawing.Point(7, 7);
            this.GroupSingleRoom.MinimumSize = new System.Drawing.Size(1224, 156);
            this.GroupSingleRoom.Name = "GroupSingleRoom";
            this.GroupSingleRoom.ShadowDecoration.Parent = this.GroupSingleRoom;
            this.GroupSingleRoom.Size = new System.Drawing.Size(1224, 156);
            this.GroupSingleRoom.TabIndex = 15;
            this.GroupSingleRoom.Text = "Phòng đơn";
            // 
            // LayoutPanelSingleRoom
            // 
            this.LayoutPanelSingleRoom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LayoutPanelSingleRoom.AutoSize = true;
            this.LayoutPanelSingleRoom.Location = new System.Drawing.Point(5, 45);
            this.LayoutPanelSingleRoom.Name = "LayoutPanelSingleRoom";
            this.LayoutPanelSingleRoom.Padding = new System.Windows.Forms.Padding(10);
            this.LayoutPanelSingleRoom.Size = new System.Drawing.Size(1216, 102);
            this.LayoutPanelSingleRoom.TabIndex = 0;
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.TextSearch);
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.ShadowDecoration.Parent = this.TopPanel;
            this.TopPanel.Size = new System.Drawing.Size(1457, 68);
            this.TopPanel.TabIndex = 2;
            // 
            // TextSearch
            // 
            this.TextSearch.BorderRadius = 15;
            this.TextSearch.BorderThickness = 2;
            this.TextSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextSearch.DefaultText = "";
            this.TextSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TextSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TextSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextSearch.DisabledState.Parent = this.TextSearch;
            this.TextSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TextSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSearch.FocusedState.Parent = this.TextSearch;
            this.TextSearch.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TextSearch.HoverState.Parent = this.TextSearch;
            this.TextSearch.Location = new System.Drawing.Point(485, 14);
            this.TextSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextSearch.Name = "TextSearch";
            this.TextSearch.PasswordChar = '\0';
            this.TextSearch.PlaceholderText = "Tìm kiếm";
            this.TextSearch.SelectedText = "";
            this.TextSearch.ShadowDecoration.Parent = this.TextSearch;
            this.TextSearch.Size = new System.Drawing.Size(457, 39);
            this.TextSearch.TabIndex = 0;
            this.TextSearch.TextChanged += new System.EventHandler(this.TextSearch_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.LeftPanel;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 10;
            this.guna2Elipse2.TargetControl = this.RightPanel;
            // 
            // RoomManagerUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.RightPanel);
            this.Controls.Add(this.LeftPanel);
            this.Name = "RoomManagerUC";
            this.Size = new System.Drawing.Size(1457, 716);
            this.LeftPanel.ResumeLayout(false);
            this.GroupStatusRoom.ResumeLayout(false);
            this.GroupStatusRoom.PerformLayout();
            this.GroupTypeRoom.ResumeLayout(false);
            this.GroupTypeRoom.PerformLayout();
            this.RightPanel.ResumeLayout(false);
            this.GroupFamilyRoom.ResumeLayout(false);
            this.GroupFamilyRoom.PerformLayout();
            this.GroupDoubleRoom.ResumeLayout(false);
            this.GroupDoubleRoom.PerformLayout();
            this.GroupSingleRoom.ResumeLayout(false);
            this.GroupSingleRoom.PerformLayout();
            this.TopPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel LeftPanel;
        private Guna.UI2.WinForms.Guna2Panel RightPanel;
        private Guna.UI2.WinForms.Guna2Panel TopPanel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TextBox TextSearch;
        private Guna.UI2.WinForms.Guna2RadioButton RBFamilyRoom;
        private Guna.UI2.WinForms.Guna2RadioButton RBDoubleRoom;
        private Guna.UI2.WinForms.Guna2RadioButton RBSingleRoom;
        private Guna.UI2.WinForms.Guna2RadioButton RBAllRoom;
        private Guna.UI2.WinForms.Guna2RadioButton RBAll;
        private Guna.UI2.WinForms.Guna2RadioButton RBNotBooked;
        private Guna.UI2.WinForms.Guna2RadioButton RBBooked;
        private Guna.UI2.WinForms.Guna2GroupBox GroupTypeRoom;
        private Guna.UI2.WinForms.Guna2GroupBox GroupStatusRoom;
        private Guna.UI2.WinForms.Guna2GroupBox GroupSingleRoom;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelSingleRoom;
        private Guna.UI2.WinForms.Guna2GroupBox GroupFamilyRoom;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelFamilyRoom;
        private Guna.UI2.WinForms.Guna2GroupBox GroupDoubleRoom;
        private System.Windows.Forms.FlowLayoutPanel LayoutPanelDoubleRoom;
        private Guna.UI2.WinForms.Guna2Button BtnAddRoom;
    }
}
