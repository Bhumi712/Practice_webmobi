using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BhumiMehta_WebMobi.Models;

namespace BhumiMehta_WebMobi.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmployeeDbContext _dbContext;

        public EmployeeController()
        {
            _dbContext = new EmployeeDbContext();
        }
        // GET: Employee
        public ActionResult Index()
        {
            var  employeeList = _dbContext.Employee.ToList();
            return View(employeeList);
        }

        public ActionResult AddEmployees()
        {
            var employeeViewModel = new EmployeeViewModel()
            {
                Department = this._dbContext.Department.ToList(),
                Employee = new Employee()
            };
            return View("EmployeeForm", employeeViewModel);
        }

        public ActionResult Edit(int id)
        {
            var employees = _dbContext.Employee.FirstOrDefault( x => x.EmployeeId == id);
            var department = this._dbContext.Department.ToList();

            var viewModel = new EmployeeViewModel()
            {
                Department = department,
                Employee = employees
            };
            return View("EmployeeForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("AddEmployees", "Employee");
            }

            if (employee.EmployeeId == 0)
                this._dbContext.Employee.Add(employee);

            else
            {
                var employeesDb = this._dbContext.Employee.FirstOrDefault(x => x.EmployeeId == employee.EmployeeId);
                employeesDb.EmployeeFirstName = employee.EmployeeFirstName;
                employeesDb.EmployeeLastName = employee.EmployeeLastName;
                employeesDb.EmployeeGender = employee.EmployeeGender;
                employeesDb.EmployeeDOB = employee.EmployeeDOB;
                employeesDb.EmployeeDepartment = employee.EmployeeDepartment;
            }

            this._dbContext.SaveChanges();
            return RedirectToAction("Index", "Employee");
        }

        public ActionResult Delete(int id)
        {
            var employeeDb = _dbContext.Employee.FirstOrDefault(x => x.EmployeeId == id);
            this._dbContext.Employee.Remove(employeeDb);
            this._dbContext.SaveChanges();

            return RedirectToAction("Index", "Employee");
        }
    }

    internal class EmployeeViewModel
    {
        public EmployeeViewModel()
        {
        }

        public object Department { get; set; }
        public Employee Employee { get; set; }
    }
}