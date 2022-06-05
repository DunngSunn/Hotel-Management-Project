using BUS.Bussiness;
using System;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class LoginForm : Form
    {
        private Loading loadingForm;

        public LoginForm()
        {
            InitializeComponent();
        }

        #region Events

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtAccount.Text.Trim().Equals("") || txtPassword.Text.Trim().Equals(""))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo");
            }
            else
            {
                var existingAccount = AccountBUS.GetExistingAccount(txtAccount.Text.Trim(), txtPassword.Text.Trim());
                if (existingAccount)
                {
                    OtherThread.RunWorkerAsync();
                    loadingForm = new Loading();
                    loadingForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại.\nVui lòng kiểm tra lại tài khoản hoặc mật khẩu", "Thông báo");
                }
            }
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OtherThread_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            DataClass.InitializeData();
        }

        private void OtherThread_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            loadingForm.Close();
            var dashBoard = new DashBoard();
            dashBoard.Show();
            Hide();
        }

        #endregion
    }
}
