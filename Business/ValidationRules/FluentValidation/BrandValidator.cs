using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator: AbstractValidator<CarImage>
    {
        public BrandValidator()
        {

        }
    }
}
