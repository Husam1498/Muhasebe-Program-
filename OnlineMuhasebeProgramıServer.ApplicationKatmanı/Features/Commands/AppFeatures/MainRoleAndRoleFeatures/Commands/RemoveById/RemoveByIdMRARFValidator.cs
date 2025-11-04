using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands.RemoveById
{
    public sealed class RemoveByIdMRARFValidator : AbstractValidator<RemoveByIdMRARFCommand>
    {
        public RemoveByIdMRARFValidator()
        {
            RuleFor(p => p.id).NotNull().WithMessage("id  bilgisi yazılmalıdır!");
            RuleFor(p => p.id).NotEmpty().WithMessage("id bilgisi yazılmalıdır!");

        }
    }
}
