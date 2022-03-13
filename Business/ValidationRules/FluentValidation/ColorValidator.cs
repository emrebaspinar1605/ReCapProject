using Entity.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<CarImage>
    {
        public ColorValidator()
        {

        }
    }
}
