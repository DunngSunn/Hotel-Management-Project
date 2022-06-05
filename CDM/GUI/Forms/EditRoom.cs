using BUS.Bussiness;
using DAO;
using DAO.Models;
using GUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.Forms
{
    public partial class EditRoom : Form
    {
        public Action<Room> SetRoomEditAction;

        private Room roomToEdit;

        public EditRoom()
        {
            InitializeComponent();
            SetRoomEditAction = SetRoomEdit;
        }

        public void SetRoomEdit(Room room)
        {
            roomToEdit = room;
            RoomNo.Text = roomToEdit.RoomNo;
            RoomType.SelectedItem = roomToEdit.RoomType;
            RoomBed.Text = roomToEdit.RoomBed;
            RoomPrice.Text = roomToEdit.RoomPrice.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            roomToEdit.RoomNo = RoomNo.Text;
            roomToEdit.RoomType = RoomType.SelectedItem.ToString();
            roomToEdit.RoomBed = RoomBed.Text;
            roomToEdit.RoomPrice = Extension.TryParseLong(RoomPrice.Text);
            if (RoomBUS.EditRoom(roomToEdit.RoomID, roomToEdit.RoomNo, roomToEdit.RoomType, roomToEdit.RoomBed, roomToEdit.RoomPrice))
            {
                MessageBox.Show("Sửa thành công.");
                RoomManagerUC.EditRoomAction.Invoke(roomToEdit);
                Close();
            }
            else
            {
                MessageBox.Show("Sửa thành công.");
                Close();
            }
        }
    }
}
