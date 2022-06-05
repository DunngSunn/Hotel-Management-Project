using DAO.Models;
using System.Collections.Generic;

namespace BUS.Bussiness
{
    public static class RoomBUS
    {
        public static List<Room> GetAllRoom()
        {
            return RoomDAO.GetAllRoom();
        }

        public static Room AddRoom(string roomNo, string roomType, string roomBed, long roomPrice)
        {
            return RoomDAO.AddRoom(roomNo, roomType, roomBed, roomPrice);
        }

        public static bool EditRoom(int roomID, string roomNo, string roomType, string roomBed, long roomPrice)
        {
            return RoomDAO.EditRoom(roomID, roomNo, roomType, roomBed, roomPrice);
        }

        public static bool DeleteRoom(int roomID)
        {
            return RoomDAO.DeleteRoom(roomID);
        }

        public static bool EditStatusRoom(int roomID, bool roomBooked, string roomCheckin, int customerID)
        {
            return RoomDAO.EditStatusRoom(roomID, roomBooked ? 1 : 0, roomCheckin, customerID);
        }
    }
}
