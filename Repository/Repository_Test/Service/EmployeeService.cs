using Microsoft.EntityFrameworkCore;
using Repository_Test.ApplicationDbContext;
using Repository_Test.Areas.Employees.Data;
using Repository_Test.Areas.Employees.Data.Entity;
using Repository_Test.Areas.Employees.Models;
using Repository_Test.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository_Test.Service
{
    public class EmployeeService : IEmployee 
    {
        private readonly AppDbContext _context;

        public EmployeeService(AppDbContext context)
        {
            _context = context;
        }


        //Employee Info

        public async Task<int> SaveEmployee(Employee employee)
        {
            if (employee.Id != 0)
                _context.employees.Update(employee);
            else
                _context.employees.Add(employee);

             await _context.SaveChangesAsync();
            return employee.Id;
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await _context.employees.AsNoTracking().ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            return await _context.employees.FindAsync(id);
        }

        public async Task<string> CheckEmpCode(string empCode)
        {
            var result = await _context.employees.Where(x => x.employeeCode == empCode).Select(x => x.employeeCode).FirstOrDefaultAsync();
            if (result != null)
            {
                result = "duplicate";
                return result;
            }
            return result;
        }

        public async Task<bool> DeleteEmployeeById(int id)
        {
            _context.employees.Remove(_context.employees.Find(id));
            return 1 == await _context.SaveChangesAsync();
        }
    }
}
