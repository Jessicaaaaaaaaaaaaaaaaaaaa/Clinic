using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FinalCourseRegistrationMVC.Models;
using Microsoft.AspNetCore.Mvc;


namespace FinalCourseRegistrationMVC.Controllers
{
    public class StudentController : Controller
    {
        private readonly IRegistration _reg;
        public StudentController(IRegistration reg)
        {
            _reg = reg;
        }

        public IActionResult Index()
        {
            var model = _reg.GetAllStudents();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _reg.GetStudent(id);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
         public IActionResult Create(Students student)
           {
               if (ModelState.IsValid)
               {
                   Students newstudent=_reg.AddStudent(student);
                   return RedirectToAction("details", new { Id = newstudent.StudentId });
               }
               return View();
           }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
         {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
         }
    }

}

