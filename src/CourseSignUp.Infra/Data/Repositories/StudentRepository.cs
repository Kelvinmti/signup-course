using CourseSignUp.Domain.Entities;
using CourseSignUp.Domain.Repositories;
using CourseSignUp.Infra.Data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Infra.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ChamaOnlineContext _context;

        public StudentRepository(ChamaOnlineContext context)
        {
            _context = context;
        }

        public Task<Student> GetStudentByEmail(string email)
        {
            return Task.Run(() => _context.GetStudents().FirstOrDefault(c => c.Email.ToString() == email));
        }

        public Task Create(Student student)
        {
            return Task.Run(() => _context.GetStudents().Add(student));
        }
    }
}
