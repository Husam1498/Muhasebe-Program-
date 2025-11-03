using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.MainRoleAndRoleFeatures.Commands;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.AppFeatures.MainRoleAndRoleFeatures
{
    public sealed class CreateMRARFCommandUnitTest
    {
        private readonly Mock<IMainRoleAndRoleRelationshipServices> _services;

        public CreateMRARFCommandUnitTest()
        {
            _services = new();
        }

        [Fact]
        public async Task MainRoleAndRoleShouldBeNull()
        {
            MainRoleAndRoleRelationship mainRoleAndRole = (await _services.Object.GetByRoleIdAndMainRoleId(
                roleId: "7D5472FD-6B6D-4CB6-9A62-6809A324B538",
                mainRoleId: "8E890534-74DF-4C5C-9637-FA02015A1E5A",
                default))!;
            mainRoleAndRole.ShouldBeNull();


        }
        [Fact]
        public async Task CreateMRARResponseShouldNotBeNull()
        {
            var command = new CreateMRARFCommand(
                roleId: "<9D15E7C3-809C-4809-8622-CC1651BD8669",
                mainRoleId: "9D15E7C3-809C-4809-8622-CC1651BD8669"


                );

            var handler = new CreateMRARFHandler(_services.Object);

            CreateMRARFResponse response = await handler.Handle(command, default);

            response.ShouldNotBeNull();//null olmamalı
            response.Message.ShouldNotBeEmpty();// responsun altındaki messge değişkeni boş olmamalı




        }

    }
}
