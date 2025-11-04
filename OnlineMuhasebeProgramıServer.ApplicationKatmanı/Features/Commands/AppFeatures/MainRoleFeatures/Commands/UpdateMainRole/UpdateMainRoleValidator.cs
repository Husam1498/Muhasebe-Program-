using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleFeatures.Commands.UpdateMainRole
{
    public sealed class UpdateMainRoleValidator : AbstractValidator<UpdateMainRoleCommand>
    {
        public UpdateMainRoleValidator()
        {
            RuleFor(p => p.id).NotEmpty().WithMessage("Id girilmelidir! ");
            RuleFor(p => p.id).NotNull().WithMessage("Id girilmelidir!");

            RuleFor(p => p.title).NotEmpty().WithMessage("Title alanı girilmelidir! ");
            RuleFor(p => p.title).NotNull().WithMessage("Title alanı girilmelidir!");

        }
    }
}
