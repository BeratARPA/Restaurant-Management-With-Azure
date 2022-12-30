using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class ProductValidation : AbstractValidator<Product>
    {
        public ProductValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı boş olamaz!");
            RuleFor(x => x.Name).MaximumLength(20).WithMessage("Ürün adı en fazla 20 karakter olabilir!");

            RuleFor(x => x.Description).NotEmpty().WithMessage("Ürün açıklaması boş olamaz!");
            RuleFor(x => x.Description).MaximumLength(100).WithMessage("Ürün açıklaması en fazla 100 karakter olabilir!");

            RuleFor(x => x.Price).NotEmpty().WithMessage("Ürün fiyatı boş olamaz!");

            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Ürün kategorisi boş olamaz!");

            RuleFor(x => x.RestaurantId).NotEmpty().WithMessage("Restoran boş olamaz!");
        }
    }
}
