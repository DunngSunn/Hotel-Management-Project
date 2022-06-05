
namespace GUI.UserCustoms
{
    partial class RoomUC
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
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TextName = new System.Windows.Forms.Label();
            this.TextStatus = new System.Windows.Forms.Label();
            this.PictureStatus = new Guna.UI2.WinForms.Guna2PictureBox();
            this.Delete = new Guna.UI2.WinForms.Guna2Button();
            this.Edit = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.PictureStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this;
            // 
            // TextName
            // 
            this.TextName.AutoSize = true;
            this.TextName.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextName.Location = new System.Drawing.Point(16, 25);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(105, 23);
            this.TextName.TabIndex = 0;
            this.TextName.Text = "Tên phòng";
            this.TextName.Click += new System.EventHandler(this.RoomUC_Click);
            // 
            // TextStatus
            // 
            this.TextStatus.AutoSize = true;
            this.TextStatus.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextStatus.Location = new System.Drawing.Point(87, 83);
            this.TextStatus.Name = "TextStatus";
            this.TextStatus.Size = new System.Drawing.Size(120, 23);
            this.TextStatus.TabIndex = 3;
            this.TextStatus.Text = "Phòng trống";
            this.TextStatus.Click += new System.EventHandler(this.RoomUC_Click);
            // 
            // PictureStatus
            // 
            this.PictureStatus.Image = global::GUI.Properties.Resources._checked;
            this.PictureStatus.Location = new System.Drawing.Point(20, 70);
            this.PictureStatus.Name = "PictureStatus";
            this.PictureStatus.ShadowDecoration.Parent = this.PictureStatus;
            this.PictureStatus.Size = new System.Drawing.Size(50, 50);
            this.PictureStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureStatus.TabIndex = 2;
            this.PictureStatus.TabStop = false;
            this.PictureStatus.Click += new System.EventHandler(this.RoomUC_Click);
            // 
            // Delete
            // 
            this.Delete.BorderRadius = 15;
            this.Delete.CheckedState.Parent = this.Delete;
            this.Delete.CustomImages.Parent = this.Delete;
            this.Delete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.HoverState.Parent = this.Delete;
            this.Delete.Image = global::GUI.Properties.Resources.delete_button;
            this.Delete.Location = new System.Drawing.Point(184, 3);
            this.Delete.Name = "Delete";
            this.Delete.ShadowDecoration.Parent = this.Delete;
            this.Delete.Size = new System.Drawing.Size(35, 35);
            this.Delete.TabIndex = 4;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BorderRadius = 15;
            this.Edit.CheckedState.Parent = this.Edit;
            this.Edit.CustomImages.Parent = this.Edit;
            this.Edit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.HoverState.Parent = this.Edit;
            this.Edit.Image = global::GUI.Properties.Resources.edit;
            this.Edit.Location = new System.Drawing.Point(143, 3);
            this.Edit.Name = "Edit";
            this.Edit.ShadowDecoration.Parent = this.Edit;
            this.Edit.Size = new System.Drawing.Size(35, 35);
            this.Edit.TabIndex = 5;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // RoomUC
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.TextStatus);
            this.Controls.Add(this.PictureStatus);
            this.Controls.Add(this.TextName);
            this.DoubleBuffered = true;
            this.Name = "RoomUC";
            this.Size = new System.Drawing.Size(222, 155);
            this.Click += new System.EventHandler(this.RoomUC_Click);
            ((System.ComponentModel.ISupportInitialize)(this.PictureStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label TextName;
        private Guna.UI2.WinForms.Guna2PictureBox PictureStatus;
        private System.Windows.Forms.Label TextStatus;
        private Guna.UI2.WinForms.Guna2Button Edit;
        private Guna.UI2.WinForms.Guna2Button Delete;
    }
}
