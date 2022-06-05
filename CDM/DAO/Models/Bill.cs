using CDM.DAO;
using System;
using System.Collections.Generic;
using System.Data;

namespace DAO.Models
{
    public partial class Bill
    {
        public int BillID { get; set; }

        public int CustomerID { get; set; }

        public DateTime CheckIn { get; set; }

        public DateTime CheckOut { get; set; }

        public long TotalPrice { get; set; }
    }

    public static class BillDAO
    {
        public static List<Bill> GetAllBill()
        {
            var query = string.Format("EXEC USP_GetAllBill");
            var dt = DataProvider.Instance.ExecuteQuery(query);
            var bills = new List<Bill>();
            foreach (DataRow row in dt.Rows)
            {
                var bill = new Bill
                {
                    BillID = Extension.TryParseInt(row["billID"].ToString()),
                    CustomerID = Extension.TryParseInt(row["customerID"].ToString()),
                    CheckIn = Extension.TryParseDateTime(row["checkIn"].ToString()),
                    CheckOut = Extension.TryParseDateTime(row["checkOut"].ToString()),
                    TotalPrice = Extension.TryParseLong(row["totalPrice"].ToString())
                };

                bills.Add(bill);
            }
            return bills;
        }

        public static int GetLastIndexOfBill()
        {
            var query = string.Format("EXEC USP_GetLastIndexBill");
            return DataProvider.Instance.GetInt(query);
        }

        public static Bill AddBill(int customerID, string checkin, string checkout, long totalPrice)
        {
            var query = string.Format("EXEC USP_AddBill @customerID = {0}, @checkIn = '{1}', @checkOut = '{2}', @totalPrice = {3}", customerID, checkin, checkout, totalPrice);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                var bill = new Bill
                {
                    BillID = GetLastIndexOfBill(),
                    CustomerID = customerID,
                    CheckIn = Extension.TryParseDateTime(checkin),
                    CheckOut = Extension.TryParseDateTime(checkout),
                    TotalPrice = totalPrice
                };

                return bill;
            }
            else
            {
                return null;
            }
        }
    }
}
