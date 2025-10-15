using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany
{
    public sealed class CreateCompanyValidator : AbstractValidator<CreateCompayCommand>
    {
        public CreateCompanyValidator()
        {
            RuleFor(p=> p.DatabaseName).NotNull().WithMessage("Database bilgisi yazılmalıdır!");
            RuleFor(p=> p.DatabaseName).NotEmpty().WithMessage("Database bilgisi yazılmalıdır!");

            RuleFor(p=> p.ServerName).NotNull().WithMessage("Server name bilgisi yazılmalıdır!");
            RuleFor(p=> p.ServerName).NotEmpty().WithMessage("Server name bilgisi yazılmalıdır!");

            RuleFor(p=> p.Name).NotNull().WithMessage("Şirket adı bilgisi yazılmalıdır!");
            RuleFor(p=> p.Name).NotEmpty().WithMessage("Şirket adı bilgisi yazılmalıdır!");

        }
    }
}
