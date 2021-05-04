using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Entities
{
    public class RegistrationRepository : IRegisrationRepository
    {
        private readonly AppDbContext _context;

        public RegistrationRepository(AppDbContext context)
        {
            _context = context;
        }
        public void AddCourse(Course course)
        {
            if (course == null)
                throw new ArgumentNullException(nameof(course));

            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public void AddInstructor(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }

        public Registration AddNewRegistration(Registration registration)
        {
            throw new NotImplementedException();
        }

        public void AddStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void DeleteCourse(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteInstructor(int Id)
        {
            throw new NotImplementedException();
        }

        public void DeleteRegistration(int RegistrationId)
        {
            throw new NotImplementedException();
        }

        public void DeleteStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _context.Courses.ToList();
        }

        public IEnumerable<Instructor> GetAllInstructors()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAllStudents()
        {
            throw new NotImplementedException();
        }

        public Course GetCourse(int CourseId)
        {
            throw new NotImplementedException();
        }

        public Instructor GetInstructor(int InstructorId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Registration> GetRegistrations()
        {
            throw new NotImplementedException();
        }

        public Student GetStudent(int StudentId)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(Course courseChange)
        {
            throw new NotImplementedException();
        }

        public void UpdateInstructor(Instructor instructorChanges)
        {
            throw new NotImplementedException();
        }

        public Registration UpdateRegistration(Registration registrationChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student studentChange)
        {
            throw new NotImplementedException();
        }
    }
}
