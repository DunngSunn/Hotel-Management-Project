using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Bussiness
{
    public static class BillBUS
    {
        public static List<Bill> GetAllBill()
        {
            return BillDAO.GetAllBill();
        }

        public static Bill AddBill(int customerID, string checkin, string checkout, long totalPrice)
        {
            return BillDAO.AddBill(customerID, checkin, checkout, totalPrice);
        }

        public static int GetLastIndexOfBill()
        {
            return BillDAO.GetLastIndexOfBill();
        }
    }
}
