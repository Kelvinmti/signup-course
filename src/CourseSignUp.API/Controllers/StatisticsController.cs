using System.Threading.Tasks;
using CourseSignUp.Application.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CourseSignUp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]    
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }        

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            //Replace this call to a real message broker
            var statistics = await _mediator.Send(new GetAgeAverageByCourseQuery());
            return Ok(statistics);
        }        
    }
}