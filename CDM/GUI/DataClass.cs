using BUS.Bussiness;
using DAO.Models;
using GUI.UserCustoms;
using System.Collections.Generic;

namespace GUI
{
    public static class DataClass
    {
        public static List<Customer> Customers { get; set; }
        public static List<Account> Accounts { get; set; }
        public static List<Employee> Employees { get; set; }
        public static List<Room> Rooms { get; set; }
        public static List<RoomUC> RoomUCs { get; set; }
        public static List<Service> Services { get; set; }
        public static List<ServiceType> ServiceTypes { get; set; }
        public static List<Bill> Bills { get; set; }
        public static List<BillRoom> BillRooms { get; set; }

        public static void InitializeData()
        {
            Customers = CustomerBUS.GetAllCustomer();
            Accounts = AccountBUS.GetAllAccount();
            Employees = EmployeeBUS.GetAllEmployee();
            Rooms = RoomBUS.GetAllRoom();
            Services = ServiceBUS.GetAllService();
            ServiceTypes = ServiceTypeBUS.GetAllServiceType();
            Bills = BillBUS.GetAllBill();
            BillRooms = BillRoomBUS.GetAllBillRoom();

            RoomUCs = new List<RoomUC>();
            for (int i = 0; i < Rooms.Count; i++)
            {
                var roomUC = new RoomUC();
                RoomUCs.Add(roomUC);
            }
        }
    }
}
