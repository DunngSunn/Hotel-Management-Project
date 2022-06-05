
namespace GUI.Forms
{
    partial class AddEmployeeUC
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
            this.AddButton = new Guna.UI2.WinForms.Guna2Button();
            this.CancelButton = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Gender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.Address = new Guna.UI2.WinForms.Guna2TextBox();
            this.User = new Guna.UI2.WinForms.Guna2TextBox();
            this.Email = new Guna.UI2.WinForms.Guna2TextBox();
            this.Pass = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Mobile = new Guna.UI2.WinForms.Guna2TextBox();
            this.RoomNoText = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
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
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(50, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 36);
            this.label7.TabIndex = 42;
            this.label7.Text = "Mật khẩu:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(50, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 36);
            this.label5.TabIndex = 41;
            this.label5.Text = "Tài khoản:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(50, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 36);
            this.label6.TabIndex = 40;
            this.label6.Text = "Email:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(50, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 36);
            this.label3.TabIndex = 39;
            this.label3.Text = "Địa chỉ:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(51, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 36);
            this.label4.TabIndex = 38;
            this.label4.Text = "Giới tính:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(50, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 36);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên nhân viên:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.Gender.Location = new System.Drawing.Point(182, 65);
            this.Gender.Name = "Gender";
            this.Gender.ShadowDecoration.Parent = this.Gender;
            this.Gender.Size = new System.Drawing.Size(326, 36);
            this.Gender.StartIndex = 0;
            this.Gender.TabIndex = 1;
            // 
            // Address
            // 
            this.Address.BackColor = System.Drawing.Color.Transparent;
            this.Address.BorderColor = System.Drawing.Color.LightGray;
            this.Address.BorderRadius = 18;
            this.Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address.DefaultText = "";
            this.Address.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Address.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Address.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address.DisabledState.Parent = this.Address;
            this.Address.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Address.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address.FocusedState.Parent = this.Address;
            this.Address.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Address.HoverState.Parent = this.Address;
            this.Address.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.Address.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Address.Location = new System.Drawing.Point(182, 197);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Address.Name = "Address";
            this.Address.PasswordChar = '\0';
            this.Address.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Address.PlaceholderText = "Địa chỉ";
            this.Address.SelectedText = "";
            this.Address.ShadowDecoration.Parent = this.Address;
            this.Address.Size = new System.Drawing.Size(326, 36);
            this.Address.TabIndex = 4;
            // 
            // User
            // 
            this.User.BackColor = System.Drawing.Color.Transparent;
            this.User.BorderColor = System.Drawing.Color.LightGray;
            this.User.BorderRadius = 18;
            this.User.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.User.DefaultText = "";
            this.User.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.User.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.User.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User.DisabledState.Parent = this.User;
            this.User.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.User.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User.FocusedState.Parent = this.User;
            this.User.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.User.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.User.HoverState.Parent = this.User;
            this.User.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.User.IconLeftSize = new System.Drawing.Size(30, 30);
            this.User.Location = new System.Drawing.Point(182, 243);
            this.User.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.User.Name = "User";
            this.User.PasswordChar = '\0';
            this.User.PlaceholderForeColor = System.Drawing.Color.Black;
            this.User.PlaceholderText = "Tài khoản";
            this.User.SelectedText = "";
            this.User.ShadowDecoration.Parent = this.User;
            this.User.Size = new System.Drawing.Size(326, 36);
            this.User.TabIndex = 5;
            // 
            // Email
            // 
            this.Email.BackColor = System.Drawing.Color.Transparent;
            this.Email.BorderColor = System.Drawing.Color.LightGray;
            this.Email.BorderRadius = 18;
            this.Email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Email.DefaultText = "";
            this.Email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.DisabledState.Parent = this.Email;
            this.Email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.FocusedState.Parent = this.Email;
            this.Email.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Email.HoverState.Parent = this.Email;
            this.Email.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.Email.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Email.Location = new System.Drawing.Point(182, 153);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Email.Name = "Email";
            this.Email.PasswordChar = '\0';
            this.Email.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Email.PlaceholderText = "Email";
            this.Email.SelectedText = "";
            this.Email.ShadowDecoration.Parent = this.Email;
            this.Email.Size = new System.Drawing.Size(326, 36);
            this.Email.TabIndex = 3;
            // 
            // Pass
            // 
            this.Pass.BackColor = System.Drawing.Color.Transparent;
            this.Pass.BorderColor = System.Drawing.Color.LightGray;
            this.Pass.BorderRadius = 18;
            this.Pass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Pass.DefaultText = "";
            this.Pass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Pass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Pass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pass.DisabledState.Parent = this.Pass;
            this.Pass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Pass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pass.FocusedState.Parent = this.Pass;
            this.Pass.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Pass.HoverState.Parent = this.Pass;
            this.Pass.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.Pass.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Pass.Location = new System.Drawing.Point(182, 289);
            this.Pass.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Pass.Name = "Pass";
            this.Pass.PasswordChar = '\0';
            this.Pass.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Pass.PlaceholderText = "Mật khẩu";
            this.Pass.SelectedText = "";
            this.Pass.ShadowDecoration.Parent = this.Pass;
            this.Pass.Size = new System.Drawing.Size(326, 36);
            this.Pass.TabIndex = 6;
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
            this.NameText.PlaceholderText = "Tên nhân viên";
            this.NameText.SelectedText = "";
            this.NameText.ShadowDecoration.Parent = this.NameText;
            this.NameText.Size = new System.Drawing.Size(326, 36);
            this.NameText.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.Mobile);
            this.guna2Panel1.Controls.Add(this.AddButton);
            this.guna2Panel1.Controls.Add(this.CancelButton);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.Gender);
            this.guna2Panel1.Controls.Add(this.Address);
            this.guna2Panel1.Controls.Add(this.User);
            this.guna2Panel1.Controls.Add(this.Email);
            this.guna2Panel1.Controls.Add(this.Pass);
            this.guna2Panel1.Controls.Add(this.NameText);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 64);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(560, 406);
            this.guna2Panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(50, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 36);
            this.label2.TabIndex = 44;
            this.label2.Text = "Số điện thoại:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Mobile
            // 
            this.Mobile.BackColor = System.Drawing.Color.Transparent;
            this.Mobile.BorderColor = System.Drawing.Color.LightGray;
            this.Mobile.BorderRadius = 18;
            this.Mobile.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Mobile.DefaultText = "";
            this.Mobile.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Mobile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Mobile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Mobile.DisabledState.Parent = this.Mobile;
            this.Mobile.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Mobile.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Mobile.FocusedState.Parent = this.Mobile;
            this.Mobile.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mobile.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Mobile.HoverState.Parent = this.Mobile;
            this.Mobile.IconLeftOffset = new System.Drawing.Point(10, 0);
            this.Mobile.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Mobile.Location = new System.Drawing.Point(182, 108);
            this.Mobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Mobile.Name = "Mobile";
            this.Mobile.PasswordChar = '\0';
            this.Mobile.PlaceholderForeColor = System.Drawing.Color.Black;
            this.Mobile.PlaceholderText = "Số điện thoại";
            this.Mobile.SelectedText = "";
            this.Mobile.ShadowDecoration.Parent = this.Mobile;
            this.Mobile.Size = new System.Drawing.Size(326, 36);
            this.Mobile.TabIndex = 2;
            // 
            // RoomNoText
            // 
            this.RoomNoText.Font = new System.Drawing.Font("Constantia", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoomNoText.Location = new System.Drawing.Point(12, 10);
            this.RoomNoText.Name = "RoomNoText";
            this.RoomNoText.Size = new System.Drawing.Size(560, 51);
            this.RoomNoText.TabIndex = 6;
            this.RoomNoText.Text = "Thêm nhân viên";
            this.RoomNoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmployeeUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 481);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.RoomNoText);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Constantia", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddEmployeeUC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button AddButton;
        private new Guna.UI2.WinForms.Guna2Button CancelButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox Gender;
        private Guna.UI2.WinForms.Guna2TextBox Address;
        private Guna.UI2.WinForms.Guna2TextBox User;
        private Guna.UI2.WinForms.Guna2TextBox Email;
        private Guna.UI2.WinForms.Guna2TextBox Pass;
        private Guna.UI2.WinForms.Guna2TextBox NameText;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label RoomNoText;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox Mobile;
    }
}