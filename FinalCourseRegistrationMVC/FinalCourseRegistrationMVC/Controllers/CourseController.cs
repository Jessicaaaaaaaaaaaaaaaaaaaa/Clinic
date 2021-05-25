using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using FinalCourseRegistrationMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FinalCourseRegistrationMVC.Controllers
{
    public class CourseController : Controller
    {

        private readonly IRegistration _reg;
        public CourseController(IRegistration reg)
        {
            _reg = reg;
        }

        // CRUD Create *******************************************************
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Courses course)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    Courses newcourse = _reg.AddCourse(course);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException /* dex */)
            {
                //Log the error (uncomment dex variable name and add a line here to write a log.
                ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists see your system administrator.");
            }
            return View();
        }

        // CRUD Read *******************************************************
        [HttpGet]
        public IActionResult Index()
        {
            var model = _reg.GetAllCourse();
            return View(model);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var model = _reg.GetCourse(id);
            return View(model);
        }

        // CRUD Update *******************************************************
        [HttpGet]
        public IActionResult Update(int id) 
        {
            var model = _reg.GetCourse(id);
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Courses courseChanges)
        {
            if (ModelState.IsValid)
            {
                Courses updatecourse = _reg.UpdateCourse(courseChanges);
                return RedirectToAction("index");
            }
           
            return View();
        }

        // CRUD Delete *******************************************************
        [HttpGet]
        public IActionResult Delete(int Id) 
        {
            var model = _reg.GetCourse(Id);
            return View(model);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int Id)
        {
            _reg.DeleteCourse(Id);
            return RedirectToAction("Index");
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
