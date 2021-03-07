using CourseSignUp.Domain.Entities;
using CourseSignUp.Domain.Repositories;
using CourseSignUp.Infra.Data.Context;
using System.Linq;
using System.Threading.Tasks;

namespace CourseSignUp.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly ChamaOnlineContext _context;

        public CourseRepository(ChamaOnlineContext context)
        {
            _context = context;
        }

        public Task<Course> GetCourseById(string courseId)
        {
            return Task.Run(() => _context.GetCourses().FirstOrDefault(c => c.Id == courseId));
        }
    }
}
