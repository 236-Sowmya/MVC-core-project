using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_core_project.Controllers
{
    public class StudentController : Controller
    {
        public string Index()
        {
            return "This is Default action";
        }
        public string GetStudentName()
        {
            return "Sowmya";
        }
    }
}
