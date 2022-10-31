using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Repository_Test.Areas.Employees.Models;
using Repository_Test.Areas.Employees.Data.Entity;
using Repository_Test.Service.Interface;

namespace Repository_Test.Areas.Employees.Controllers
{
    [Area("Employees")]
    public class EmployeeController : Controller
    {
        private readonly IEmployee employee;

        public EmployeeController(IEmployee employee)
        {
            this.employee = employee;
        }

        // GET: 
        public async Task<IActionResult> Index()
        {
            EmployeeViewModels model = new EmployeeViewModels
            {
                employees = await employee.GetEmployee(),
            };


            return View(model);
        }

        // POST:
        [HttpPost]
        public async Task<IActionResult> Index([FromForm] EmployeeViewModels model)
        {
            Employee data = new Employee
            {
                Id = model.employeeId,
                employeeCode = model.employeeCode,
                employeeName = model.employeeName,
                employeeDesignation = model.employeeDesignation,
                employeeSalary = model.employeeSalary,
            };

            await employee.SaveEmployee(data);

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> CheckEmpCode(string empCode)
        {
            var result = await employee.CheckEmpCode(empCode);
            return Json(result);
        }

        public async Task<IActionResult> Delete(int Id)
        {
            await employee.DeleteEmployeeById(Id);
            return RedirectToAction(nameof(Index));
        }


    }
}