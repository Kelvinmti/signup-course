using CourseSignUp.Domain.Validators;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseSignUp.Domain.ValueObjects
{
    public struct Email
    {
        private readonly string _value;

        private Email(string value)
        {
            _value = value;
            ValidationResult = new EmailValidator().Validate(value);
            Valid = ValidationResult.IsValid;
        }

        public override string ToString() => _value;

        public static implicit operator Email(string value) => new Email(value);

        public bool Valid { get; private set; }
        public ValidationResult ValidationResult { get; private set; }

    }
}
