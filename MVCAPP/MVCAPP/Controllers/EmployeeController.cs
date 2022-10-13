using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAPP.Models;
using MVCAPP.ViewModels;

namespace MVCAPP.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee e = new Employee()
            {
                EmpId = 101,
                EmpName = "Ramakrishna",
                EmpSalary = 40000
            };
            Department d = new Department()
            {
                DeptId = 111,
                DeptName = "Testing",
                DeptLocation = "Hyderabad"
            };
            DeptEmp obj = new DeptEmp();
            obj.employee = e;
            obj.Department = d;
            return View(obj);
        }
    }
}