using System.Collections.Generic;
using System.Data;
using CDM.DAO;

namespace DAO.Models
{
    public partial class ServiceType
    {
        public int ServiceTypeID { get; set; }

        public string ServiceTypeName { get; set; }
    }

    public static class ServiceTypeDAO
    {
        public static List<ServiceType> GetAllServiceType()
        {
            var query = string.Format("EXEC USP_GetAllServiceType");
            var dt = DataProvider.Instance.ExecuteQuery(query);
            var serviceTypes= new List<ServiceType>();
            foreach (DataRow row in dt.Rows)
            {
                var serviceType = new ServiceType
                {
                    ServiceTypeID = Extension.TryParseInt(row["serviceTypeID"].ToString()),
                    ServiceTypeName = row["serviceTypeName"].ToString()
                };

                serviceTypes.Add(serviceType);
            }
            return serviceTypes;
        }

        public static bool EditServiceType(int serviceTypeID, string serviceTypeName)
        {
            var query = string.Format("EXEC USP_EditServiceType @serviceTypeID = {0}, @serviceTypeName = N'{1}'", serviceTypeID, serviceTypeName);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteServiceType(int serviceTypeID)
        {
            var query = string.Format("EXEC USP_DeleteServiceType @serviceTypeID = {0}", serviceTypeID);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int GetLastIndexOfServiceType()
        {
            var query = string.Format("EXEC USP_GetLastIndexServiceType");
            return DataProvider.Instance.GetInt(query);
        }

        public static ServiceType AddServiceType(string serviceTypeName)
        {
            var query = string.Format("EXEC USP_AddServiceType @serviceTypeName = N'{0}'", serviceTypeName);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                var serviceType = new ServiceType
                {
                    ServiceTypeID = GetLastIndexOfServiceType(),
                    ServiceTypeName = serviceTypeName
                };

                return serviceType;
            }
            else
            {
                return null;
            }
        }
    }
}
