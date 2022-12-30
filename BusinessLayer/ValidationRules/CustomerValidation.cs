using EntityLayer.Concrete;
using FluentValidation;

namespace BusinessLayer.ValidationRules
{
    public class CustomerValidation : AbstractValidator<Customer>
    {
        public CustomerValidation()
        {
            RuleFor(x => x.NameSurname).NotEmpty().WithMessage("Ad Soyad boş olamaz!");

            RuleFor(x => x.Email).NotEmpty().WithMessage("E-Posta boş olamaz!");

            RuleFor(x => x.Address).NotEmpty().WithMessage("Adres boş olamaz!");

            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola boş olamaz!");
            RuleFor(x => x.Password).Length(7, 20).WithMessage("Parola en az 7 en fazla 20 karakter olabilir!");

            RuleFor(x => x.PhoneNumber).NotNull().WithMessage("Telefon Numarası boş olamaz!");
            RuleFor(x => x.PhoneNumber).Length(11, 11).WithMessage("Telefon Numarası en fazla 11 karakter olabilir!");
        }
    }
}
