using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF
{
    public sealed class CreateUCAFValidator : AbstractValidator<CreateUCAFCommand>
    {
        public CreateUCAFValidator()
        {
            RuleFor(p => p.CompanyId).NotNull().WithMessage("Şirket Idsi boş olamaz");
            RuleFor(p => p.CompanyId).NotEmpty().WithMessage("Şirket Idsi boş olamaz");


            RuleFor(p => p.Type).NotNull().WithMessage("Hesap planı tipi boş olamaz");
            RuleFor(p => p.Type).NotEmpty().WithMessage("Hesap planı tipi boş olamaz");
            RuleFor(p => p.Code).MaximumLength(1).WithMessage("Hesap Planı tipi 1 karakter olmalıdır");



            RuleFor(p => p.Name).NotNull().WithMessage("UCAF ismi zorunludur");
            RuleFor(p => p.Name).NotEmpty().WithMessage("UCAF ismi zorunludur");


            RuleFor(p => p.Code).NotNull().WithMessage("Hesap Planı Kodu Zorunludur");
            RuleFor(p => p.Code).NotEmpty().WithMessage("Hesap Planı Kodu Zorunludur");
           // RuleFor(p => p.Code).MinimumLength(5).WithMessage("Hesap Planı Kodu en az 5 karakterli olmalıdırZorunludur");


        }
    }
}
