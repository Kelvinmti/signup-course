using CourseSignUp.Application.DTOs;
using MediatR;

namespace CourseSignUp.Application.Events
{
    public class SignUpToCourseEvent : INotification
    {
        public SignUpToCourseDTO SignUpToCourseDTO { get; set; }
    }
}
