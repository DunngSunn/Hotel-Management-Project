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
    public partial class CustomerUC : UserControl
    {
        public delegate void SendCustomerUC(CustomerUC customerToSend);
        public SendCustomerUC sendInfo;

        public CustomerUC()
        {
            InitializeComponent();
            InitializeDatagridView(DataClass.Customers);
        }

        #region Events

        private void CustomerGridView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
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

        private void CustomerGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == 8)
            {
                if (CustomerGridView.Rows[e.RowIndex].ReadOnly == true)
                {
                    CustomerGridView.Rows[e.RowIndex].ReadOnly = false;
                }
                else
                {
                    CustomerGridView.Rows[e.RowIndex].ReadOnly = true;

                    var customer = DataClass.Customers.Find(c => c.CustomerID == (int)CustomerGridView.Rows[e.RowIndex].Cells["CustomerID"].Value);

                    var cName = (string)CustomerGridView.Rows[e.RowIndex].Cells["CustomerName"].Value;
                    var cMobile = (string)CustomerGridView.Rows[e.RowIndex].Cells["CustomerMobile"].Value;
                    var cAddress = (string)CustomerGridView.Rows[e.RowIndex].Cells["CustomerAddress"].Value;
                    var cNationality = (string)CustomerGridView.Rows[e.RowIndex].Cells["CustomerNationality"].Value;
                    var cDateofbirth = (string)CustomerGridView.Rows[e.RowIndex].Cells["CustomerDateofbirth"].Value;
                    var cGender = (string)CustomerGridView.Rows[e.RowIndex].Cells["CustomerGender"].Value;
                    var cIndentification = (string)CustomerGridView.Rows[e.RowIndex].Cells["CustomerIndentification"].Value;

                    var result = CustomerBUS.EditCustomer(customer.CustomerID, cName, cMobile, cNationality, cGender, cDateofbirth, cIndentification, cAddress);
                    if (result)
                    {
                        MessageBox.Show("Sửa thành công.", "Cảnh báo", MessageBoxButtons.OK);

                        customer.CustomerName = cName;
                        customer.CustomerMobile = cMobile;
                        customer.CustomerAddress = cAddress;
                        customer.CustomerNationality = cNationality;
                        customer.CustomerDateofbirth = cDateofbirth;
                        customer.CustomerGender = cGender;
                        customer.CustomerIndentification = cIndentification;
                    }
                    else
                    {
                        MessageBox.Show("Sửa không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
            }

            if (e.ColumnIndex == 9)
            {
                var result = MessageBox.Show("Bạn có muốn xoá khách hàng này không?\n Lưu ý: Xoá khách hàng sẽ xoá tất cả hoá đơn của người này nếu có.", "Xoá khách hàng", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var customer = DataClass.Customers.Find(c => c.CustomerID == (int)CustomerGridView.Rows[e.RowIndex].Cells["CustomerID"].Value);
                    var result1 = CustomerBUS.DeleteCustomer(customer.CustomerID);
                    if (result1)
                    {
                        MessageBox.Show("Xoá thành công.", "Cảnh báo", MessageBoxButtons.OK);

                        DataClass.Customers.Remove(customer);
                        CustomerGridView.Rows.RemoveAt(e.RowIndex);
                    }
                    else
                    {
                        MessageBox.Show("Xoá không thành công.", "Cảnh báo", MessageBoxButtons.OK);
                    }
                }
            }
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            var addCustomer = new AddCustomer();
            var delVoid = new SendCustomerUC(addCustomer.SetCustomerUC);
            sendInfo += delVoid;
            sendInfo(this);
            sendInfo -= delVoid;
            addCustomer.ShowDialog();
        }

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            var result = DataClass.Customers.Where(c => c.CustomerName.Trim().ToLower().Contains(SearchText.Text.Trim().ToLower())).ToList();
            InitializeDatagridView(result);
        }

        #endregion

        #region Other functions

        private void InitializeDatagridView(List<Customer> list)
        {
            CustomerGridView.Rows.Clear();
            foreach (var customer in list)
            {
                SetRowInDatagridView(customer);
            }
        }

        private void SetRowInDatagridView(Customer customer)
        {
            var rowID = CustomerGridView.Rows.Add();
            var row = CustomerGridView.Rows[rowID];
            row.Cells["CustomerID"].Value = customer.CustomerID;
            row.Cells["CustomerName"].Value = customer.CustomerName;
            row.Cells["CustomerMobile"].Value = customer.CustomerMobile;
            row.Cells["CustomerAddress"].Value = customer.CustomerAddress;
            row.Cells["CustomerNationality"].Value = customer.CustomerNationality;
            row.Cells["CustomerDateofbirth"].Value = customer.CustomerDateofbirth;
            row.Cells["CustomerGender"].Value = customer.CustomerGender;
            row.Cells["CustomerIndentification"].Value = customer.CustomerIndentification;
        }

        public void AddCustomerInfo(Customer customerToAdd)
        {
            DataClass.Customers.Add(customerToAdd);

            SetRowInDatagridView(customerToAdd);
        }

        #endregion
    }
}
