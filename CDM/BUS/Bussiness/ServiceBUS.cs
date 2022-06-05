using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Bussiness
{
    public static class ServiceBUS
    {
        public static List<Service> GetAllService()
        {
            return ServiceDAO.GetAllService();
        }

        public static bool EditService(int serviceID, int serviceTypeID, string serviceName, long servicePrice)
        {
            return ServiceDAO.EditService(serviceID, serviceTypeID, serviceName, servicePrice);
        }

        public static bool DeleteService(int serviceID)
        {
            return ServiceDAO.DeleteService(serviceID);
        }
        public static Service AddService(int serviceTypeID, string serviceName, long servicePrice, string serviceTypeName)
        {
            return ServiceDAO.AddService(serviceTypeID, serviceName, servicePrice, serviceTypeName);
        }
    }
}
