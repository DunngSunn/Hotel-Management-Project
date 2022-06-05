namespace DAO.Models
{
    public partial class BillService
    {
        public int BillServiceID { get; set; }

        public int BillID { get; set; }

        public int ServiceID { get; set; }

        public int QuantityService { get; set; }

        public long TotalPriceService { get; set; }
    }
}
