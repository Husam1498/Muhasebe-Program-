using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands.Create
{
    public sealed class CreateMRARFCommandValidator :
        AbstractValidator<CreateMRARFCommand>
    {
        public CreateMRARFCommandValidator()
        {
            RuleFor(p => p.roleId).NotEmpty().WithMessage("Role Id Seçilmelidir");
            RuleFor(p => p.roleId).NotNull().WithMessage("Role Id Seçilmelidir");


            RuleFor(p => p.mainRoleId).NotEmpty().WithMessage("MainRole Id Seçilmelidir");
            RuleFor(p => p.mainRoleId).NotNull().WithMessage("MainRole Id Seçilmelidir");
        }
    }
}
