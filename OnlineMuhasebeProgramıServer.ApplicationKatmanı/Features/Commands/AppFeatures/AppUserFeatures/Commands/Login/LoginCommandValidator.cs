using FluentValidation;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserFeatures.Commands.Login
{
    public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
    {
        public LoginCommandValidator()
        {
            #region EmailorUSername
            RuleFor(c => c.EmailOrUsername)
                .NotEmpty().WithMessage("Email or Username is required.")
                .NotNull().WithMessage("Email or Username is required.");
            #endregion

            #region Password
            RuleFor(c => c.Password)
                .NotEmpty().WithMessage("Password is required.")
                .NotNull().WithMessage("Password is required.")
                .MinimumLength(4).WithMessage("Password en az 4 karakterdeolmalı")
                .Matches("[A-Z]").WithMessage("Password en az bir büyük harf içermelidir.")
                .Matches("[a-z]").WithMessage("Password en az bir küçük harf içermelidir.")
                .Matches("[0-9]").WithMessage("Password en az bir rakam içermelidir.")
                .Matches("[^a-zA-Z0-9]").WithMessage("Password en az bir özel karakter içermelidir.");
            #endregion
        }
    }
}
