using DAO.Models;
using System.Collections.Generic;

namespace BUS.Bussiness
{
    public static class AccountBUS
    {
        public static bool GetExistingAccount(string username, string password)
        {
            foreach (var account in AccountDAO.GetAllAccount())
            {
                if (account.Username.Equals(username) && account.Password.Equals(password))
                {
                    return true;
                }
            }

            return false;
        }

        public static List<Account> GetAllAccount()
        {
            return AccountDAO.GetAllAccount();
        }

        public static Account AddAccount(int employeeID, string username, string password)
        {
            return AccountDAO.AddAccount(employeeID, username, password);
        }

        public static bool EditAccount(int accountID, string username, string password)
        {
            return AccountDAO.EditAccount(accountID, username, password);
        }

        public static bool DeleteAccount(int employeeID)
        {
            return AccountDAO.DeleteAccount(employeeID);
        }
    }
}
