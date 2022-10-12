using HRMSProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Bussiness.Interfaces
{
    public interface IEmployeeBussiness
    {
        List<EmployeeVM> GetAllEmployess();

    }
}
