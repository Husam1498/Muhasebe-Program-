using Azure.Core;
using Moq;
using OMPS.ApplicationKatmanı.Features.Commands.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OMPS.ApplicationKatmanı.Services.AppServices;
using OMPS.ApplicationKatmanı.Services.CompanyServices;
using OMPS.DomainKatmani.CompanyEnties;
using Shouldly;

namespace OMP.UnitTest.Features.Commands.CompanyFeatrues.UCAFFeatures.Commands
{
    public sealed class CreateUCAFUnitTest
    {
        private readonly Mock<IUCAFServis> _ucafService;

        public CreateUCAFUnitTest()
        {
            _ucafService = new();
        }

        [Fact]
        public async Task UCAFShoulBeNull()
        {
            #region Kod Kısmı
            /*
            UCAF ucaf = await _ucafService.GetByCode(request.Code);
            if (ucaf != null) throw new Exception("Bu hesap planı Kodu daha önce açılmış");
            */
            #endregion

            UCAF ucaf = await _ucafService.Object.GetByCode("100.01.001");
            ucaf.ShouldBeNull();

        }

        [Fact]
        public async Task CreateUCAFCommandResponseNotBeNull()
        {
            #region Kod Kısmı
            /*
                await _ucafService.CreateUCAFAsync(request, cancellationToken);
            */
            #endregion

            var command = new CreateUCAFCommand(
                Code:"100.01.001",
                Name:"TestKasa",
               Type:'D',
                CompanyId: "438cc12d-b618-440b-a493-0b2d2cee91ce"
                );
            var handler = new CreateUCAFCommandHandler(_ucafService.Object);

            CreateUCAFCommandResponse response = await handler.Handle(command, default);
            response.ShouldNotBeNull();
            response.Message.ShouldNotBeEmpty();

        }

    }
}
