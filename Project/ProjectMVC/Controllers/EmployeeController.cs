using HRMSProject.Bussiness.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjectMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeBussiness _employeeBussiness;
        public EmployeeController(IEmployeeBussiness empBussiness )
        {
            _employeeBussiness = empBussiness;
        }
        public IActionResult Index()
        {
            var list = _employeeBussiness.GetAllEmployess();
            return View(list);
        }
    }
}
