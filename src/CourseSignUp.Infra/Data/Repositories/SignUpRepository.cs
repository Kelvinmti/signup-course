using CourseSignUp.Domain.Entities;
using CourseSignUp.Domain.Repositories;
using CourseSignUp.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CourseSignUp.Infra.Data.Repositories
{
    public class SignUpRepository : ISignUpRepository
    {
        private readonly ChamaOnlineContext _context;

        public SignUpRepository(ChamaOnlineContext context)
        {
            _context = context;
        }

        public Task SignUpAsync(Course course, Student student)
        {
            return Task.Run(() =>
               {
                   Enrollment enrollment = new Enrollment(course, student);

                   if (enrollment.IsValid)
                   {
                       course.IncrementNumberOfStudents();
                       _context.GetEnrollments().Add(enrollment);
                   }
               });

        }
    }
}
