using CDM.DAO;
using System.Collections.Generic;
using System.Data;

namespace DAO.Models
{
    public partial class BillRoom
    {
        public int BillRoomID { get; set; }

        public int BillID { get; set; }

        public int RoomID { get; set; }

        public int QuantityHour { get; set; }

        public long TotalPriceRoom { get; set; }
    }

    public static class BillRoomDAO
    {
        public static List<BillRoom> GetAllBillRoom()
        {
            var query = string.Format("EXEC USP_GetAllBillRoom");
            var dt = DataProvider.Instance.ExecuteQuery(query);
            var billRooms = new List<BillRoom>();
            foreach (DataRow row in dt.Rows)
            {
                var billRoom = new BillRoom
                {
                    BillRoomID = Extension.TryParseInt(row["billRoomID"].ToString()),
                    BillID = Extension.TryParseInt(row["billID"].ToString()),
                    RoomID = Extension.TryParseInt(row["roomID"].ToString()),
                    QuantityHour = Extension.TryParseInt(row["quantityHour"].ToString()),
                    TotalPriceRoom = Extension.TryParseLong(row["totalPriceRoom"].ToString())
                };

                billRooms.Add(billRoom);
            }
            return billRooms;
        }

        public static int GetLastIndexOfBillRoom()
        {
            var query = string.Format("EXEC USP_GetLastIndexBillRoom");
            return DataProvider.Instance.GetInt(query);
        }

        public static BillRoom AddBillRoom(int billID, int roomID, int quantityHour, long totalPriceRoom)
        {
            var query = string.Format("EXEC USP_AddBillRoom @billID = {0}, @roomID = {1}, @quantityHour = {2}, @totalPriceRoom = {3}", billID, roomID, quantityHour, totalPriceRoom);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                var billRoom = new BillRoom
                {
                    BillRoomID = GetLastIndexOfBillRoom(),
                    BillID = billID,
                    RoomID = roomID,
                    QuantityHour = quantityHour,
                    TotalPriceRoom = totalPriceRoom
                };

                return billRoom;
            }
            else
            {
                return null;
            }
        }
    }
}
