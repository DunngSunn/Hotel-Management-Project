using CDM.DAO;
using System.Collections.Generic;
using System.Data;

namespace DAO.Models
{
    public partial class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerMobile { get; set; }

        public string CustomerNationality { get; set; }

        public string CustomerGender { get; set; }

        public string CustomerDateofbirth { get; set; }

        public string CustomerIndentification { get; set; }

        public string CustomerAddress { get; set; }
    }

    public static class CustomerDAO
    {
        public static List<Customer> GetAllCustomer()
        {
            var query = string.Format("EXEC USP_GetAllCustomer");

            var dt = DataProvider.Instance.ExecuteQuery(query);
            var customers = new List<Customer>();
            foreach (DataRow row in dt.Rows)
            {
                var customer = new Customer
                {
                    CustomerID = Extension.TryParseInt(row["customerID"].ToString()),
                    CustomerName = row["customerName"].ToString(),
                    CustomerMobile = row["customerMobile"].ToString(),
                    CustomerNationality = row["customerNationality"].ToString(),
                    CustomerGender = row["customerGender"].ToString(),
                    CustomerDateofbirth = Extension.TryParseDateTime(row["customerDateofbirth"].ToString()).ToShortDateString(),
                    CustomerIndentification = row["customerIndentification"].ToString(),
                    CustomerAddress = row["customerAddress"].ToString()
                };

                customers.Add(customer);
            }
            return customers;
        }

        public static int GetLastIndexOfCustomer()
        {
            var query = string.Format("EXEC USP_GetLastIndexCustomer");
            return DataProvider.Instance.GetInt(query);
        }

        public static Customer AddCustomer(string customerName, string customerMobile, string customerNationality, string customerGender, string customerDateofbirth, string customerIndentification, string customerAddress)
        {
            var query = string.Format("EXEC USP_AddCustomer @customerName = N'{0}', @customerMobile = N'{1}', @customerNationality = N'{2}', @customerGender = N'{3}', @customerDateofbirth = '{4}', @customerIndentification = N'{5}', @customerAddress = N'{6}'", customerName, customerMobile, customerNationality, customerGender, customerDateofbirth, customerIndentification, customerAddress);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                var customer = new Customer
                {
                    CustomerID = GetLastIndexOfCustomer(),
                    CustomerName = customerName,
                    CustomerMobile = customerMobile,
                    CustomerNationality = customerNationality,
                    CustomerGender = customerGender,
                    CustomerDateofbirth = customerDateofbirth,
                    CustomerIndentification = customerIndentification,
                    CustomerAddress = customerAddress
                };

                return customer;
            }
            else
            {
                return null;
            }
        }

        public static bool EditCustomer(int customerID, string customerName, string customerMobile, string customerNationality, string customerGender, string customerDateofbirth, string customerIndentification, string customerAddress)
        {
            var query = string.Format("EXEC USP_EditCustomer @customerID = {0}, @customerName = N'{1}', @customerMobile = N'{2}', @customerNationality = N'{3}', @customerGender = N'{4}', @customerDateofbirth = '{5}', @customerIndentification = N'{6}', @customerAddress = N'{7}'", customerID, customerName, customerMobile, customerNationality, customerGender, customerDateofbirth, customerIndentification, customerAddress);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteCustomer(int customerID)
        {
            var query = string.Format("EXEC USP_DeleteCustomer @customerID = {0}", customerID);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
