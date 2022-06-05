using CDM.DAO;
using System.Collections.Generic;
using System.Data;

namespace DAO.Models
{
    public partial class Employee
    {
        public int EmployeeID { get; set; }

        public string EmployeeName { get; set; }

        public string EmployeeMobile { get; set; }

        public string EmployeeGender { get; set; }

        public string EmployeeEmailID { get; set; }

        public string EmployeeAddress { get; set; }
    }

    public static class EmployeeDAO
    {
        public static List<Employee> GetAllEmployee()
        {
            var query = string.Format("EXEC USP_GetAllEmployee");
            var dt = DataProvider.Instance.ExecuteQuery(query);
            var employees = new List<Employee>();
            foreach (DataRow row in dt.Rows)
            {
                var employee = new Employee();

                int.TryParse(row["employeeID"].ToString(), out var employeeID);
                employee.EmployeeID = employeeID;
                employee.EmployeeName = row["employeeName"].ToString();
                employee.EmployeeMobile = row["employeeMobile"].ToString();
                employee.EmployeeGender = row["employeeGender"].ToString();
                employee.EmployeeEmailID = row["employeeEmailID"].ToString();
                employee.EmployeeAddress = row["employeeAddress"].ToString();

                employees.Add(employee);
            }
            return employees;
        }

        public static int GetLastIndexOfAccount()
        {
            var query = string.Format("EXEC USP_GetLastIndexEmployee");
            return DataProvider.Instance.GetInt(query);
        }

        public static Employee AddEmployee(string employeeName, string employeeMobile, string employeeGender, string employeeEmailID, string employeeAddress)
        {
            var query = string.Format("EXEC USP_AddEmployee @employeeName = N'{0}', @employeeMobile = N'{1}', @employeeGender = N'{2}', @employeeEmailID = N'{3}', @employeeAddress = N'{4}'", employeeName, employeeMobile, employeeGender, employeeEmailID, employeeAddress);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                var employee = new Employee
                {
                    EmployeeID = GetLastIndexOfAccount(),
                    EmployeeName = employeeName,
                    EmployeeMobile = employeeMobile,
                    EmployeeGender = employeeGender,
                    EmployeeEmailID = employeeEmailID,
                    EmployeeAddress = employeeAddress
                };

                return employee;
            }
            else
            {
                return null;
            }
        }

        public static bool EditEmployee(int employeeID, string employeeName, string employeeMobile, string employeeGender, string employeeEmailID, string employeeAddress)
        {
            var query = string.Format("EXEC USP_EditEmployee @employeeID = {0}, @employeeName = N'{1}', @employeeMobile = N'{2}', @employeeGender = N'{3}', @employeeEmailID = N'{4}', @employeeAddress = N'{5}'", employeeID, employeeName, employeeMobile, employeeGender, employeeEmailID, employeeAddress);
            if (DataProvider.Instance.ExecuteNonQuery(query) != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool DeleteEmployee(int employeeID)
        {
            var query = string.Format("EXEC USP_DeleteEmployee @employeeID =  {0}", employeeID);
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
