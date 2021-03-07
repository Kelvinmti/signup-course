using CourseSignUp.Domain.Entities;
using CourseSignUp.Domain.Entities.Base;
using System;

namespace CourseSignUp.Domain.Entities
{
    public class Enrollment : Entity
    {
        public Course Course { get; }
        public Student Student { get; }
        public DateTime CreatedAt { get; set; }

        public Enrollment(Course course, Student student)
        {
            Course = course;
            Student = student;
            CreatedAt = DateTime.UtcNow;
        }
    }
}
