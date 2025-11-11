using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainROleAndUsers.Commands.RemoveMainRoleAndUser
{
    public sealed class RemoveByIdMainRoleAndUserValidator : AbstractValidator<RemoveByIdMainRoleAndUserCommand>
    {
        public RemoveByIdMainRoleAndUserValidator()
        {
            RuleFor(p => p.id).NotEmpty().WithMessage("Id Girilmelidir");
            RuleFor(p => p.id).NotNull().WithMessage("Id Girilmelidir");
        }
    }
}
