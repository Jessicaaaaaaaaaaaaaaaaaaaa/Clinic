//using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITest.Entities;
using WebAPITest.Models;

namespace WebAPITest.Controllers
{
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegisrationRepository _registrationRepo;
        //private readonly IMapper _mapper;
        

        public RegistrationController( IRegisrationRepository regisrationRepository) /*,IMapper mapper)*/ 
        {
            _registrationRepo = regisrationRepository;
            //_mapper = mapper;
        }

        
        [HttpGet("api/courses")]
        public IActionResult GetCourse()
        {
            var allCourse = _registrationRepo.GetAllCourses();

            //return Ok(_mapper.Map<IEnumerable<CourseDto>>(allCourse));

            var courseDto = new List<CourseDto>();


            foreach(var course in allCourse)
            {
                courseDto.Add(new CourseDto()
                {
                    Name = course.Name,
                    Credits = course.Credits
                }); ;
            }

            return Ok(courseDto);
        }




























        //[HttpGet("api/courses")]
        //[HttpHead]
        //public IActionResult GetCourse()
        //{
        //    var allCourses = _registrationRepo.GetAllCourses();
        //    //1.return new JsonResult(allCourses);
        //    //2. return Ok
        //    //3. Add CourseDTO
        //    var coursesDTo = new List<CourseDto>();
        //    foreach (var course in allCourses)
        //    {
        //        coursesDTo.Add(new CourseDto()
        //        {
        //            Name = course.Name,
        //            Credits = course.Credits
        //        });
        //    }

        //    //4. return Ok(allCourses);
        //    return Ok(coursesDTo);

        //}
        
        /*
        [HttpGet("api/courses", Name ="GetAllCourses")]
        public IActionResult GetCourse()
        {
            var allCourses = _registrationRepo.GetAllCourses();
            
            return Ok(_mapper.Map<IEnumerable<CourseDto>>(allCourses));

        }

        [HttpGet("api/course/{courseId}")]
        public IActionResult GetCourse(int courseId)
        {
            var result = _registrationRepo.GetCourse(courseId);

            if (result != null)
            {
                //return new JsonResult(result);
                return Ok(result);
            }
            else
                return NotFound();


        }

        [HttpPost("api/addcourse")]
        public ActionResult<CourseDto> AddCourse([FromBody]CreateCourseDto course)
        {
            if (course == null)
                return NotFound();
            var courseEntity = _mapper.Map<Entities.Course>(course);

            _registrationRepo.AddCourse(courseEntity);

            //return RedirectToAction("GetAllCourses");
            return Ok();
        }


        [HttpGet("api/students")]
        public IActionResult GetStudent()
        {
            var allStudents = _registrationRepo.GetAllStudents();
            return new JsonResult(allStudents);
        }
        */
    }
}
