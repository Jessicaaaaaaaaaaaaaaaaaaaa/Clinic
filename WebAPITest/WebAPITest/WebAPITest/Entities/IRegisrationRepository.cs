using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPITest.Entities
{
    public interface IRegisrationRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(int StudentId);
        void AddStudent(Student student);
        void DeleteStudent(Student student);
        void UpdateStudent(Student studentChange);



        IEnumerable<Course> GetAllCourses();
        Course GetCourse(int CourseId);
        void AddCourse(Course course);
        void DeleteCourse(int Id);
        void UpdateCourse(Course courseChange);


        //Instructor
        IEnumerable<Instructor> GetAllInstructors();
        Instructor GetInstructor(int InstructorId);
        void AddInstructor(Instructor instructor);
        void DeleteInstructor(int Id);
        void UpdateInstructor(Instructor instructorChanges);


        //Registration

        Registration AddNewRegistration(Registration registration);
        void DeleteRegistration(int RegistrationId);
        Registration UpdateRegistration(Registration registrationChanges);

        IEnumerable<Registration> GetRegistrations();

    }
}
