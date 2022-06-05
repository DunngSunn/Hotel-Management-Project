using BUS.Bussiness;
using DAO;
using DAO.Models;
using GUI.UserControls;
using System;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class AddRoom : Form
    {
        private RoomManagerUC roomManagerUC;
        private Room thisRoom;

        public delegate void SendRoom(Room roomToSend);
        public SendRoom sendInfo;

        public AddRoom()
        {
            InitializeComponent();
        }

        #region Other functions

        public void SetRoomManagerUC(RoomManagerUC roomManagerUC)
        {
            this.roomManagerUC = roomManagerUC;
        }

        #endregion

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var roomNo = RoomNo.Text;
            var roomType = RoomType.SelectedItem.ToString();
            var roomBed = RoomBed.Text;
            var roomPrice = Extension.TryParseLong(RoomPrice.Text);

            if (roomNo.Equals(string.Empty) || roomBed.Equals(string.Empty))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin.", "Cảnh báo", MessageBoxButtons.OK);
            }
            else
            {
                thisRoom = RoomBUS.AddRoom(roomNo, roomType, roomBed, roomPrice);
                if (thisRoom != null)
                {
                    var delVoid = new SendRoom(roomManagerUC.AddRoomInfo);
                    sendInfo += delVoid;
                    sendInfo(thisRoom);
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
                    Close();
                }
            }
        }
    }
}
