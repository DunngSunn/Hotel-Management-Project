using CDM.DAO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO.Models
{
    public partial class Room
    {
        public int RoomID { get; set; }

        public string RoomNo { get; set; }

        public string RoomType { get; set; }

        public string RoomBed { get; set; }

        public long RoomPrice { get; set; }

        public bool RoomBooked { get; set; }

        public DateTime? RoomCheckin { get; set; }

        public int? CustomerID { get; set; }
    }

    public static class RoomDAO
    {
        public static List<Room> GetAllRoom()
        {
            var query = string.Format("EXEC USP_GetAllRoom");
            var dt = DataProvider.Instance.ExecuteQuery(query);
            var rooms = new List<Room>();
            foreach (DataRow row in dt.Rows)
            {
                var room = new Room
                {
                    RoomID = Extension.TryParseInt(row["roomID"].ToString()),
                    RoomNo = row["roomNo"].ToString(),
                    RoomType = row["roomType"].ToString(),
                    RoomBed = row["roomBed"].ToString(),
                    RoomPrice = Extension.TryParseLong(row["roomPrice"].ToString()),
                    RoomBooked = Extension.TryParseInt(row["roomBooked"].ToString()) == 1,
                    RoomCheckin = Extension.TryParseDateTime(row["roomCheckin"].ToString()),
                    CustomerID = Extension.TryParseInt(row["customerID"].ToString())
                };

                rooms.Add(room);
            }
            return rooms;
        }

        public static int GetLastIndexOfRoom()
        {
            var query = string.Format("EXEC USP_GetLastIndexRoom");
            return DataProvider.Instance.GetInt(query);
        }

        public static Room AddRoom(string roomNo, string roomType, string roomBed, long roomPrice)
        {
            var query = string.Format("EXEC USP_AddRoom @roomNo = N'{0}', @roomType = N'{1}', @roomBed = N'{2}', @roomPrice = {3}", roomNo, roomType, roomBed, roomPrice);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                var room = new Room
                {
                    RoomID = GetLastIndexOfRoom(),
                    RoomNo = roomNo,
                    RoomType = roomType,
                    RoomBed = roomBed,
                    RoomPrice = roomPrice,
                    RoomBooked = false,
                    RoomCheckin = null,
                    CustomerID = null
                };

                return room;
            }
            else
            {
                return null;
            }
        }

        public static bool EditRoom(int roomID, string roomNo, string roomType, string roomBed, long roomPrice)
        {
            var query = string.Format("EXEC USP_EditRoom @roomID = {0}, @roomNo = N'{1}', @roomType = N'{2}', @roomBed = N'{3}', @roomPrice = {4}", roomID, roomNo, roomType, roomBed, roomPrice);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteRoom(int roomID)
        {
            var query = string.Format("EXEC USP_DeleteRoom @roomID = {0}", roomID);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool EditStatusRoom(int roomID, int roomBooked, string roomCheckin, int customerID)
        {
            string query;
            if (roomBooked == 1)
            {
                query = string.Format("EXEC USP_EditRoomStatus @roomID = {0}, @roomBooked = {1}, @roomCheckin = '{2}', @customerID = {3}", roomID, roomBooked, roomCheckin, customerID);
            }
            else
            {
                query = string.Format("EXEC USP_EditRoomStatus @roomID = {0}, @roomBooked = 0, @roomCheckin = null, @customerID = null", roomID);
            }
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
