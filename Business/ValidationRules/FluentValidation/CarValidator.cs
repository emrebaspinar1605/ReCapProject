using Business.Constant;
using Entity.Concrete;
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
            //predicate
            //fluent = akıcı kod dizesi
            RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ModelYear ).LessThanOrEqualTo(2001).When(c=> c.BrandId == 3);
            RuleFor(c => c.Description).Must(StartWithA).WithMessage(Messages.StartA);

        }
        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
       
    }
}
