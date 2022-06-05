using System.Collections.Generic;
using System.Data;
using CDM.DAO;

namespace DAO.Models
{
    public partial class Account
    {
        public int AccountID { get; set; }

        public int EmployeeID { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }
    }

    public static class AccountDAO
    {
        public static List<Account> GetAllAccount()
        {
            var query = string.Format("EXEC USP_GetAllAccount");
            var dt = DataProvider.Instance.ExecuteQuery(query);
            var accounts = new List<Account>();
            foreach (DataRow row in dt.Rows)
            {
                var account = new Account
                {
                    AccountID = Extension.TryParseInt(row["accountID"].ToString()),
                    EmployeeID = Extension.TryParseInt(row["employeeID"].ToString()),
                    Username = row["username"].ToString(),
                    Password = row["password"].ToString()
                };

                accounts.Add(account);
            }
            return accounts;
        }

        public static int GetLastIndexOfAccount()
        {
            var query = string.Format("EXEC USP_GetLastIndexAccount");
            return DataProvider.Instance.GetInt(query);
        }

        public static Account AddAccount(int employeeID, string username, string password)
        {
            var query = string.Format("EXEC USP_AddAccount @employeeID = {0}, @username = N'{1}', @password = N'{2}'", employeeID, username, password);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                var account = new Account
                {
                    AccountID = GetLastIndexOfAccount(),
                    EmployeeID = employeeID,
                    Username = username,
                    Password = password
                };

                return account;
            }
            else
            {
                return null;
            }
        }

        public static bool EditAccount(int accountID, string username, string password)
        {
            var query = string.Format("EXEC USP_EditAccount @accountID = {0}, @username = N'{1}', @password = N'{2}'", accountID, username, password);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteAccount(int employeeID)
        {
            var query = string.Format("EXEC USP_DeleteAccount @employeeID = {0}", employeeID);
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
