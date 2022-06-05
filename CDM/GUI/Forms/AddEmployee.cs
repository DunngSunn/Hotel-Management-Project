using BUS.Bussiness;
using DAO.Models;
using GUI.UserControls;
using System;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class AddEmployeeUC : Form
    {
        private Employee thisEmployee;
        private Account thisAccount;
        private EmployeeUC employeerUC;

        public delegate void SendEmployee(Employee employeeToSend, Account accountToSend);
        public SendEmployee sendInfo;

        public AddEmployeeUC()
        {
            InitializeComponent();
        }

        #region Events

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var name = NameText.Text;
            var gender = Gender.GetItemText(Gender.SelectedItem);
            var mobile = Mobile.Text;
            var email = Email.Text;
            var address = Address.Text;
            var user = User.Text;
            var pass = Pass.Text;

            if (name.Equals(string.Empty) || address.Equals(string.Empty) || mobile.Equals(string.Empty) || email.Equals(string.Empty) || user.Equals(string.Empty) || pass.Equals(string.Empty))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                thisEmployee = EmployeeBUS.AddEmployee(name, mobile, gender, email, address);
                thisAccount = AccountBUS.AddAccount(thisEmployee.EmployeeID, user, pass);

                if (thisEmployee != null && thisAccount != null)
                {
                    var delVoid = new SendEmployee(employeerUC.AddEmployeeInfo);
                    sendInfo += delVoid;
                    sendInfo(thisEmployee, thisAccount);
                    sendInfo -= delVoid;
                    var result = MessageBox.Show("Thêm thành công.", "Cảnh báo", MessageBoxButtons.OK);
                    if (result == DialogResult.OK)
                    {
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Thêm không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                }
            }
        }

        #endregion

        #region Other functions

        public void SetCustomerUC(EmployeeUC employeeUC)
        {
            this.employeerUC = employeeUC;
        }

        #endregion
    }
}
