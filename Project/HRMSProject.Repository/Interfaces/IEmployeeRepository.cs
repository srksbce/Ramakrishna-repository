﻿using HRMSProject.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRMSProject.Repository.Interfaces
{
    public interface IEmployeeRepository
    {
        List<Employee> GetAllEmployees();
    }
}
