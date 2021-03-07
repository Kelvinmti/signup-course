using CourseSignUp.Domain.Entities;
using System.Threading.Tasks;

namespace CourseSignUp.Domain.Repositories
{
    public interface ICourseRepository
    {
        Task<Course> GetCourseById(string courseId);
    }
}
