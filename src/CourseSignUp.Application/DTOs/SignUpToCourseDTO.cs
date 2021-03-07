using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Application.DTOs
{
    public class SignUpToCourseDTO : BaseDTO
    {
        public string CourseId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
