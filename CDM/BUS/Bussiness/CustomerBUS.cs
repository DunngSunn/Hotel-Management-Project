using DAO.Models;
using System.Collections.Generic;

namespace BUS.Bussiness
{
    public static class CustomerBUS
    {
        public static List<Customer> GetAllCustomer()
        {
            return CustomerDAO.GetAllCustomer();
        }

        public static bool EditCustomer(int customerID, string customerName, string customerMobile,
            string customerNationality, string customerGender, string customerDateofbirth,
            string customerIndentification, string customerAddress)
        {
            return CustomerDAO.EditCustomer(customerID, customerName, customerMobile,
                customerNationality, customerGender, customerDateofbirth, customerIndentification,
                customerAddress);
        }

        public static bool DeleteCustomer(int customerID)
        {
            return CustomerDAO.DeleteCustomer(customerID);
        }

        public static Customer AddCustomer(string customerName, string customerMobile,
            string customerNationality, string customerGender, string customerDateofbirth,
            string customerIndentification, string customerAddress)
        {
            return CustomerDAO.AddCustomer(customerName, customerMobile, customerNationality,
                customerGender, customerDateofbirth, customerIndentification, customerAddress);
        }
    }
}
