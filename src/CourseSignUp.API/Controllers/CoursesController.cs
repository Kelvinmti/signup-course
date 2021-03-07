using CourseSignUp.Application.DTOs;
using CourseSignUp.Application.Events;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CourseSignUp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoursesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost, Route("sign-up")]
        public async Task<IActionResult> Post([FromBody] SignUpToCourseDTO signUpToCourseDto)
        {
            //Replace this call to a real message broker
            await _mediator.Publish(new SignUpToCourseEvent { SignUpToCourseDTO = signUpToCourseDto });
            return Ok(new { message = "Sign up is going to a process queue! Soner! You will receive an email with the result of processing soon!" });
        }
    }
}
