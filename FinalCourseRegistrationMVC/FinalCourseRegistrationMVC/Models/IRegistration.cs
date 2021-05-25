using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalCourseRegistrationMVC.Models
{
    public interface IRegistration 
    {

        // Students
        IEnumerable<Students> GetAllStudents();
        Students GetStudent(int StudentId);
        Students AddStudent(Students student);
        void DeleteStudent(int Id);
        void UpdateStudent(Students studentChange);


        // Courses
        IEnumerable<Courses> GetAllCourse();
        Courses GetCourse(int CourseId);
        Courses AddCourse(Courses course);
        void DeleteCourse(int Id);
        void UpdateCourse(Courses courseChange);


        // Instructors
        IEnumerable<Instructors> GetAllInstructors();
        Instructors GetInstructor(int InstructorId);
        Instructors AddInstructor(Instructors instructor);
        void DeleteInstructor(int Id);
        void UpdateInstructor(Instructors instructorChanges);


        // Registration
        void AddRegistration(Registration registration);
        void DeleteRegistration(int Id);
        Registration UpdateRegistration(Registration registrationChanges);
        IEnumerable<Registration> GetAllRegistrations();
        Registration GetRegistrations(int Id);

    }
}

