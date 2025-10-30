using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.DomainKatmani.AppEntities;
using Shouldly;
using System.ComponentModel.DataAnnotations;

namespace OMP.UnitTest.Features.Commands.AppFeatures.CompanyFeatures
{
    public class CreateCompanyUnitTest
    {
        private readonly Mock<ICompanyServices> _companyServices;

        public CreateCompanyUnitTest()
        {
            _companyServices = new();
        }

        [Fact]
        public async Task CompanyShouldBeNull()
        {
            Company company = (await _companyServices.Object.GetCompanyByName("Test String",default))!;
            company.ShouldBeNull();
            
            
        }
        [Fact]
        public async Task CreateCompanyResponseShouldNotBeNull()
        {
            var command = new CreateCompayCommand(
                Name:"Test",
                ServerName:"TestServername",
                DatabaseName:"TestDatabaseName",
                UserId:"TestId",
                Password: "TestPassword");

            var handler = new CreateCompanyCommandHandler(_companyServices.Object);

            CreateCompanyCommandResponse response = await handler.Handle(command,default);

            response.ShouldNotBeNull();//null olmamalı
            response.Message.ShouldNotBeEmpty();// responsun altındaki messge değişkeni boş olmamalı




        }

    }
}
