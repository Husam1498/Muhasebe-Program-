using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainROleAndUsers.Commands.CreateMainRoleAndUser
{
    public sealed class CreateMainRoleAndUserValidator : AbstractValidator<CreateMainRoleAndUserCommand>
    {
        public CreateMainRoleAndUserValidator()
        {
            RuleFor(p => p.userId).NotEmpty().WithMessage("User Id Girilmelidir");
            RuleFor(p => p.userId).NotNull().WithMessage("User Id Girilmelidir");

            RuleFor(p => p.companyId).NotEmpty().WithMessage("Company  Id Girilmelidir");
            RuleFor(p => p.companyId).NotNull().WithMessage("Company Id Girilmelidir");

            RuleFor(p => p.mainRoleId).NotEmpty().WithMessage("MainRole Id Girilmelidir");
            RuleFor(p => p.mainRoleId).NotNull().WithMessage("MainRole Id Girilmelidir");
        }
    }
}
