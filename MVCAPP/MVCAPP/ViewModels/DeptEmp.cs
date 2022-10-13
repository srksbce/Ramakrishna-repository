using MVCAPP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAPP.ViewModels
{
    public class DeptEmp
    {
        public Employee employee { get; set; } 
        public Department Department { get; set; }

    }
}