using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserAndCompanyFeatures.Commands.RemoveById;
using OMPS.ApplicationKatmanı.Services.AppServices;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.AppUserAndCompanyFeaturess
{
    public class RemoveByIdAppUserAndComapnyUnitTest
    {
        private readonly Mock<IAppUserAndCompanyServices> _services;

        public RemoveByIdAppUserAndComapnyUnitTest()
        {
            _services = new();
        }


        [Fact]
        public async Task AppUserAndCompanyResponseShouldNotBeNull()
        {
            var command = new RemoveByIdAppUserAndComapnyCommand(
                id: "9D15E7C3-809C-4809-8622-CC1651BD8669"             
                );

            var handler = new RemoveByIdAppUserAndComapnyHandler(_services.Object);

            RemoveByIdAppUserAndComapnyResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();//null olmamalı
            response.Message.ShouldNotBeEmpty();// responsun altındaki messge değişkeni boş olmamalı
        }
    }
}
