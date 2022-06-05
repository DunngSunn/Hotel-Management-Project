using BUS.Bussiness;
using DAO.Models;
using GUI.UserControls;
using System;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class RoomController : Form
    {
        public Room ThisRoom { get; set; }

        public RoomController()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void SetRoomInfo(Room roomInfo)
        {
            ThisRoom = roomInfo;
            CustomerName.Items.Add(string.Empty);
            foreach (var item in DataClass.Customers)
            {
                CustomerName.Items.Add(item.CustomerName);
            }
            Initialize();
        }

        public void Initialize()
        {
            RoomNoText.Text = ThisRoom.RoomNo;

            if (ThisRoom.RoomBooked)
            {
                CustomerName.SelectedItem = DataClass.Customers.Find(c => c.CustomerID == ThisRoom.CustomerID).CustomerName;
                CustomerName.Enabled = false;
                DateCheckin.Text = ThisRoom.RoomCheckin.ToString();
                Status.Text = "Đã thuê";
                RoomControlButton.Text = "Trả phòng";
            }
            else
            {
                CustomerName.SelectedItem = string.Empty;
                CustomerName.Enabled = true;
                DateCheckin.Text = string.Empty;
                Status.Text = "Đang trống";
                RoomControlButton.Text = "Nhận phòng";
            }
        }

        private void RoomControlButton_Click(object sender, EventArgs e)
        {
            if (RoomControlButton.Text == "Trả phòng")
            {
                var dateTimeNow = DateTime.Now;
                var hour = (dateTimeNow - ThisRoom.RoomCheckin).Value.Hours;
                var hourPlus = (dateTimeNow - ThisRoom.RoomCheckin).Value.Minutes > 0 ? 1 : 0;
                var totalTime = hour + hourPlus;
                var totalPrice = totalTime * ThisRoom.RoomPrice;
                var bill = BillBUS.AddBill((int)ThisRoom.CustomerID, ThisRoom.RoomCheckin.ToString(), dateTimeNow.ToString(), totalPrice);
                var billRoom = BillRoomBUS.AddBillRoom(BillBUS.GetLastIndexOfBill(), ThisRoom.RoomID, totalTime, totalPrice);
                var editRoom = RoomBUS.EditStatusRoom(ThisRoom.RoomID, false, null, 0);
                if (bill != null && billRoom != null && editRoom)
                {
                    ThisRoom.RoomBooked = false;
                    ThisRoom.RoomCheckin = null;
                    ThisRoom.CustomerID = null;
                    DataClass.Bills.Add(bill);
                    DataClass.BillRooms.Add(billRoom);
                    BillUC.ResetDataGridview.Invoke();
                    Initialize();
                    RoomManagerUC.BookedRoomAction.Invoke(ThisRoom);
                }
                else
                {
                    MessageBox.Show("Trả phòng không thành công.");
                }
            }
            else
            {
                var dateTimeNow = DateTime.Now;
                if (RoomBUS.EditStatusRoom(ThisRoom.RoomID, true, dateTimeNow.ToString(), GetIDCustomer(CustomerName.SelectedItem.ToString())))
                {
                    ThisRoom.RoomBooked = true;
                    ThisRoom.RoomCheckin = dateTimeNow;
                    ThisRoom.CustomerID = GetIDCustomer(CustomerName.SelectedItem.ToString());
                    Initialize();
                    RoomManagerUC.BookedRoomAction.Invoke(ThisRoom);
                }
                else
                {
                    MessageBox.Show("Nhận phòng không thành công.");
                }
            }
        }

        private int GetIDCustomer(string customerName)
        {
            return DataClass.Customers.Find(c => c.CustomerName == customerName).CustomerID;
        }
    }
}
