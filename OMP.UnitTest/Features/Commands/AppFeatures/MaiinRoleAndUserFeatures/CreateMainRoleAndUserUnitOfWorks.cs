using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainROleAndUsers.Commands.CreateMainRoleAndUser;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.MaiinRoleAndUserFeatures
{
    public sealed class CreateMainRoleAndUserUnitOfWorks
    {
        private readonly Mock<IMainRoleAndUserServices> _services;

        public CreateMainRoleAndUserUnitOfWorks()
        {
            _services = new();
        }

        [Fact]
        public async Task MainRoleAndUserShouldBeNull()
        {
            MainRoleAndUserRelationship mainRoleAndUser = (await _services.Object.GetByUserIdCompanyIdAndRoleIdAsync(
                "C258488E-D7BC-4B4A-A3C1-9F504F6B8D33",
                "4A30BA36-AA9C-4158-9139-7A453944EA94",
                "FA875EC9-F0AD-4A0D-80D9-A7D05CC92218",
                default
                ));

            mainRoleAndUser.ShouldBeNull();
        }
        [Fact]
        public async Task CreateMainRoleAndUserResponseShouldNotBeNull()
        {
            var command = new CreateMainRoleAndUserCommand(
                userId: "C258488E-D7BC-4B4A-A3C1-9F504F6B8D33",
                companyId: "4A30BA36-AA9C-4158-9139-7A453944EA94",
                mainRoleId: "FA875EC9-F0AD-4A0D-80D9-A7D05CC92218"
                );

            var handler = new CreateMainRoleAndUserHandler(_services.Object);
            CreateMainRoleAndUserResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();//null olmamalı
            response.Message.ShouldNotBeEmpty();// responsun altındaki messge değişkeni boş olmamalı

        }

    }
}
