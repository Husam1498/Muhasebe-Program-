

using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.CreateMainRole
{
    public sealed class CreateMainRoleValidator : AbstractValidator<CreateMainRoleCommand>
    {
        public CreateMainRoleValidator()
        {
            RuleFor(p => p.Title).NotEmpty().WithMessage("Title girilmelidir! ");
            RuleFor(p => p.Title).NotNull().WithMessage("Title girilmelidir!");
        }
    }
}
