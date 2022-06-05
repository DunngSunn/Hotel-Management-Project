using BUS.Bussiness;
using DAO.Models;
using GUI.UserControls;
using System;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class AddCustomer : Form
    {
        private Customer thisCustomer;
        private CustomerUC customerUC;

        public delegate void SendCustomer(Customer customerToSend);
        public SendCustomer sendInfo;

        public AddCustomer()
        {
            InitializeComponent();
        }

        #region Events

        private void AddButton_Click(object sender, EventArgs e)
        {
            var name = NameText.Text;
            var dateOfBirth = DateOfBirth.Value.Date.ToShortDateString();
            var gender = Gender.GetItemText(Gender.SelectedItem);
            var address = AddressText.Text;
            var mobile = MobileText.Text;
            var cccd = CCCDText.Text;
            var national = NationalText.Text;

            if (name.Equals(string.Empty) || address.Equals(string.Empty) || mobile.Equals(string.Empty) || cccd.Equals(string.Empty) || national.Equals(string.Empty))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                thisCustomer = CustomerBUS.AddCustomer(name, mobile, national, gender, dateOfBirth, cccd, address);
                if (thisCustomer != null)
                {
                    var delVoid = new SendCustomer(customerUC.AddCustomerInfo);
                    sendInfo += delVoid;
                    sendInfo(thisCustomer);
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Other functions

        public void SetCustomerUC(CustomerUC customerUC)
        {
            this.customerUC = customerUC;
        }

        #endregion
    }
}
