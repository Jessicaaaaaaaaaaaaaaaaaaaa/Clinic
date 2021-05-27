using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalCourseRegistrationMVC.Models
{
    public class SqlRepository : IRegistration
    {
        private readonly AppDbContext context;

        public SqlRepository(AppDbContext context)  
        {
            this.context = context;
        }

        // CRUD Create *******************************************************
        public Courses AddCourse(Courses course)

        {
            if (course == null)
                throw new ArgumentNullException(nameof(course));
            Courses newCourse = new Courses();

            newCourse.CourseId = course.CourseId;
            newCourse.CourseNumber = course.CourseNumber;
            newCourse.CourseName = course.CourseName;
            newCourse.Description = course.Description;

            context.Courses.Add(newCourse);
            context.SaveChanges();
            return newCourse;
        }

        public Instructors AddInstructor(Instructors instructor)
        {
            if (instructor == null)
                throw new ArgumentNullException(nameof(instructor));
            Instructors newInstructor = new Instructors();

            newInstructor.InstructorId = instructor.InstructorId;
            newInstructor.FirstName = instructor.FirstName;
            newInstructor.LastName = instructor.LastName;
            newInstructor.Email = instructor.Email;
            newInstructor.Course = instructor.Course;

            context.Instructors.Add(newInstructor);
            context.SaveChanges();
            return newInstructor;
        }

        public Registration AddRegistration(Registration registration)  
        {
            if (registration == null)
                throw new ArgumentNullException(nameof(registration));
            Registration newRegistration = new Registration();

            newRegistration.RegistrationId = registration.RegistrationId;
            newRegistration.Type = registration.Type;
            newRegistration.StudentId = registration.StudentId;
            newRegistration.CourseId = registration.CourseId;
            newRegistration.InstructorId = registration.InstructorId;

            context.Registration.Add(newRegistration);
            context.SaveChanges();
            return newRegistration;
        }

        public Students AddStudent(Students student)
        {
            if (student == null)
                throw new ArgumentNullException(nameof(student));
            Students newStudent = new Students();

            newStudent.StudentId = student.StudentId;
            newStudent.FirstName = student.FirstName;
            newStudent.LastName = student.LastName;
            newStudent.Email = student.Email;
            newStudent.Phone = student.Phone;

            context.Students.Add(newStudent);
            context.SaveChanges();
            return newStudent;
        }

        // CRUD Read singular *******************************************************
        public Courses GetCourse(int CourseId)
        {
            return context.Courses.Find(CourseId);
        }

        public Instructors GetInstructor(int InstructorId)
        {
            return context.Instructors.Find(InstructorId);
        }

        public Registration GetRegistrations(int RegistrationId)
        {
            return context.Registration.Find(RegistrationId);
        }

        public Students GetStudent(int StudentId)
        {
            return context.Students.Find(StudentId);
        }

        public IEnumerable<Students> GetStudentId(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Students> StudentList(int Id)
        {
            throw new NotImplementedException();
        }

        // CRUD Read Plural *******************************************************
        public IEnumerable<Courses> GetAllCourse()
        {
            return context.Courses.ToList();
        }

        public IEnumerable<Instructors> GetAllInstructors()
        {
            return context.Instructors.ToList();
        }

        public IEnumerable<Registration> GetAllRegistrations()
        {
            return context.Registration.ToList();
        }

        public IEnumerable<Students> GetAllStudents()
        {
            return context.Students.ToList();
        }

        // CRUD Update *******************************************************
        public void UpdateCourse(Courses courseChange)
        {
            var updatecourse = context.Courses.Attach(courseChange);
            updatecourse.State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            context.SaveChanges();
        }

        public void UpdateInstructor(Instructors instructorChanges)
        {
            throw new NotImplementedException();
        }

        public Registration UpdateRegistration(Registration registrationChanges)
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Students studentChange)
        {
            throw new NotImplementedException();
        }

        // CRUD Delete *******************************************************
        public void DeleteCourse(int Id)
        {
            if (Id == 0)
                throw new ArgumentNullException(nameof(Id));

            Courses ob = context.Courses.Find(Id);
            context.Courses.Remove(ob);
            context.SaveChanges();
        }

        public void DeleteInstructor(int Id)
        { 
            
            if (Id == 0)
                throw new ArgumentNullException(nameof(Id));

            Instructors ob = context.Instructors.Find(Id);
            context.Instructors.Remove(ob);
            context.SaveChanges();
        }

        public void DeleteRegistration(int Id)
        {
            if (Id== 0)
                throw new ArgumentNullException(nameof(Id));
                Registration ob = context.Registration.Find(Id); 
            context.Registration.Remove(ob);             
            context.SaveChanges();
        }

        public void DeleteStudent(int Id)
        {
            if (Id == 0)
                throw new ArgumentNullException(nameof(Id));

            Students ob = context.Students.Find(Id);
            context.Students.Remove(ob);
            context.SaveChanges();
        }

        public void AddNewRegistration(Registration registration)
        {
            throw new NotImplementedException();
        }

        void IRegistration.AddRegistration(Registration registration)
        {
            throw new NotImplementedException();
        }
    }
}

       