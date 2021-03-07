using CourseSignUp.Application.DTOs;
using MediatR;

namespace CourseSignUp.Application.Events
{
    public class ResponseEmailEvent : INotification
    {
        public SignUpToCourseDTO SignUpToCourseDTO { get; set; }
        public string Message { get; set; }
    }
}
