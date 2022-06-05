using BUS.Bussiness;
using DAO.Models;
using GUI.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class EmployeeUC : UserControl
    {
        public delegate void SendEmployeeUC(EmployeeUC valueToSend);
        public SendEmployeeUC sendInfo;

        public EmployeeUC()
        {
            InitializeComponent();
            InitializeDatagridView(DataClass.Employees, DataClass.Accounts);
        }

        #region Events

        private void EmployeeGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 8)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 25;
                var h = 25;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.edit, new Rectangle(x, y, w, h));
                e.Handled = true;
            }

            if (e.ColumnIndex == 9)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = 25;
                var h = 25;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(Properties.Resources.delete_button, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }

        private void EmployeeGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 8)
            {
                if (EmployeeGridView.Rows[e.RowIndex].ReadOnly)
                {
                    EmployeeGridView.Rows[e.RowIndex].ReadOnly = false;
                }
                else
                {
                    EmployeeGridView.Rows[e.RowIndex].ReadOnly = true;

                    var employee = DataClass.Employees.Find(em => em.EmployeeID == (int)EmployeeGridView.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                    var account = DataClass.Accounts.Find(a => a.EmployeeID == (int)EmployeeGridView.Rows[e.RowIndex].Cells["EmployeeID"].Value);

                    var eEmployeeName = (string)EmployeeGridView.Rows[e.RowIndex].Cells["EmployeeName"].Value;
                    var eEmployeeGender = (string)EmployeeGridView.Rows[e.RowIndex].Cells["EmployeeGender"].Value;
                    var eEmployeeMobile = (string)EmployeeGridView.Rows[e.RowIndex].Cells["EmployeeMobile"].Value;
                    var eEmployeeEmailID = (string)EmployeeGridView.Rows[e.RowIndex].Cells["EmployeeEmailID"].Value;
                    var eEmployeeAddress = (string)EmployeeGridView.Rows[e.RowIndex].Cells["EmployeeAddress"].Value;
                    var aUsername = (string)EmployeeGridView.Rows[e.RowIndex].Cells["Username"].Value;
                    var aPassword = (string)EmployeeGridView.Rows[e.RowIndex].Cells["Password"].Value;

                    var result = EmployeeBUS.EditEmployee(employee.EmployeeID, eEmployeeName, eEmployeeMobile, eEmployeeGender, eEmployeeEmailID, eEmployeeAddress) && AccountBUS.EditAccount(account.AccountID, aUsername, aPassword);
                    if (result)
                    {
                        MessageBox.Show("Sửa thành công.", "Cảnh báo", MessageBoxButtons.OK);

                        employee.EmployeeName = eEmployeeName;
                        employee.EmployeeGender = eEmployeeGender;
                        employee.EmployeeMobile = eEmployeeMobile;
                        employee.EmployeeEmailID = eEmployeeEmailID;
                        employee.EmployeeAddress = eEmployeeAddress;
                        account.Username = aUsername;
                        account.Password = aPassword;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
            }

            if (e.ColumnIndex == 9)
            {
                var result = MessageBox.Show("Bạn có muốn xoá nhân viên này không?\n Lưu ý: Xoá nhân viên sẽ xoá cả tài khoản đăng nhập của người này.", "Xoá nhân viên", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var employee = DataClass.Employees.Find(em => em.EmployeeID == (int)EmployeeGridView.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                    var account = DataClass.Accounts.Find(a => a.EmployeeID == (int)EmployeeGridView.Rows[e.RowIndex].Cells["EmployeeID"].Value);
                    var result1 = AccountBUS.DeleteAccount(employee.EmployeeID) && EmployeeBUS.DeleteEmployee(employee.EmployeeID);
                    if (result1)
                    {
                        MessageBox.Show("Xoá thành công.", "Cảnh báo", MessageBoxButtons.OK);

                        DataClass.Employees.Remove(employee);
                        DataClass.Accounts.Remove(account);
                        EmployeeGridView.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void AddEmployee_Click(object sender, EventArgs e)
        {
            var addEmployee = new AddEmployeeUC();
            var delVoid = new SendEmployeeUC(addEmployee.SetCustomerUC);
            sendInfo += delVoid;
            sendInfo(this);
            sendInfo -= delVoid;
            addEmployee.ShowDialog();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            var result = DataClass.Employees.Where(em => em.EmployeeName.Trim().ToLower().Contains(SearchText.Text.Trim().ToLower())).ToList();
            InitializeDatagridView(result, DataClass.Accounts);
        }

        #endregion

        #region Other functions

        private void InitializeDatagridView(List<Employee> listEmployee, List<Account> listAccount)
        {
            EmployeeGridView.Rows.Clear();
            foreach (var employee in listEmployee)
            {
                var account = listAccount.Find(a => a.EmployeeID == employee.EmployeeID);

                SetRowInDatagridView(employee, account);
            }
        }

        private void SetRowInDatagridView(Employee employee, Account account)
        {
            var rowID = EmployeeGridView.Rows.Add();
            var row = EmployeeGridView.Rows[rowID];
            row.Cells["EmployeeID"].Value = employee.EmployeeID;
            row.Cells["EmployeeName"].Value = employee.EmployeeName;
            row.Cells["EmployeeMobile"].Value = employee.EmployeeMobile;
            row.Cells["EmployeeGender"].Value = employee.EmployeeGender;
            row.Cells["EmployeeEmailID"].Value = employee.EmployeeEmailID;
            row.Cells["EmployeeAddress"].Value = employee.EmployeeAddress;
            row.Cells["Username"].Value = account.Username;
            row.Cells["Password"].Value = account.Password;
        }

        public void AddEmployeeInfo(Employee employeeToAdd, Account accountToAdd)
        {
            DataClass.Employees.Add(employeeToAdd);
            DataClass.Accounts.Add(accountToAdd);

            SetRowInDatagridView(employeeToAdd, accountToAdd);
        }

        #endregion
    }
}
