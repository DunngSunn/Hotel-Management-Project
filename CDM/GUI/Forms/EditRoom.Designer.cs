
namespace GUI.Forms
{
    partial class EditRoom
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.CancelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RoomType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.RoomBed = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoomPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoomNo = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoomNoText = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2Panel1.Controls.Add(this.AddButton);
            this.guna2Panel1.Controls.Add(this.CancelBtn);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.RoomType);
            this.guna2Panel1.Controls.Add(this.RoomBed);
            this.guna2Panel1.Controls.Add(this.RoomPrice);
            this.guna2Panel1.Controls.Add(this.RoomNo);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 67);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(560, 267);
            this.guna2Panel1.TabIndex = 9;
            // 
            // AddButton
            // 
            this.AddButton.BorderRadius = 18;
            this.AddButton.CheckedState.Parent = this.AddButton;
            this.AddButton.CustomImages.Parent = this.AddButton;
            this.AddButton.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.HoverState.Parent = this.AddButton;
            this.AddButton.Location = new System.Drawing.Point(142, 199);
            this.AddButton.Name = "AddButton";
            this.AddButton.ShadowDecoration.Parent = this.AddButton;
            this.AddButton.Size = new System.Drawing.Size(180, 45);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Sửa";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // CancelButton
            // 
            this.CancelBtn.BorderRadius = 18;
            this.CancelBtn.CheckedState.Parent = this.CancelBtn;
            this.CancelBtn.CustomImages.Parent = this.CancelBtn;
            this.CancelBtn.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.HoverState.Parent = this.CancelBtn;
            this.CancelBtn.Location = new System.Drawing.Point(328, 199);
            this.CancelBtn.Name = "CancelButton";
            this.CancelBtn.ShadowDecoration.Parent = this.CancelBtn;
            this.CancelBtn.Size = new System.Drawing.Size(180, 45);
            this.CancelBtn.TabIndex = 5;
            this.CancelBtn.Text = "Huỷ";
            this.CancelBtn.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(50, 155);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 36);
            this.label6.TabIndex = 40;
            this.label6.Text = "Giá tiền:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(50, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 39;
            this.label3.Text = "Loại giường:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(51, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 36);
            this.label4.TabIndex = 38;
            this.label4.Text = "Loại phòng:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên phòng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RoomType
            // 
            this.RoomType.Animated = true;
            this.RoomType.BackColor = System.Drawing.Color.Transparent;
            this.RoomType.BorderRadius = 18;
            this.RoomType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoomType.FocusedColor = System.Drawing.Color.Empty;
            this.RoomType.FocusedState.Parent = this.RoomType;
            this.RoomType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.RoomType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.RoomType.FormattingEnabled = true;
            this.RoomType.HoverState.Parent = this.RoomType;
            this.RoomType.ItemHeight = 30;
            this.RoomType.Items.AddRange(new object[] {
            "Phòng đơn",
            "Phòng đôi",
            "Phòng gia đình"});
            this.RoomType.ItemsAppearance.Parent = this.RoomType;
            this.RoomType.Location = new System.Drawing.Point(182, 65);
            this.RoomType.Name = "RoomType";
            this.RoomType.ShadowDecoration.Parent = this.RoomType;
            this.RoomType.Size = new System.Drawing.Size(326, 36);
            this.RoomType.StartIndex = 1;
            this.RoomType.TabIndex = 1;
            // 
            // RoomBed
            // 
            this.RoomBed.BackColor = System.Drawing.Color.Transparent;
            this.RoomBed.BorderColor = System.Drawing.Color.LightGray;
            this.RoomBed.BorderRadius = 18;
            this.RoomBed.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomBed.DefaultText = "";
            this.RoomBed.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RoomBed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RoomBed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomBed.DisabledState.Parent = this.RoomBed;
            this.RoomBed.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomBed.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomBed.FocusedState.Parent = this.RoomBed;
            this.RoomBed.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomBed.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomBed.HoverState.Parent = this.RoomBed;
            this.RoomBed.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.RoomBed.IconLeftSize = new System.Drawing.Size(30, 30);
            this.RoomBed.Location = new System.Drawing.Point(182, 109);
            this.RoomBed.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomBed.Name = "RoomBed";
            this.RoomBed.PasswordChar = '\0';
            this.RoomBed.PlaceholderForeColor = System.Drawing.Color.Black;
            this.RoomBed.PlaceholderText = "Loại giường";
            this.RoomBed.SelectedText = "";
            this.RoomBed.ShadowDecoration.Parent = this.RoomBed;
            this.RoomBed.Size = new System.Drawing.Size(326, 36);
            this.RoomBed.TabIndex = 2;
            // 
            // RoomPrice
            // 
            this.RoomPrice.BackColor = System.Drawing.Color.Transparent;
            this.RoomPrice.BorderColor = System.Drawing.Color.LightGray;
            this.RoomPrice.BorderRadius = 18;
            this.RoomPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomPrice.DefaultText = "";
            this.RoomPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RoomPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RoomPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomPrice.DisabledState.Parent = this.RoomPrice;
            this.RoomPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomPrice.FocusedState.Parent = this.RoomPrice;
            this.RoomPrice.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomPrice.HoverState.Parent = this.RoomPrice;
            this.RoomPrice.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.RoomPrice.IconLeftSize = new System.Drawing.Size(30, 30);
            this.RoomPrice.Location = new System.Drawing.Point(182, 155);
            this.RoomPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomPrice.Name = "RoomPrice";
            this.RoomPrice.PasswordChar = '\0';
            this.RoomPrice.PlaceholderForeColor = System.Drawing.Color.Black;
            this.RoomPrice.PlaceholderText = "Giá tiền";
            this.RoomPrice.SelectedText = "";
            this.RoomPrice.ShadowDecoration.Parent = this.RoomPrice;
            this.RoomPrice.Size = new System.Drawing.Size(326, 36);
            this.RoomPrice.TabIndex = 3;
            // 
            // RoomNo
            // 
            this.RoomNo.BackColor = System.Drawing.Color.Transparent;
            this.RoomNo.BorderColor = System.Drawing.Color.LightGray;
            this.RoomNo.BorderRadius = 18;
            this.RoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RoomNo.DefaultText = "";
            this.RoomNo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.RoomNo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.RoomNo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomNo.DisabledState.Parent = this.RoomNo;
            this.RoomNo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.RoomNo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNo.FocusedState.Parent = this.RoomNo;
            this.RoomNo.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.RoomNo.HoverState.Parent = this.RoomNo;
            this.RoomNo.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.RoomNo.IconLeftSize = new System.Drawing.Size(30, 30);
            this.RoomNo.Location = new System.Drawing.Point(182, 21);
            this.RoomNo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RoomNo.Name = "RoomNo";
            this.RoomNo.PasswordChar = '\0';
            this.RoomNo.PlaceholderForeColor = System.Drawing.Color.Black;
            this.RoomNo.PlaceholderText = "Tên phòng";
            this.RoomNo.SelectedText = "";
            this.RoomNo.ShadowDecoration.Parent = this.RoomNo;
            this.RoomNo.Size = new System.Drawing.Size(326, 36);
            this.RoomNo.TabIndex = 0;
            // 
            // RoomNoText
            // 
            this.RoomNoText.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoText.Location = new System.Drawing.Point(12, 13);
            this.RoomNoText.Name = "RoomNoText";
            this.RoomNoText.Size = new System.Drawing.Size(560, 51);
            this.RoomNoText.TabIndex = 8;
            this.RoomNoText.Text = "Sửa phòng";
            this.RoomNoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditRoom
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 347);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.RoomNoText);
            this.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditRoom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditRoom";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button AddButton;
        private Guna.UI2.WinForms.Guna2Button CancelBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox RoomType;
        private Guna.UI2.WinForms.Guna2TextBox RoomBed;
        private Guna.UI2.WinForms.Guna2TextBox RoomPrice;
        private Guna.UI2.WinForms.Guna2TextBox RoomNo;
        private System.Windows.Forms.Label RoomNoText;
    }
}