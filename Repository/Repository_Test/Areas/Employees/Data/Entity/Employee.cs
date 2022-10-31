using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.Areas.Employees.Data.Entity
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string employeeCode { get; set; }
        public string employeeName { get; set; }
        public string employeeDesignation { get; set; }
        public string employeeSalary { get; set; }
    }
}
