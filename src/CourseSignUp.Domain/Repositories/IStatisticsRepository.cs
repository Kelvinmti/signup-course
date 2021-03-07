using CourseSignUp.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CourseSignUp.Domain.Repositories
{
    public interface IStatisticsRepository
    {
        Task UpdateStatistics(string courseId);
        Task<IEnumerable<CourseStatistics>> GetCourseStatistics();
    }
}
