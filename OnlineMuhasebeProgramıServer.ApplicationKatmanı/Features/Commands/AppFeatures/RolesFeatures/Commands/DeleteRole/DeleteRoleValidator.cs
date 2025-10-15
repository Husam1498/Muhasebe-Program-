using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.RolesFeatures.Commands.DeleteRole
{
    public sealed class DeleteRoleValidator : AbstractValidator<DeleteroleCommands>
    {
        public DeleteRoleValidator()
        {
            RuleFor(p => p.Id).NotNull().WithMessage("Id alalnı zorunludur");
            RuleFor(p => p.Id).NotEmpty().WithMessage("Id alalnı zorunludur");
    
        }
    }
}
