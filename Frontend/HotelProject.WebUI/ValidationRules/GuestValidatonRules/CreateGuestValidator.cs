using FluentValidation;
using HotelProject.WebUI.Dtos.GuestDtos;

namespace HotelProject.WebUI.ValidationRules.GuestValidatonRules
{
    public class CreateGuestValidator:AbstractValidator<CreateGuestDto>
    {
        public CreateGuestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("İsim Boş Geçilemez");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Minimum 2 karakter olmalı");

            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soy İsim Boş Geçilemez");
            RuleFor(x => x.Surname).MinimumLength(2).WithMessage("Minimum 2 karakter olmalı");

            RuleFor(x => x.City).NotEmpty().WithMessage("Şehir Boş Geçilemez");
            RuleFor(x => x.City).MinimumLength(2).WithMessage("Minimum 4 karakter olmalı");
        }
    }
}