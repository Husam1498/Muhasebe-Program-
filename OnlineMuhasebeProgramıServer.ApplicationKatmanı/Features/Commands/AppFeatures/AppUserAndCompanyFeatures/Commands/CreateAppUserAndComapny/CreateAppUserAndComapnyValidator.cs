using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserAndCompanyFeatures.Commands.CreateAppUserAndComapny
{
    public sealed class CreateAppUserAndComapnyValidator : AbstractValidator<CreateAppUserAndComapnyCommand>
    {
        public CreateAppUserAndComapnyValidator()
        {
            RuleFor(p => p.userId).NotNull().WithMessage("user Id bilgisi yazılmalıdır!");
            RuleFor(p => p.userId).NotEmpty().WithMessage("User Id bilgisi yazılmalıdır!");

            RuleFor(p => p.companyId).NotNull().WithMessage("Şirket Id bilgisi yazılmalıdır!");
            RuleFor(p => p.companyId).NotEmpty().WithMessage("Şirket Id bilgisi yazılmalıdır!");

        }
    }
}
