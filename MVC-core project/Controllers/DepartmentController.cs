using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_core_project.Models;

namespace MVC_core_project.Controllers
{
    public class DepartmentController : Controller
    {
        public IActionResult Index()
        {
            IList<Department> Dept = new List<Department>();
            Dept.Add(new Department { DeptID = 203, DeptName = "IT", DeptLoc = "Bangalore" });
            Dept.Add(new Department { DeptID = 204, DeptName = "Marketing", DeptLoc = "Hyderabad" });
            Dept.Add(new Department { DeptID = 205, DeptName = "Developer", DeptLoc = "Chennai" });
            ViewData["Dept"] = Dept;
            return View();
        }
    }
}
