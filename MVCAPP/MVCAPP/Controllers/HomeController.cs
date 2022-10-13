using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCAPP.Models;

namespace MVCAPP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
            //return Content("Welcome to MVC");
        }
        public ActionResult Index1()
        {
            return View("sample");
        }
        public ActionResult Show()
        {
            Employee emp = new Employee()
            {
                EmpId = 101,
                EmpName = "Ramakrishna",
                EmpSalary = 50000

            };
            return View(emp) ; 
        }
        public ActionResult DisplayEmployees()
        {
            List<Employee> employees = new List<Employee>();
                Employee e = new Employee()
                {
                    EmpId = 101,
                    EmpName = "RAMAKRISHNA",
                    EmpSalary = 60000
                };
            employees.Add(e);

            e = new Employee()
            {
                EmpId = 102,
                EmpName = "SANTHOSH",
                EmpSalary = 70000

            };
            employees.Add(e) ;

            e = new Employee()
            {
                EmpId = 103,
                EmpName = "ARJUN",
                EmpSalary = 80000
            };
            employees.Add(e);
            return View(employees) ;
        }
        public ActionResult EnterData()
        {
            return View();
        }

        public ActionResult DispEmp(Employee emp )

        {
            return View("show",emp);
        }

    }
}