using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMSProject.Bussiness.Interfaces;
using HRMSProject.Models;
using HRMSProject.Repository.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace HRMSProject.Bussiness
{
           
         public class EmployeeBussiness : IEmployeeBussiness
    {
        private readonly IEmployeeRepository _empRepository;
        public EmployeeBussiness(IEmployeeRepository empRepository)
        {
            _empRepository = empRepository;
        }

        public List<EmployeeVM> GetAllEmployess()
        {
            var employees = _empRepository.GetAllEmployees();
            List<EmployeeVM> emps = new List<EmployeeVM>();
            foreach (var emp in employees)
            {
                EmployeeVM e = new EmployeeVM()
                {
                    DeptId = emp.DeptId,
                    EmpId = emp.EmpId,
                    EmpName = emp.EmpName,
                    EmpSalary = emp.EmpSalary
            };
                emps.Add(e);     
            }
            return emps;
        }
    }
}
