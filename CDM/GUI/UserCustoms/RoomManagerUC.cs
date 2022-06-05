using BUS.Bussiness;
using DAO.Models;
using GUI.Forms;
using GUI.UserCustoms;
using Guna.UI2.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace GUI.UserControls
{
    public partial class RoomManagerUC : UserControl
    {
        private const int OffsetLayoutPanel = 54;

        private string NameOfTypeRoomChecked => GroupTypeRoom.Controls.OfType<Guna2RadioButton>().FirstOrDefault(r => r.Checked).Text;
        private string NameOfStatusRoomChecked => GroupStatusRoom.Controls.OfType<Guna2RadioButton>().FirstOrDefault(r => r.Checked).Text;

        public delegate void SendRoomInfo(Room roomToSend);
        public SendRoomInfo sendInfo;

        public delegate void SendRoomManagerUC(RoomManagerUC roomManagerToSend);
        public SendRoomManagerUC sendUCInfo;

        public static Action<Room> DeleteRoomAction;
        public static Action<Room> EditRoomAction;
        public static Action<Room> BookedRoomAction;

        public RoomManagerUC()
        {
            InitializeComponent();
            Initialize();

            DeleteRoomAction = OnDeleteRoom;
            EditRoomAction = OnEditRoom;
            BookedRoomAction = OnBookedRoom;
        }

        #region Event

        private void TextSearch_TextChanged(object sender, EventArgs e)
        {
            var textSearch = TextSearch.Text.ToUpper();

            if (textSearch.Equals(string.Empty))
            {
                SetWhenRoomTypeChanged();
                SetWhenStatusChanged();
            }
            else
            {
                ClearGroupRoomControls();

                foreach (var room in DataClass.RoomUCs)
                {
                    if (room.ThisRoom.RoomNo.Contains(textSearch))
                    {
                        AddUCWithTag(room.Tag.ToString(), room);
                    }
                }

                SetHeightOfGroupRoom();
                CheckToVisibleGroupRoom();
            }
        }

        private void RBRoom_StateChanged(object sender, EventArgs e)
        {
            SetWhenRoomTypeChanged();
        }

        private void RBStatus_StateChanged(object sender, EventArgs e)
        {
            SetWhenStatusChanged();
        }

        private void BtnAddRoom_Click(object sender, EventArgs e)
        {
            var addRoom = new AddRoom();
            var delVoid = new SendRoomManagerUC(addRoom.SetRoomManagerUC);
            sendUCInfo += delVoid;
            sendUCInfo(this);
            sendUCInfo -= delVoid;
            addRoom.ShowDialog();
        }

        #endregion

        #region Functions

        private void SetWhenStatusChanged()
        {
            ClearGroupRoomControls();

            switch (NameOfStatusRoomChecked)
            {
                case "Đã thuê":
                    foreach (var room in DataClass.RoomUCs)
                    {
                        if (room.ThisRoom.RoomBooked)
                            AddUCWithTag(room.Tag.ToString(), room);
                    }
                    break;
                case "Đang trống":
                    foreach (var room in DataClass.RoomUCs)
                    {
                        if (!room.ThisRoom.RoomBooked)
                            AddUCWithTag(room.Tag.ToString(), room);
                    }
                    break;
                case "Tất cả":
                    foreach (var room in DataClass.RoomUCs)
                        AddUCWithTag(room.Tag.ToString(), room);
                    break;
            }

            SetWhenRoomTypeChanged();
            SetHeightOfGroupRoom();
            CheckToVisibleGroupRoom();
        }

        private void SetWhenRoomTypeChanged()
        {
            switch (NameOfTypeRoomChecked)
            {
                case "Phòng đơn":
                    GroupSingleRoom.Visible = true;
                    GroupDoubleRoom.Visible = false;
                    GroupFamilyRoom.Visible = false;
                    break;
                case "Phòng đôi":
                    GroupSingleRoom.Visible = false;
                    GroupDoubleRoom.Visible = true;
                    GroupFamilyRoom.Visible = false;
                    break;
                case "Phòng gia đình":
                    GroupSingleRoom.Visible = false;
                    GroupDoubleRoom.Visible = false;
                    GroupFamilyRoom.Visible = true;
                    break;
                case "Tất cả":
                    GroupSingleRoom.Visible = true;
                    GroupDoubleRoom.Visible = true;
                    GroupFamilyRoom.Visible = true;
                    break;
            }

            CheckToVisibleGroupRoom();
        }

        private void AddUCWithTag(string tag, UserControl uc)
        {
            switch (tag)
            {
                case "Phòng đơn":
                    if (!LayoutPanelSingleRoom.Controls.Contains(uc)) LayoutPanelSingleRoom.Controls.Add(uc);
                    break;
                case "Phòng đôi":
                    if (!LayoutPanelDoubleRoom.Controls.Contains(uc)) LayoutPanelDoubleRoom.Controls.Add(uc);
                    break;
                case "Phòng gia đình":
                    if (!LayoutPanelFamilyRoom.Controls.Contains(uc)) LayoutPanelFamilyRoom.Controls.Add(uc);
                    break;
            }
        }

        private void Initialize()
        {
            for (int i = 0; i < DataClass.RoomUCs.Count; i++)
            {
                var delVoid = new SendRoomInfo(DataClass.RoomUCs[i].SetRoomInfo);
                sendInfo += delVoid;
                sendInfo(DataClass.Rooms[i]);
                sendInfo -= delVoid;

                switch (DataClass.Rooms[i].RoomType)
                {
                    case "Phòng đơn":
                        DataClass.RoomUCs[i].Tag = "Phòng đơn";
                        LayoutPanelSingleRoom.Controls.Add(DataClass.RoomUCs[i]);
                        break;
                    case "Phòng đôi":
                        DataClass.RoomUCs[i].Tag = "Phòng đôi";
                        LayoutPanelDoubleRoom.Controls.Add(DataClass.RoomUCs[i]);
                        break;
                    case "Phòng gia đình":
                        DataClass.RoomUCs[i].Tag = "Phòng gia đình";
                        LayoutPanelFamilyRoom.Controls.Add(DataClass.RoomUCs[i]);
                        break;
                }
            }

            SetHeightOfGroupRoom();
        }

        private void SetHeightOfGroupRoom()
        {
            GroupSingleRoom.Height = LayoutPanelSingleRoom.Height + OffsetLayoutPanel;
            GroupDoubleRoom.Height = LayoutPanelDoubleRoom.Height + OffsetLayoutPanel;
            GroupFamilyRoom.Height = LayoutPanelFamilyRoom.Height + OffsetLayoutPanel;
        }

        private void CheckToVisibleGroupRoom()
        {
            if (LayoutPanelSingleRoom.Controls.Count == 0) GroupSingleRoom.Visible = false;
            if (LayoutPanelDoubleRoom.Controls.Count == 0) GroupDoubleRoom.Visible = false;
            if (LayoutPanelFamilyRoom.Controls.Count == 0) GroupFamilyRoom.Visible = false;
        }

        private void ClearGroupRoomControls()
        {
            LayoutPanelFamilyRoom.Controls.Clear();
            GroupFamilyRoom.Size = GroupFamilyRoom.MinimumSize;
            LayoutPanelDoubleRoom.Controls.Clear();
            GroupDoubleRoom.Size = GroupDoubleRoom.MinimumSize;
            LayoutPanelSingleRoom.Controls.Clear();
            GroupSingleRoom.Size = GroupSingleRoom.MinimumSize;
        }

        public void AddRoomInfo(Room roomToAdd)
        {
            DataClass.Rooms.Add(roomToAdd);
            var roomUC = new RoomUC();
            var delVoid = new SendRoomInfo(roomUC.SetRoomInfo);
            sendInfo += delVoid;
            sendInfo(roomToAdd);
            sendInfo -= delVoid;
            DataClass.RoomUCs.Add(roomUC);

            switch (roomToAdd.RoomType)
            {
                case "Phòng đơn":
                    roomUC.Tag = "Phòng đơn";
                    LayoutPanelSingleRoom.Controls.Add(roomUC);
                    break;
                case "Phòng đôi":
                    roomUC.Tag = "Phòng đôi";
                    LayoutPanelDoubleRoom.Controls.Add(roomUC);
                    break;
                case "Phòng gia đình":
                    roomUC.Tag = "Phòng gia đình";
                    LayoutPanelFamilyRoom.Controls.Add(roomUC);
                    break;
            }

            SetHeightOfGroupRoom();
        }

        public void OnDeleteRoom(Room room)
        {
            if (RoomBUS.DeleteRoom(room.RoomID))
            {
                DataClass.Rooms.Remove(room);
                var roomUC = DataClass.RoomUCs.Find(r => r.ThisRoom.RoomID == room.RoomID);
                switch (room.RoomType)
                {
                    case "Phòng đơn":
                        LayoutPanelSingleRoom.Controls.Remove(roomUC);
                        break;
                    case "Phòng đôi":
                        LayoutPanelDoubleRoom.Controls.Remove(roomUC);
                        break;
                    case "Phòng gia đình":
                        LayoutPanelFamilyRoom.Controls.Remove(roomUC);
                        break;
                }

                SetHeightOfGroupRoom();
                DataClass.RoomUCs.Remove(roomUC);
                MessageBox.Show("Xoá thành công.");
            }
            else
            {
                MessageBox.Show("Xoá không thành công.");
            }
        }

        public void OnEditRoom(Room roomToEdit)
        {
            var room = DataClass.Rooms.Find(r => r.RoomID == roomToEdit.RoomID);
            var roomUC = DataClass.RoomUCs.Find(r => r.ThisRoom.RoomID == roomToEdit.RoomID);
            room = roomToEdit;
            roomUC.ThisRoom = roomToEdit;
            roomUC.InitThisUC();
        }

        public void OnBookedRoom(Room roomToBooked)
        {
            var room = DataClass.Rooms.Find(r => r.RoomID == roomToBooked.RoomID);
            var roomUC = DataClass.RoomUCs.Find(r => r.ThisRoom.RoomID == roomToBooked.RoomID);
            room = roomToBooked;
            roomUC.ThisRoom = roomToBooked;
            roomUC.InitThisUC();
        }

        #endregion
    }
}
