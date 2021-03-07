using CourseSignUp.Domain.Entities;
using System.Threading.Tasks;

namespace CourseSignUp.Domain.Repositories
{
    public interface ISignUpRepository
    {
        Task SignUpAsync(Course course, Student student);
    }
}
