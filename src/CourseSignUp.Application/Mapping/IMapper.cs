using CourseSignUp.Application.DTOs;
using CourseSignUp.Domain.Entities.Base;
using System.Collections.Generic;

namespace CourseSignUp.Application.Mapping
{
    public interface IMapper
    {
        IEnumerable<BaseDTO> MapToDto(IEnumerable<Entity> entity);
    }
}
