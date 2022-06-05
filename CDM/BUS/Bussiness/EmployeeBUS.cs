using DAO.Models;
using System.Collections.Generic;

namespace BUS.Bussiness
{
    public static class EmployeeBUS
    {
        public static List<Employee> GetAllEmployee()
        {
            return EmployeeDAO.GetAllEmployee();
        }

        public static Employee AddEmployee(string employeeName, string employeeMobile,
            string employeeGender, string employeeEmailID, string employeeAddress)
        {
            return EmployeeDAO.AddEmployee(employeeName, employeeMobile, employeeGender,
                employeeEmailID, employeeAddress);
        }

        public static bool EditEmployee(int employeeID, string employeeName, string employeeMobile,
            string employeeGender, string employeeEmailID, string employeeAddress)
        {
            return EmployeeDAO.EditEmployee(employeeID, employeeName, employeeMobile
                , employeeGender, employeeEmailID, employeeAddress);
        }

        public static bool DeleteEmployee(int employeeID)
        {
            return EmployeeDAO.DeleteEmployee(employeeID);
        }
    }
}
