using CourseSignUp.Domain.ValueObjects;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.Validators
{
    public class EmailValidator : AbstractValidator<Email>
    {
        public EmailValidator()
        {
            RuleFor(e => e.ToString())
                .NotEmpty()
                .EmailAddress()
                .WithMessage("Invalid email");
        }
    }
}
