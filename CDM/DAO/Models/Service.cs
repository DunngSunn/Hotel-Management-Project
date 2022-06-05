using CDM.DAO;
using System.Collections.Generic;
using System.Data;

namespace DAO.Models
{
    public partial class Service
    {
        public int ServiceID { get; set; }

        public int ServiceTypeID { get; set; }

        public string ServiceTypeName { get; set; }

        public string ServiceName { get; set; }

        public long ServicePrice { get; set; }
    }

    public static class ServiceDAO
    {
        public static List<Service> GetAllService()
        {
            var query = string.Format("EXEC USP_GetAllService");
            var dt = DataProvider.Instance.ExecuteQuery(query);
            var services = new List<Service>();
            foreach (DataRow row in dt.Rows)
            {
                var service = new Service
                {
                    ServiceID = Extension.TryParseInt(row["serviceID"].ToString()),
                    ServiceTypeID = Extension.TryParseInt(row["serviceTypeID"].ToString()),
                    ServiceTypeName = row["serviceTypeName"].ToString(),
                    ServiceName = row["serviceName"].ToString(),
                    ServicePrice = Extension.TryParseLong(row["servicePrice"].ToString())
                };

                services.Add(service);
            }
            return services;
        }

        public static bool EditService(int serviceID, int serviceTypeID, string serviceName, long servicePrice)
        {
            var query = string.Format("EXEC USP_EditService @serviceID = {0}, @serviceTypeID = {1}, @serviceName = N'{2}', @servicePrice = {3}", serviceID, serviceTypeID, serviceName, servicePrice);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteService(int serviceID)
        {
            var query = string.Format("EXEC USP_DeleteService @serviceID = {0}", serviceID);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetLastIndexOfService()
        {
            var query = string.Format("EXEC USP_GetLastIndexService");
            return DataProvider.Instance.GetInt(query);
        }

        public static Service AddService(int serviceTypeID, string serviceName, long servicePrice, string serviceTypeName)
        {
            var query = string.Format("EXEC USP_AddService @serviceTypeID = {0}, @serviceName = N'{1}', @servicePrice = {2}", serviceTypeID, serviceName, servicePrice);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                var service = new Service
                {
                    ServiceID = GetLastIndexOfService(),
                    ServiceTypeID = serviceTypeID,
                    ServiceTypeName = serviceTypeName,
                    ServiceName = serviceName,
                    ServicePrice = servicePrice
                };

                return service;
            }
            else
            {
                return null;
            }
        }
    }
}
