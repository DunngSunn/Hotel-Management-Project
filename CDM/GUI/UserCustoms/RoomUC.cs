using DAO.Models;
using GUI.Forms;
using GUI.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI.UserCustoms
{
    public partial class RoomUC : UserControl
    {
        private const string BookdedStatus = "Đã thuê";
        private const string NotBookdedStatus = "Đang trống";

        public delegate void SendRoomInfo(Room roomToSend);
        public SendRoomInfo sendInfo;

        public Room ThisRoom { get; set; }

        public RoomUC()
        {
            InitializeComponent();
        }

        private void RoomUC_Click(object sender, EventArgs e)
        {
            var roomControl = new RoomController();
            var delVoid = new SendRoomInfo(roomControl.SetRoomInfo);
            sendInfo += delVoid;
            sendInfo(ThisRoom);
            sendInfo -= delVoid;
            roomControl.Initialize();
            roomControl.ShowDialog();
        }

        public void SetRoomInfo(Room room)
        {
            ThisRoom = room;
            InitThisUC();
        }

        public void InitThisUC()
        {
            TextName.Text = ThisRoom.RoomNo;

            if (ThisRoom.RoomBooked)
            {
                TextStatus.Text = BookdedStatus;
                PictureStatus.Image = GUI.Properties.Resources.group;
                BackColor = Color.DarkOrange;
            }
            else
            {
                TextStatus.Text = NotBookdedStatus;
                PictureStatus.Image = GUI.Properties.Resources._checked;
                BackColor = Color.Tan;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            RoomManagerUC.DeleteRoomAction.Invoke(ThisRoom);
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            var editRoom = new EditRoom();
            editRoom.SetRoomEditAction.Invoke(ThisRoom);
            editRoom.ShowDialog();
        }
    }
}
