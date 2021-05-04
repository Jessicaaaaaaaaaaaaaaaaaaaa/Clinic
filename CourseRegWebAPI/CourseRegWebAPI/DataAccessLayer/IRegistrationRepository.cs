using CourseRegWebAPI.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseRegWebAPI.DataAccessLayer
{
    public interface IRegistrationRepository 
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudentId(int StudentId);
        void AddStudent(Student student);
        void UpdateStudent(Student student);
        void DeleteStudent(Student student);


        IEnumerable<Course> GetAllCourses();
        Student GetCourseId(int CourseId);
        void AddCourse(Course course);
        void UpdateCourse(Course course);
        void DeleteCourse(Course course);


        IEnumerable<Instructor> GetAllInstructors();
        Student GetInstructorId(int InstructorId);
        void AddInstructor(Instructor instructor);
        void UpdateInstructor(Instructor instructor);
        void DeleteInstructor(Instructor instructor);


        IEnumerable<Registration> GetAllRegistrations();
        Student GetRegistrationId(int RegistrationId);
        void AddRegistration(Registration registration);
        void UpdateRegistration(Registration registration);
        void DeleteRegistration(Registration registration);
    }
}
