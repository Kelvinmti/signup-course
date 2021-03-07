using CourseSignUp.Application.DTOs;
using MediatR;
using System.Collections.Generic;

namespace CourseSignUp.Application.Queries
{
    public class GetAgeAverageByCourseQuery : IRequest<IEnumerable<CourseAvarageDTO>>
    {
    }
}
