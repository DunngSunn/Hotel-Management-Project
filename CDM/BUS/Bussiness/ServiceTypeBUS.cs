using DAO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Bussiness
{
    public static class ServiceTypeBUS
    {
        public static List<ServiceType> GetAllServiceType()
        {
            return ServiceTypeDAO.GetAllServiceType();
        }

        public static bool EditServiceType(int serviceTypeID, string serviceTypeName)
        {
            return ServiceTypeDAO.EditServiceType(serviceTypeID, serviceTypeName);
        }

        public static bool DeleteServiceType(int serviceTypeID)
        {
            return ServiceTypeDAO.DeleteServiceType(serviceTypeID);
        }

        public static ServiceType AddServiceType(string serviceTypeName)
        {
            return ServiceTypeDAO.AddServiceType(serviceTypeName);
        }
    }
}
