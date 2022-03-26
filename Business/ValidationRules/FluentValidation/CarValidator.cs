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
            RuleFor(c=>c.CarId).NotEmpty();
            RuleFor(c => c.Description).MinimumLength(2);
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ModelYear).LessThan(DateTime.Now.Year);
            RuleFor(c => c.ModelYear).GreaterThan((DateTime.Now.Year)-25);
        }
       
    }
}
