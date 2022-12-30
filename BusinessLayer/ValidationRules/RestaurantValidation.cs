using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class RestaurantValidation : AbstractValidator<Restaurant>
    {
        public RestaurantValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Restoran adı boş olamaz!");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Restoran adı en fazla 30 karakter olabilir!");

            RuleFor(x => x.Address).NotEmpty().WithMessage("Restoran adresi boş olamaz!");
        }
    }
}
