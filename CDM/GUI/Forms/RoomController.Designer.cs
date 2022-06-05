
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Status = new System.Windows.Forms.Label();
            this.DateCheckin = new System.Windows.Forms.Label();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.RoomNoText = new System.Windows.Forms.Label();
            this.guna2Elipse3 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.RoomControlButton = new Guna.UI2.WinForms.Guna2Button();
            this.CustomerName = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2Panel1.SuspendLayout();
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
            this.guna2Panel1.Controls.Add(this.guna2PictureBox2);
            this.guna2Panel1.Controls.Add(this.DateCheckin);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Location = new System.Drawing.Point(12, 80);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(419, 280);
            this.guna2Panel1.TabIndex = 0;
            // 
            // Status
            // 
            this.Status.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Status.Location = new System.Drawing.Point(112, 164);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(203, 30);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DateCheckin
            // 
            this.DateCheckin.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateCheckin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DateCheckin.Location = new System.Drawing.Point(112, 120);
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
            this.CloseButton.Location = new System.Drawing.Point(251, 381);
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
            this.RoomNoText.Size = new System.Drawing.Size(331, 51);
            this.RoomNoText.TabIndex = 2;
            this.RoomNoText.Text = "Tên phòng";
            this.RoomNoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2Elipse3
            // 
            this.guna2Elipse3.BorderRadius = 15;
            // 
            // RoomControlButton
            // 
            this.RoomControlButton.BorderRadius = 15;
            this.RoomControlButton.CheckedState.Parent = this.RoomControlButton;
            this.RoomControlButton.CustomImages.Parent = this.RoomControlButton;
            this.RoomControlButton.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold);
            this.RoomControlButton.ForeColor = System.Drawing.Color.White;
            this.RoomControlButton.HoverState.Parent = this.RoomControlButton;
            this.RoomControlButton.Location = new System.Drawing.Point(65, 381);
            this.RoomControlButton.Name = "RoomControlButton";
            this.RoomControlButton.ShadowDecoration.Parent = this.RoomControlButton;
            this.RoomControlButton.Size = new System.Drawing.Size(180, 45);
            this.RoomControlButton.TabIndex = 2;
            this.RoomControlButton.Text = "Nhận phòng";
            this.RoomControlButton.Click += new System.EventHandler(this.RoomControlButton_Click);
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
            this.CustomerName.Location = new System.Drawing.Point(116, 73);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ShadowDecoration.Parent = this.CustomerName;
            this.CustomerName.Size = new System.Drawing.Size(199, 36);
            this.CustomerName.TabIndex = 7;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = global::GUI.Properties.Resources._checked;
            this.guna2PictureBox3.Location = new System.Drawing.Point(76, 164);
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
            this.guna2PictureBox2.Location = new System.Drawing.Point(76, 120);
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
            this.guna2PictureBox1.Location = new System.Drawing.Point(76, 76);
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
            this.ClientSize = new System.Drawing.Size(446, 450);
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
        private Guna.UI2.WinForms.Guna2Button RoomControlButton;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label Status;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse3;
        private Guna.UI2.WinForms.Guna2ComboBox CustomerName;
    }
}