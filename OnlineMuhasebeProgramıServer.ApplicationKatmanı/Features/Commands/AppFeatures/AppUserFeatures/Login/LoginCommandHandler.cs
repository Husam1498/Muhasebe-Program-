using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OMPS.ApplicationKatmanı.Abstract;
using OMPS.ApplicationKatmanı.Messaging;
using OMPS.DomainKatmani.AppEntities.Identity;

namespace OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserFeatures.Login
{
    public sealed class LoginCommandHandler :ICommandHandler<LoginCommand, LoginCommandResponse>
    {
        private readonly IJwtProvider _jwtProvider;
        private readonly UserManager<AppUser> _userManager;
        public LoginCommandHandler(IJwtProvider jwtProvider, UserManager<AppUser> userManager)
        {
            _jwtProvider = jwtProvider;
            _userManager = userManager;
        }
        public async Task<LoginCommandResponse> Handle(LoginCommand request, CancellationToken cancellationToken)
        {
           AppUser user= await _userManager.Users.Where(u => 
           u.Email== request.EmailOrUsername ||
           u.UserName==request.EmailOrUsername).FirstOrDefaultAsync();

            if (user==null) throw new Exception("Kullanıcı bulunamdı");

            var checkUser= await _userManager.CheckPasswordAsync(user, request.Password);
            if (!checkUser) throw new Exception("Şifreniz hatalı");

            LoginCommandResponse response = new(
                user.Email,
                user.NameSurname,
                user.Id,
               await _jwtProvider.CreateTokenAsync(user, null));
            
           

            return response; 

        }
    }
}
