using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.CreateRole
{
    public sealed class CreateRoleValidator : AbstractValidator<CreateRoleCommand>
    {
        public CreateRoleValidator()
        {
            RuleFor(p=>p.Name).NotNull().WithMessage("Role ismi zorunludur");
            RuleFor(p=>p.Name).NotEmpty().WithMessage("Role ismi zorunludur");


            RuleFor(p=>p.Code).NotNull().WithMessage("Code alanı zorunludur");
            RuleFor(p=>p.Code).NotEmpty().WithMessage("Code alanı zorunludur");


        }
    }
}
