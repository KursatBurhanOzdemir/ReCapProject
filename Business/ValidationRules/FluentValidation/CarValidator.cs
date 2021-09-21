using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(3);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(b => b.Description).Must(StartWithA).WithMessage(Messages.CarNameInvalid);
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
    
}
