using CourseSignUp.Domain.Entities;
using System.Threading.Tasks;

namespace CourseSignUp.Domain.Repositories
{
    public interface IStudentRepository
    {
        Task<Student> GetStudentByEmail(string email);
        Task Create(Student student);
    }
}
