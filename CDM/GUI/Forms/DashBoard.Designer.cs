
namespace GUI.Forms
{
    partial class DashBoard
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.headerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lbTime = new System.Windows.Forms.Label();
            this.btnExit = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.MovingPanel = new System.Windows.Forms.Panel();
            this.btnService = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmployee = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoom = new Guna.UI2.WinForms.Guna2Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.dataThread = new System.ComponentModel.BackgroundWorker();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2GradientPanel1.SuspendLayout();
            this.headerPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2GradientPanel1.Controls.Add(this.headerPanel);
            this.guna2GradientPanel1.Controls.Add(this.panel1);
            this.guna2GradientPanel1.Controls.Add(this.MainPanel);
            this.guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.guna2GradientPanel1.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.ShadowDecoration.Parent = this.guna2GradientPanel1;
            this.guna2GradientPanel1.Size = new System.Drawing.Size(1457, 884);
            this.guna2GradientPanel1.TabIndex = 4;
            // 
            // headerPanel
            // 
            this.headerPanel.BackColor = System.Drawing.Color.Transparent;
            this.headerPanel.Controls.Add(this.lbTime);
            this.headerPanel.Controls.Add(this.btnExit);
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.ShadowDecoration.Parent = this.headerPanel;
            this.headerPanel.Size = new System.Drawing.Size(1457, 30);
            this.headerPanel.TabIndex = 32;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbTime.Location = new System.Drawing.Point(16, 5);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(45, 18);
            this.lbTime.TabIndex = 32;
            this.lbTime.Text = "Time:";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BorderRadius = 10;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(76)))), ((int)(((byte)(129)))));
            this.btnExit.HoverState.Parent = this.btnExit;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1427, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.ShadowDecoration.Parent = this.btnExit;
            this.btnExit.Size = new System.Drawing.Size(20, 20);
            this.btnExit.TabIndex = 31;
            this.btnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnBill);
            this.panel1.Controls.Add(this.btnCustomer);
            this.panel1.Controls.Add(this.MovingPanel);
            this.panel1.Controls.Add(this.btnService);
            this.panel1.Controls.Add(this.btnEmployee);
            this.panel1.Controls.Add(this.btnRoom);
            this.panel1.Location = new System.Drawing.Point(0, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1457, 126);
            this.panel1.TabIndex = 1;
            // 
            // btnBill
            // 
            this.btnBill.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBill.BorderRadius = 26;
            this.btnBill.BorderThickness = 1;
            this.btnBill.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnBill.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnBill.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.btnBill.CheckedState.Parent = this.btnBill;
            this.btnBill.CustomImages.Parent = this.btnBill;
            this.btnBill.FillColor = System.Drawing.Color.Transparent;
            this.btnBill.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBill.ForeColor = System.Drawing.Color.White;
            this.btnBill.HoverState.Parent = this.btnBill;
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageSize = new System.Drawing.Size(40, 40);
            this.btnBill.Location = new System.Drawing.Point(1113, 17);
            this.btnBill.Name = "btnBill";
            this.btnBill.ShadowDecoration.Parent = this.btnBill;
            this.btnBill.Size = new System.Drawing.Size(250, 85);
            this.btnBill.TabIndex = 5;
            this.btnBill.Text = "Hoá đơn";
            this.btnBill.Click += new System.EventHandler(this.BtnBill_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCustomer.BorderRadius = 26;
            this.btnCustomer.BorderThickness = 1;
            this.btnCustomer.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnCustomer.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnCustomer.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.btnCustomer.CheckedState.Parent = this.btnCustomer;
            this.btnCustomer.CustomImages.Parent = this.btnCustomer;
            this.btnCustomer.FillColor = System.Drawing.Color.Transparent;
            this.btnCustomer.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.ForeColor = System.Drawing.Color.White;
            this.btnCustomer.HoverState.Parent = this.btnCustomer;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCustomer.Location = new System.Drawing.Point(345, 17);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.ShadowDecoration.Parent = this.btnCustomer;
            this.btnCustomer.Size = new System.Drawing.Size(250, 85);
            this.btnCustomer.TabIndex = 3;
            this.btnCustomer.Text = "Thông tin khách hàng";
            this.btnCustomer.Click += new System.EventHandler(this.BtnCustomer_Click);
            // 
            // MovingPanel
            // 
            this.MovingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.MovingPanel.Location = new System.Drawing.Point(106, 108);
            this.MovingPanel.Name = "MovingPanel";
            this.MovingPanel.Size = new System.Drawing.Size(212, 5);
            this.MovingPanel.TabIndex = 0;
            // 
            // btnService
            // 
            this.btnService.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnService.BorderRadius = 26;
            this.btnService.BorderThickness = 1;
            this.btnService.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnService.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnService.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.btnService.CheckedState.Parent = this.btnService;
            this.btnService.CustomImages.Parent = this.btnService;
            this.btnService.FillColor = System.Drawing.Color.Transparent;
            this.btnService.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.ForeColor = System.Drawing.Color.White;
            this.btnService.HoverState.Parent = this.btnService;
            this.btnService.Image = ((System.Drawing.Image)(resources.GetObject("btnService.Image")));
            this.btnService.ImageSize = new System.Drawing.Size(40, 40);
            this.btnService.Location = new System.Drawing.Point(857, 17);
            this.btnService.Name = "btnService";
            this.btnService.ShadowDecoration.Parent = this.btnService;
            this.btnService.Size = new System.Drawing.Size(250, 85);
            this.btnService.TabIndex = 1;
            this.btnService.Text = "Dịch vụ";
            this.btnService.Click += new System.EventHandler(this.BtnService_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnEmployee.BorderRadius = 26;
            this.btnEmployee.BorderThickness = 1;
            this.btnEmployee.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnEmployee.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnEmployee.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.btnEmployee.CheckedState.Parent = this.btnEmployee;
            this.btnEmployee.CustomImages.Parent = this.btnEmployee;
            this.btnEmployee.FillColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.ForeColor = System.Drawing.Color.White;
            this.btnEmployee.HoverState.Parent = this.btnEmployee;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageSize = new System.Drawing.Size(40, 40);
            this.btnEmployee.Location = new System.Drawing.Point(601, 17);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.ShadowDecoration.Parent = this.btnEmployee;
            this.btnEmployee.Size = new System.Drawing.Size(250, 85);
            this.btnEmployee.TabIndex = 4;
            this.btnEmployee.Text = "Thông tin nhân viên";
            this.btnEmployee.Click += new System.EventHandler(this.BtnEmployee_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRoom.BorderRadius = 26;
            this.btnRoom.BorderThickness = 1;
            this.btnRoom.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRoom.Checked = true;
            this.btnRoom.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRoom.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(130)))), ((int)(((byte)(138)))));
            this.btnRoom.CheckedState.Parent = this.btnRoom;
            this.btnRoom.CustomImages.Parent = this.btnRoom;
            this.btnRoom.FillColor = System.Drawing.Color.Transparent;
            this.btnRoom.Font = new System.Drawing.Font("Constantia", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.ForeColor = System.Drawing.Color.White;
            this.btnRoom.HoverState.Parent = this.btnRoom;
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageSize = new System.Drawing.Size(40, 40);
            this.btnRoom.Location = new System.Drawing.Point(89, 17);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.ShadowDecoration.Parent = this.btnRoom;
            this.btnRoom.Size = new System.Drawing.Size(250, 85);
            this.btnRoom.TabIndex = 0;
            this.btnRoom.Text = "Quản lý phòng";
            this.btnRoom.Click += new System.EventHandler(this.BtnRoom_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.Transparent;
            this.MainPanel.Location = new System.Drawing.Point(0, 168);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1457, 716);
            this.MainPanel.TabIndex = 2;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this.MainPanel;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this.headerPanel;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this;
            // 
            // DashBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1457, 884);
            this.Controls.Add(this.guna2GradientPanel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1457, 884);
            this.MinimumSize = new System.Drawing.Size(1457, 884);
            this.Name = "DashBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DashBoard";
            this.guna2GradientPanel1.ResumeLayout(false);
            this.headerPanel.ResumeLayout(false);
            this.headerPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private System.Windows.Forms.Panel MovingPanel;
        private Guna.UI2.WinForms.Guna2Button btnEmployee;
        private Guna.UI2.WinForms.Guna2Button btnRoom;
        private System.Windows.Forms.Panel MainPanel;
        private System.ComponentModel.BackgroundWorker dataThread;
        private Guna.UI2.WinForms.Guna2ControlBox btnExit;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel headerPanel;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbTime;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2Button btnService;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
    }
}