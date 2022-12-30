using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı boş olamaz!");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Kategori adı en fazla 20 karakter olabilir!");

            RuleFor(x => x.RestaurantId).NotEmpty().WithMessage("Restoran boş olamaz!");
        }
    }
}
