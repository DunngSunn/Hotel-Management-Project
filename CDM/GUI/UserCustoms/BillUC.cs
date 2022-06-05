using DAO.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class BillUC : UserControl
    {
        public static Action ResetDataGridview;

        public BillUC()
        {
            InitializeComponent();
            InitializeDatagridView(DataClass.Bills);
            ResetDataGridview = InitializeDatagridView;
        }

        #region Other functions

        private void InitializeDatagridView(List<Bill> bills)
        {
            BillGridView.Rows.Clear();
            foreach (var bill in bills)
            {
                var billRoom = DataClass.BillRooms.Find(b => b.BillID == bill.BillID);
                var customer = DataClass.Customers.Find(c => c.CustomerID == bill.CustomerID);
                var room = DataClass.Rooms.Find(r => r.RoomID == billRoom.RoomID);
                SetRowInDatagridView(bill, room, customer);
            }
        }

        private void InitializeDatagridView()
        {
            BillGridView.Rows.Clear();
            foreach (var bill in DataClass.Bills)
            {
                var billRoom = DataClass.BillRooms.Find(b => b.BillID == bill.BillID);
                var customer = DataClass.Customers.Find(c => c.CustomerID == bill.CustomerID);
                var room = DataClass.Rooms.Find(r => r.RoomID == billRoom.RoomID);
                SetRowInDatagridView(bill, room, customer);
            }
        }

        private void SetRowInDatagridView(Bill bill, Room room, Customer customer)
        {
            var rowID = BillGridView.Rows.Add();
            var row = BillGridView.Rows[rowID];
            row.Cells["BillID"].Value = bill.BillID;
            row.Cells["CustomerName"].Value = customer.CustomerName;
            row.Cells["Checkin"].Value = bill.CheckIn;
            row.Cells["Checkout"].Value = bill.CheckOut;
            row.Cells["RoomNo"].Value = room.RoomNo;
            row.Cells["Price"].Value = bill.TotalPrice;
        }

        #endregion

        private void SearchText_TextChanged(object sender, EventArgs e)
        {
            var result = DataClass.Bills.Where(c => c.CustomerID == GetCustomerID(SearchText.Text.Trim().ToLower())).ToList();
            if (SearchText.Text.Equals(string.Empty))
            {
                InitializeDatagridView();
            }
            else
            {
                InitializeDatagridView(result);
            }
        }

        private int GetCustomerID(string customerName)
        {
            var customer = DataClass.Customers.Find(o => o.CustomerName.ToLower().Contains(customerName));
            return customer != null ? customer.CustomerID : -1;
        }
    }
}
