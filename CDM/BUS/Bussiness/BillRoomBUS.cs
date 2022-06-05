using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Bussiness
{
    public static class BillRoomBUS
    {
        public static List<BillRoom> GetAllBillRoom()
        {
            return BillRoomDAO.GetAllBillRoom();
        }

        public static BillRoom AddBillRoom(int billID, int roomID, int quantityHour, long totalPriceRoom)
        {
            return BillRoomDAO.AddBillRoom(billID, roomID, quantityHour, totalPriceRoom);
        }
    }
}
