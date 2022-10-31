using Repository_Test.Areas.Employees.Data.Entity;
using Repository_Test.Areas.Employees.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.Service.Interface
{
    public interface IEmployee
    {
        Task<int> SaveEmployee(Employee employee);
        Task<IEnumerable<Employee>> GetEmployee();
        Task<Employee> GetEmployeeById(int id);
        Task<string> CheckEmpCode(string empCode);
        Task<bool> DeleteEmployeeById(int id);
    }
}
