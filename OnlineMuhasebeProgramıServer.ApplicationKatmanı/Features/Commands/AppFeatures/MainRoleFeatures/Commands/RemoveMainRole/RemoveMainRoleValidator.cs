using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.RemoveMainRole
{
    public sealed class RemoveMainRoleValidator : AbstractValidator<RemoveMainRoleCommand>
    {
        public RemoveMainRoleValidator()
        {
            RuleFor(p => p.Id).NotEmpty().WithMessage("Id girilmelidir! ");
            RuleFor(p => p.Id).NotNull().WithMessage("Id girilmelidir!");
        }
    }
}
