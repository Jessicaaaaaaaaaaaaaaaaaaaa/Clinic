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

            List<DTO.Instructor> instructors = new List<DTO.Instructor>()
            {
                new DTO.Instructor{ InstructorId = 1, FirstName = "Albus", LastName = "Dumbledore", 
                    Email = "adumbledore@hogwarts.co.uk", Course = "Transfiguration 101"},
                new DTO.Instructor{ InstructorId = 2, FirstName = "Minerva", LastName = "McGonagall",
                    Email = "mmcgonagall@hogwarts.co.uk", Course = "Transfiguration 202"},
                new DTO.Instructor{ InstructorId = 3, FirstName = "Severus", LastName = "Snape",
                    Email = "ssnape@hogwarts.co.uk", Course = "Defence Against the Dark Arts"}
            };
            ivm.Instructors = instructors;
            return View(ivm);
        }

        public IActionResult Students()
        {
            StudentVM svm = new StudentVM();

            List<DTO.Student> students = new List<DTO.Student>() 
            {
                new DTO.Student{ StudentId = 1, FirstName = "Harry", LastName = "Potter",
                    Email = "hpotter@hogwarts.co.uk", Phone = "+44 20 1234 5678"},
                new DTO.Student{ StudentId = 2, FirstName = "Hermione", LastName = "Granger",
                    Email = "hgranger@hogwarts.co.uk", Phone = "+44 20 9101 1121"},
                new DTO.Student{ StudentId = 3, FirstName = "Ronald", LastName = "Weasley",
                    Email = "rweasley@hogwarts.co.uk", Phone = "+44 20 3141 5161"}
            };
            svm.Students = students;
            return View(svm);
        }

        public IActionResult Courses() 
        {
            CourseVM cvm = new CourseVM();

            List<DTO.Course> courses = new List<DTO.Course>()
            {
                new DTO.Course{ CourseId = 1, CourseNumber = 1, 
                    CourseName = "Transfiguration 101",
                    Description = "Learn how to turn your mom into a mouse. Beginners welcome!"},
                new DTO.Course{ CourseId = 2, CourseNumber = 2, 
                    CourseName = "Transfiguration 202",
                    Description = "Don't take this course unless you know how to turn your mom into a mouse."},
                new DTO.Course{ CourseId = 3, CourseNumber = 3, 
                    CourseName = "Defence Against the Dark Arts",
                    Description = "You pretty much need this course to survive your life."}
            };
            cvm.Courses = courses;
            return View(cvm);
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
