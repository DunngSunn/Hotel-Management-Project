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
}
