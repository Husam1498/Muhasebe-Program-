using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserAndCompanyFeatures.Commands.RemoveById
{
    public sealed class RemoveByIdAppUserAndComapnyValidator : AbstractValidator<RemoveByIdAppUserAndComapnyCommand>
    {
        public RemoveByIdAppUserAndComapnyValidator()
        {
            RuleFor(p => p.id).NotNull().WithMessage("id bilgisi yazılmalıdır!");
            RuleFor(p => p.id).NotEmpty().WithMessage("id bilgisi yazılmalıdır!");
        }
    }
}
