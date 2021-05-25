using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FinalCourseRegistrationMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalCourseRegistrationMVC.Controllers
{
    public class InstructorController : Controller
    {

            private readonly IRegistration _reg;
            public InstructorController(IRegistration reg)
            {
                _reg = reg;
            }

            public IActionResult Index()
            {
                var model = _reg.GetAllInstructors();
                return View(model);
            }

           /*public IActionResult Details(int id)
            {
               HomeAnimalsViewModel homeAnimalsViewModel = new HomeAnimalsViewModel()
              {
                Instructor = _reg.GetInstructor(id),
                PageTitle = "Instructor";
            };

            return View(homeAnimalsViewModel);
            }*/

           public IActionResult Details(int id)
           {    
              var model = _reg.GetInstructor(id);
              return View(model);
           }

           [HttpGet]
            public IActionResult Create()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Create(Instructors instructor)
            {
                if (ModelState.IsValid)
                {
                    Instructors newinstructor=_reg.AddInstructor(instructor);
                    return RedirectToAction("details", new { ID = newinstructor.InstructorId });
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
