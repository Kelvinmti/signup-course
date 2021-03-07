using CourseSignUp.Application.DTOs;
using CourseSignUp.Application.Mapping;
using CourseSignUp.Application.Queries;
using CourseSignUp.Domain.Repositories;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CourseSignUp.Application.Handlers
{
    public class GetAgeAverageByCourseQueryHandler : IRequestHandler<GetAgeAverageByCourseQuery, IEnumerable<CourseAvarageDTO>>
    {

        private readonly IStatisticsRepository _statisticsRepository;
        private readonly IMapper _mapper;

        public GetAgeAverageByCourseQueryHandler(IStatisticsRepository statisticsRepository, IMapper mapper)
        {
            _statisticsRepository = statisticsRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CourseAvarageDTO>> Handle(GetAgeAverageByCourseQuery request, CancellationToken cancellationToken)
        {
            var statisticsList = await _statisticsRepository.GetCourseStatistics();
            
            if (statisticsList == null)
            {
                throw new System.Exception("There is no Statistics generated yet!");// Replace for Notification Pattern
            }

            IEnumerable<CourseAvarageDTO> courseStatistics = (IEnumerable<CourseAvarageDTO>)_mapper.MapToDto(statisticsList);

            return courseStatistics;
        }
    }
}
