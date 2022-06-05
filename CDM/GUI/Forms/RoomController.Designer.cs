
namespace GUI.Forms
{
    partial class RoomController
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Status = new System.Windows.Forms.Label();
            this.ServiceGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateCheckin = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.RoomNoText = new System.Windows.Forms.Label();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.RoomControlButton = new Guna.UI2.WinForms.Guna2Button();
            this.ServiceButton = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LightGray;
            this.guna2Panel1.Controls.Add(this.CustomerName);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel1.Controls.Add(this.Status);
            this.guna2Panel1.Controls.Add(this.ServiceGridView);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Controls.Add(this.DateCheckin);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 80);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(776, 280);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Status.Location = new System.Drawing.Point(55, 159);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(203, 30);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.ServiceGridView.BackgroundColor = System.Drawing.Color.White;
            this.ServiceGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ServiceGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServiceGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ServiceGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.ServiceGridView.ColumnHeadersHeight = 21;
            this.ServiceGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service,
            this.Number,
            this.TotalPrice});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ServiceGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.ServiceGridView.EnableHeadersVisualStyles = false;
            this.ServiceGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceGridView.Location = new System.Drawing.Point(350, 33);
            this.ServiceGridView.Name = "ServiceGridView";
            this.ServiceGridView.RowHeadersVisible = false;
            this.ServiceGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ServiceGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ServiceGridView.Size = new System.Drawing.Size(400, 215);
            this.ServiceGridView.TabIndex = 0;
            this.ServiceGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.ServiceGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ServiceGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ServiceGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ServiceGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ServiceGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ServiceGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ServiceGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ServiceGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ServiceGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ServiceGridView.ThemeStyle.HeaderStyle.Height = 21;
            this.ServiceGridView.ThemeStyle.ReadOnly = false;
            this.ServiceGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ServiceGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ServiceGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServiceGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ServiceGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ServiceGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ServiceGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Service
            // 
            this.Service.FillWeight = 185F;
            this.Service.HeaderText = "Dịch vụ";
            this.Service.Name = "Service";
            // 
            // Number
            // 
            this.Number.FillWeight = 85F;
            this.Number.HeaderText = "Số lượng";
            this.Number.Name = "Number";
            // 
            // TotalPrice
            // 
            this.TotalPrice.FillWeight = 125F;
            this.TotalPrice.HeaderText = "Thành tiền";
            this.TotalPrice.Name = "TotalPrice";
            // 
            // DateCheckin
            // 
            this.DateCheckin.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCheckin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DateCheckin.Location = new System.Drawing.Point(55, 115);
            this.DateCheckin.Name = "DateCheckin";
            this.DateCheckin.Size = new System.Drawing.Size(203, 30);
            this.DateCheckin.TabIndex = 2;
            this.DateCheckin.Text = "Date";
            this.DateCheckin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.guna2Panel1;
            // 
            // CloseButton
            // 
            this.CloseButton.BorderRadius = 15;
            this.CloseButton.CheckedState.Parent = this.CloseButton;
            this.CloseButton.CustomImages.Parent = this.CloseButton;
            this.CloseButton.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.HoverState.Parent = this.CloseButton;
            this.CloseButton.Location = new System.Drawing.Point(570, 383);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.ShadowDecoration.Parent = this.CloseButton;
            this.CloseButton.Size = new System.Drawing.Size(180, 45);
            this.CloseButton.TabIndex = 3;
            this.CloseButton.Text = "Thoát";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // RoomNoText
            // 
            this.RoomNoText.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoText.Location = new System.Drawing.Point(50, 14);
            this.RoomNoText.Name = "RoomNoText";
            this.RoomNoText.Size = new System.Drawing.Size(700, 51);
            this.RoomNoText.TabIndex = 2;
            this.RoomNoText.Text = "Tên phòng";
            this.RoomNoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            this.guna2Elipse3.TargetControl = this.ServiceGridView;
            // 
            // RoomControlButton
            // 
            this.RoomControlButton.BorderRadius = 15;
            this.RoomControlButton.CheckedState.Parent = this.RoomControlButton;
            this.RoomControlButton.CustomImages.Parent = this.RoomControlButton;
            this.RoomControlButton.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.RoomControlButton.ForeColor = System.Drawing.Color.White;
            this.RoomControlButton.HoverState.Parent = this.RoomControlButton;
            this.RoomControlButton.Location = new System.Drawing.Point(384, 383);
            this.RoomControlButton.Name = "RoomControlButton";
            this.RoomControlButton.ShadowDecoration.Parent = this.RoomControlButton;
            this.RoomControlButton.Size = new System.Drawing.Size(180, 45);
            this.RoomControlButton.TabIndex = 2;
            this.RoomControlButton.Text = "Nhận phòng";
            this.RoomControlButton.Click += new System.EventHandler(this.RoomControlButton_Click);
            // 
            // ServiceButton
            // 
            this.ServiceButton.BorderRadius = 15;
            this.ServiceButton.CheckedState.Parent = this.ServiceButton;
            this.ServiceButton.CustomImages.Parent = this.ServiceButton;
            this.ServiceButton.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.ServiceButton.ForeColor = System.Drawing.Color.White;
            this.ServiceButton.HoverState.Parent = this.ServiceButton;
            this.ServiceButton.Location = new System.Drawing.Point(198, 383);
            this.ServiceButton.Name = "ServiceButton";
            this.ServiceButton.ShadowDecoration.Parent = this.ServiceButton;
            this.ServiceButton.Size = new System.Drawing.Size(180, 45);
            this.ServiceButton.TabIndex = 1;
            this.ServiceButton.Text = "Dịch vụ";
            // 
            // CustomerName
            // 
            this.CustomerName.BackColor = System.Drawing.Color.Transparent;
            this.CustomerName.BorderRadius = 15;
            this.CustomerName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CustomerName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustomerName.FocusedColor = System.Drawing.Color.Empty;
            this.CustomerName.FocusedState.Parent = this.CustomerName;
            this.CustomerName.Font = new System.Drawing.Font("Constantia", 12F);
            this.CustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CustomerName.FormattingEnabled = true;
            this.CustomerName.HoverState.Parent = this.CustomerName;
            this.CustomerName.ItemHeight = 30;
            this.CustomerName.ItemsAppearance.Parent = this.CustomerName;
            this.CustomerName.Location = new System.Drawing.Point(59, 68);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ShadowDecoration.Parent = this.CustomerName;
            this.CustomerName.Size = new System.Drawing.Size(199, 36);
            this.CustomerName.TabIndex = 7;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::GUI.Properties.Resources._checked;
            this.guna2PictureBox3.Location = new System.Drawing.Point(19, 159);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.ShadowDecoration.Parent = this.guna2PictureBox3;
            this.guna2PictureBox3.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox3.TabIndex = 6;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = global::GUI.Properties.Resources.schedule;
            this.guna2PictureBox2.Location = new System.Drawing.Point(19, 115);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 3;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::GUI.Properties.Resources.user;
            this.guna2PictureBox1.Location = new System.Drawing.Point(19, 71);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(30, 30);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // RoomController
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ServiceButton);
            this.Controls.Add(this.RoomControlButton);
            this.Controls.Add(this.RoomNoText);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoomController";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RoomController";
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
        private System.Windows.Forms.Label RoomNoText;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label DateCheckin;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Button ServiceButton;
        private Guna.UI2.WinForms.Guna2Button RoomControlButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label Status;
        private Guna.UI2.WinForms.Guna2DataGridView ServiceGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2ComboBox CustomerName;
    }
}