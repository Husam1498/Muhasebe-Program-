using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserAndCompanyFeatures.Commands.CreateAppUserAndComapny;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.AppUserAndCompanyFeaturess
{
    public sealed class CreateAppUserAndCompanyUnitTest
    {
        private readonly Mock<IAppUserAndCompanyServices> _services;

        public CreateAppUserAndCompanyUnitTest()
        {
            _services = new();
        }

        [Fact]
        public async Task AppUserAndCompanyShouldBeNull()
        {
            AppUserAndCompany appUserAndCompany = (await _services.Object.GetByUserIdAndCompanyId(
                userId: "7D5472FD-6B6D-4CB6-9A62-6809A324B538",
                companyId: "8E890534-74DF-4C5C-9637-FA02015A1E5A",
                default))!;
            appUserAndCompany.ShouldBeNull();
        }

        [Fact]
        public async Task AppUserAndCompanyResponseShouldNotBeNull()
        {
            var command = new CreateAppUserAndComapnyCommand(
                userId: "9D15E7C3-809C-4809-8622-CC1651BD8669",
                companyId: "9D15E7C3-809C-4809-8622-CC1651BD8669"
                );

            var handler = new CreateAppUserAndComapnyHandler(_services.Object);

            CreateAppUserAndComapnyResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();//null olmamalı
            response.Message.ShouldNotBeEmpty();// responsun altındaki messge değişkeni boş olmamalı
        }
    }
}
