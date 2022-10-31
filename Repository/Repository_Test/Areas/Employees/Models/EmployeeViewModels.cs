using Repository_Test.Areas.Employees.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.Areas.Employees.Models
{
    public class EmployeeViewModels
    {
        public int employeeId { get; set; }
        public string employeeCode { get; set; }
        public string employeeName { get; set; }
        public string employeeDesignation { get; set; }
        public string employeeSalary { get; set; }

        public IEnumerable<Employee> employees;
    }
}
