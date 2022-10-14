using MVC.Models;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        snadDBEntities context=new snadDBEntities();
        public ActionResult Index()
        {
           
           //List<Employee> employees = context.E.Include("Department").ToList();
           List<Employee> employees = context.employees.ToList();
            return View(employees);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult create()
        {
            return View();

        }
        [HttpPost]
        public ActionResult Create(Employee emp)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            emp.EmpId = 0;
            context.employees.Add(emp);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        public ActionResult Details(int id)
            
        {
            var emp = context.employees.Where(x => x.EmpId == id).SingleOrDefault();
            return View(emp);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var emp = context.employees.Where(x => x.EmpId == id).SingleOrDefault();
            return View(emp);
        }
        [HttpPost]
        public ActionResult Edit(Employee emp)
        {
            context.Entry<Employee>(emp).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult Delete(int id)
        {
            var emp=context.employees.Where(x => x.EmpId == id).SingleOrDefault();
            context.employees.Remove(emp);
            context.SaveChanges();
            return RedirectToAction("index");
        }

         
    }
}