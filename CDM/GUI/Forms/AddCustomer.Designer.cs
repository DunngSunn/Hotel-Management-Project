
namespace GUI.Forms
{
    partial class AddCustomer
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
            this.RoomNoText = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.NameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.NationalText = new Guna.UI2.WinForms.Guna2TextBox();
            this.MobileText = new Guna.UI2.WinForms.Guna2TextBox();
            this.CCCDText = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddressText = new Guna.UI2.WinForms.Guna2TextBox();
            this.DateOfBirth = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RoomNoText
            // 
            this.RoomNoText.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoText.Location = new System.Drawing.Point(12, 9);
            this.RoomNoText.Name = "RoomNoText";
            this.RoomNoText.Size = new System.Drawing.Size(560, 51);
            this.RoomNoText.TabIndex = 4;
            this.RoomNoText.Text = "Thêm khách hàng";
            this.RoomNoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2Panel1.Controls.Add(this.AddButton);
            this.guna2Panel1.Controls.Add(this.CancelButton);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.Gender);
            this.guna2Panel1.Controls.Add(this.DateOfBirth);
            this.guna2Panel1.Controls.Add(this.AddressText);
            this.guna2Panel1.Controls.Add(this.CCCDText);
            this.guna2Panel1.Controls.Add(this.MobileText);
            this.guna2Panel1.Controls.Add(this.NationalText);
            this.guna2Panel1.Controls.Add(this.NameText);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 63);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(560, 406);
            this.guna2Panel1.TabIndex = 5;
            // 
            // NameText
            // 
            this.NameText.BackColor = System.Drawing.Color.Transparent;
            this.NameText.BorderColor = System.Drawing.Color.LightGray;
            this.NameText.BorderRadius = 18;
            this.NameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameText.DefaultText = "";
            this.NameText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.DisabledState.Parent = this.NameText;
            this.NameText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.FocusedState.Parent = this.NameText;
            this.NameText.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameText.HoverState.Parent = this.NameText;
            this.NameText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.NameText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.NameText.Location = new System.Drawing.Point(182, 21);
            this.NameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NameText.Name = "NameText";
            this.NameText.PasswordChar = '\0';
            this.NameText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.NameText.PlaceholderText = "Tên khách hàng";
            this.NameText.SelectedText = "";
            this.NameText.ShadowDecoration.Parent = this.NameText;
            this.NameText.Size = new System.Drawing.Size(326, 36);
            this.NameText.TabIndex = 0;
            // 
            // NationalText
            // 
            this.NationalText.BackColor = System.Drawing.Color.Transparent;
            this.NationalText.BorderColor = System.Drawing.Color.LightGray;
            this.NationalText.BorderRadius = 18;
            this.NationalText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NationalText.DefaultText = "";
            this.NationalText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NationalText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NationalText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NationalText.DisabledState.Parent = this.NationalText;
            this.NationalText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NationalText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NationalText.FocusedState.Parent = this.NationalText;
            this.NationalText.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NationalText.HoverState.Parent = this.NationalText;
            this.NationalText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.NationalText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.NationalText.Location = new System.Drawing.Point(182, 289);
            this.NationalText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.NationalText.Name = "NationalText";
            this.NationalText.PasswordChar = '\0';
            this.NationalText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.NationalText.PlaceholderText = "Quốc tịch";
            this.NationalText.SelectedText = "";
            this.NationalText.ShadowDecoration.Parent = this.NationalText;
            this.NationalText.Size = new System.Drawing.Size(326, 36);
            this.NationalText.TabIndex = 6;
            // 
            // MobileText
            // 
            this.MobileText.BackColor = System.Drawing.Color.Transparent;
            this.MobileText.BorderColor = System.Drawing.Color.LightGray;
            this.MobileText.BorderRadius = 18;
            this.MobileText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MobileText.DefaultText = "";
            this.MobileText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.MobileText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.MobileText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MobileText.DisabledState.Parent = this.MobileText;
            this.MobileText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.MobileText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MobileText.FocusedState.Parent = this.MobileText;
            this.MobileText.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MobileText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.MobileText.HoverState.Parent = this.MobileText;
            this.MobileText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.MobileText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.MobileText.Location = new System.Drawing.Point(182, 197);
            this.MobileText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MobileText.Name = "MobileText";
            this.MobileText.PasswordChar = '\0';
            this.MobileText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.MobileText.PlaceholderText = "Số điện thoại";
            this.MobileText.SelectedText = "";
            this.MobileText.ShadowDecoration.Parent = this.MobileText;
            this.MobileText.Size = new System.Drawing.Size(326, 36);
            this.MobileText.TabIndex = 4;
            // 
            // CCCDText
            // 
            this.CCCDText.BackColor = System.Drawing.Color.Transparent;
            this.CCCDText.BorderColor = System.Drawing.Color.LightGray;
            this.CCCDText.BorderRadius = 18;
            this.CCCDText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CCCDText.DefaultText = "";
            this.CCCDText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CCCDText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CCCDText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CCCDText.DisabledState.Parent = this.CCCDText;
            this.CCCDText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CCCDText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CCCDText.FocusedState.Parent = this.CCCDText;
            this.CCCDText.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CCCDText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CCCDText.HoverState.Parent = this.CCCDText;
            this.CCCDText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.CCCDText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.CCCDText.Location = new System.Drawing.Point(182, 243);
            this.CCCDText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CCCDText.Name = "CCCDText";
            this.CCCDText.PasswordChar = '\0';
            this.CCCDText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.CCCDText.PlaceholderText = "CMT/CCCD";
            this.CCCDText.SelectedText = "";
            this.CCCDText.ShadowDecoration.Parent = this.CCCDText;
            this.CCCDText.Size = new System.Drawing.Size(326, 36);
            this.CCCDText.TabIndex = 5;
            // 
            // AddressText
            // 
            this.AddressText.BackColor = System.Drawing.Color.Transparent;
            this.AddressText.BorderColor = System.Drawing.Color.LightGray;
            this.AddressText.BorderRadius = 18;
            this.AddressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressText.DefaultText = "";
            this.AddressText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.AddressText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.AddressText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressText.DisabledState.Parent = this.AddressText;
            this.AddressText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.AddressText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressText.FocusedState.Parent = this.AddressText;
            this.AddressText.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddressText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.AddressText.HoverState.Parent = this.AddressText;
            this.AddressText.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.AddressText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.AddressText.Location = new System.Drawing.Point(182, 151);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddressText.Name = "AddressText";
            this.AddressText.PasswordChar = '\0';
            this.AddressText.PlaceholderForeColor = System.Drawing.Color.Black;
            this.AddressText.PlaceholderText = "Địa chỉ";
            this.AddressText.SelectedText = "";
            this.AddressText.ShadowDecoration.Parent = this.AddressText;
            this.AddressText.Size = new System.Drawing.Size(326, 36);
            this.AddressText.TabIndex = 3;
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.BorderRadius = 18;
            this.DateOfBirth.CheckedState.Parent = this.DateOfBirth;
            this.DateOfBirth.FillColor = System.Drawing.Color.White;
            this.DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateOfBirth.HoverState.Parent = this.DateOfBirth;
            this.DateOfBirth.Location = new System.Drawing.Point(182, 65);
            this.DateOfBirth.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DateOfBirth.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.ShadowDecoration.Parent = this.DateOfBirth;
            this.DateOfBirth.Size = new System.Drawing.Size(326, 36);
            this.DateOfBirth.TabIndex = 1;
            this.DateOfBirth.Value = new System.DateTime(2022, 5, 29, 2, 47, 39, 570);
            // 
            // Gender
            // 
            this.Gender.Animated = true;
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.BorderRadius = 18;
            this.Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.FocusedColor = System.Drawing.Color.Empty;
            this.Gender.FocusedState.Parent = this.Gender;
            this.Gender.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.Gender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.Gender.FormattingEnabled = true;
            this.Gender.HoverState.Parent = this.Gender;
            this.Gender.ItemHeight = 30;
            this.Gender.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.Gender.ItemsAppearance.Parent = this.Gender;
            this.Gender.Location = new System.Drawing.Point(182, 107);
            this.Gender.Name = "Gender";
            this.Gender.ShadowDecoration.Parent = this.Gender;
            this.Gender.Size = new System.Drawing.Size(326, 36);
            this.Gender.StartIndex = 0;
            this.Gender.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên khách hàng:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(51, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ngày sinh:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(50, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 39;
            this.label3.Text = "Địa chỉ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(51, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 36);
            this.label4.TabIndex = 38;
            this.label4.Text = "Giới tính:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(50, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 36);
            this.label5.TabIndex = 41;
            this.label5.Text = "CMT/CCCD:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(50, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 36);
            this.label6.TabIndex = 40;
            this.label6.Text = "Số điện thoại:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(50, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 36);
            this.label7.TabIndex = 42;
            this.label7.Text = "Quốc tịch:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CancelButton
            // 
            this.CancelButton.BorderRadius = 18;
            this.CancelButton.CheckedState.Parent = this.CancelButton;
            this.CancelButton.CustomImages.Parent = this.CancelButton;
            this.CancelButton.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelButton.ForeColor = System.Drawing.Color.White;
            this.CancelButton.HoverState.Parent = this.CancelButton;
            this.CancelButton.Location = new System.Drawing.Point(328, 342);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.ShadowDecoration.Parent = this.CancelButton;
            this.CancelButton.Size = new System.Drawing.Size(180, 45);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Huỷ";
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.BorderRadius = 18;
            this.AddButton.CheckedState.Parent = this.AddButton;
            this.AddButton.CustomImages.Parent = this.AddButton;
            this.AddButton.Font = new System.Drawing.Font("Constantia", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddButton.ForeColor = System.Drawing.Color.White;
            this.AddButton.HoverState.Parent = this.AddButton;
            this.AddButton.Location = new System.Drawing.Point(142, 342);
            this.AddButton.Name = "AddButton";
            this.AddButton.ShadowDecoration.Parent = this.AddButton;
            this.AddButton.Size = new System.Drawing.Size(180, 45);
            this.AddButton.TabIndex = 7;
            this.AddButton.Text = "Thêm";
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.RoomNoText);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddCustomer";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label RoomNoText;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox NationalText;
        private Guna.UI2.WinForms.Guna2TextBox NameText;
        private Guna.UI2.WinForms.Guna2DateTimePicker DateOfBirth;
        private Guna.UI2.WinForms.Guna2TextBox AddressText;
        private Guna.UI2.WinForms.Guna2TextBox CCCDText;
        private Guna.UI2.WinForms.Guna2TextBox MobileText;
        private Guna.UI2.WinForms.Guna2ComboBox Gender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private new Guna.UI2.WinForms.Guna2Button CancelButton;
        private Guna.UI2.WinForms.Guna2Button AddButton;
    }
}