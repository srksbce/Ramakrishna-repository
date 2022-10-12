using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HRMSProject.Repository.Interfaces;
using HRMSProject.Repository.Models;

namespace HRMSProject.Repository
{
   public class EmployeeRepository : IEmployeeRepository
    {
        private readonly snadDBContext myContext;
        public EmployeeRepository(snadDBContext context)
        {
            myContext = context;   
        }

        public List<Employee> GetAllEmployees()
        {
            return myContext.Employees.ToList();
            
        }
    }
}
