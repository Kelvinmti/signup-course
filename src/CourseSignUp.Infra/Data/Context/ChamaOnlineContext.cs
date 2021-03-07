using CourseSignUp.Domain.Entities;
using System.Collections.Generic;

namespace CourseSignUp.Infra.Data.Context
{
    public class ChamaOnlineContext
    {
        public static List<Enrollment> Enrollments { get; set; }
        public static List<Course> Courses { get; set; }
        public static List<Student> Students { get; set; }
        public static List<Lecturer> Lecturers { get; set; }


        public ChamaOnlineContext()
        {
            Enrollments = new List<Enrollment>();
            
            Lecturer lecturer = new Lecturer("Math Damon");
            Lecturers = new List<Lecturer>()
            {
                lecturer
            };

            Courses = new List<Course>()
            {
                new Course(10, lecturer)
            };

            Students = new List<Student>();            
        }

        public List<Enrollment> GetEnrollments()
        {
            return Enrollments;
        }

        public List<Course> GetCourses()
        {
            return Courses;
        }

        public List<Student> GetStudents()
        {
            return Students;
        }
    }
}
