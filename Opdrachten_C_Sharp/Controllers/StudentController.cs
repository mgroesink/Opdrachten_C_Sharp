using Microsoft.AspNetCore.Mvc;
using Opdrachten_C_Sharp.Models;
using System.Collections.Generic;

namespace Opdrachten_C_Sharp.Controllers
{
    public class StudentController : Controller
    {
        private static List<Student> _students = DataProvider.CreateStudents();

        public IActionResult Index()
        {
            return View(_students);
        }

        public IActionResult Create()
        {
            return View();
        }
    }
}
