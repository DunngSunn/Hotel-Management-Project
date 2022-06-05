using System;
using System.Collections.Generic;

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

    }
}
