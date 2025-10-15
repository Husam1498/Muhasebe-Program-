using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.UpdateRole
{
    public sealed class UpdateRoleValidator : AbstractValidator<UpdateRoleCommand>
    {
        public UpdateRoleValidator()
        {
            RuleFor(p=> p.Id).NotNull().WithMessage("Id Alanı  Zorunludur");
            RuleFor(p=> p.Id).NotEmpty().WithMessage("Id Alanı  Zorunludur");

            RuleFor(p => p.Name).NotNull().WithMessage("Role ismi zorunludur");
            RuleFor(p => p.Name).NotEmpty().WithMessage("Role ismi zorunludur");

            RuleFor(p => p.Code).NotNull().WithMessage("Code alanı zorunludur");
            RuleFor(p => p.Code).NotEmpty().WithMessage("Code alanı zorunludur");
        }
    }
}
