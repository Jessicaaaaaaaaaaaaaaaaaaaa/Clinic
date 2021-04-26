using CourseRegistration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegistration.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Instructors()
        {
            InstructorViewModel ivm = new InstructorViewModel();

            List<DTO.Instructors> instructors = new List<DTO.Instructors>()
            {
                new DTO.Instructors{ InstructorId = 1, FirstName = "Albus", LastName = "Dumbledore", 
                    Email = "adumbledore@hogwarts.co.uk", Course = "Transfiguration 101"},
                new DTO.Instructors{ InstructorId = 2, FirstName = "Minerva", LastName = "McGonagall",
                    Email = "mmcgonagall@hogwarts.co.uk", Course = "Transfiguration 202"},
                new DTO.Instructors{ InstructorId = 3, FirstName = "Severus", LastName = "Snape",
                    Email = "ssnape@hogwarts.co.uk", Course = "Defence Against the Dark Arts"}
            };
            ivm.Instructors = instructors;
            return View(ivm);
        }
        public IActionResult Students()
        {
            StudentVM svm = new StudentVM();

            List<DTO.Students> students = new List<DTO.Students>() 
            {
                new DTO.Students{ StudentId = 1, FirstName = "Harry", LastName = "Potter",
                    Email = "hpotter@hogwarts.co.uk", Phone = "+44 20 1234 5678"},
                new DTO.Students{ StudentId = 2, FirstName = "Hermione", LastName = "Granger",
                    Email = "hgranger@hogwarts.co.uk", Phone = "+44 20 9101 1121"},
                new DTO.Students{ StudentId = 3, FirstName = "Ronald", LastName = "Weasley",
                    Email = "rweasley@hogwarts.co.uk", Phone = "+44 20 3141 5161"}
            };
            svm.Students = students;
            return View(svm);
        }

        public IActionResult Courses() 
        {
            CourseVM cvm = new CourseVM();

            List<DTO.Courses> students = new List<DTO.Courses>()
            {
                new DTO.Courses{ CourseId = 1, CourseNumber = 1, 
                    CourseName = "Transfiguration 101",
                    Description = "Learn how to turn your mom into a mouse. Beginners welcome!"},
                new DTO.Courses{ CourseId = 2, CourseNumber = 2, 
                    CourseName = "Transfiguration 202",
                    Description = "Don't take this course unless you know how to turn your mom into a mouse."},
                new DTO.Courses{ CourseId = 3, CourseNumber = 3, 
                    CourseName = "Defence Against the Dark Arts",
                    Description = "You pretty much need this course to survive your life."}
            };
            cvm.Courses = students;
            return View(cvm);
        }

        public IActionResult Registration()
        {
            RegistrationVM ivm = new RegistrationVM();

            List<DTO.Registration> registration = new List<DTO.Registration>()
            {
                new DTO.Registration{ InstructorId = 1, RegistrationType = "full time", StudentId = 1,
                    CourseId = 1},
                new DTO.Registration{ InstructorId = 2, RegistrationType = "part time", StudentId = 2,
                    CourseId = 2},
                new DTO.Registration{ InstructorId = 3, RegistrationType = "full time", StudentId = 3,
                    CourseId = 3}
            };
            ivm.Registration = registration;
            return View(ivm);
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
