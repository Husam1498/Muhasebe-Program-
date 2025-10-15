using MediatR;
using Microsoft.AspNetCore.Mvc;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.CreateCompany;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.CompanyFeatures.Commands.MigrateCompanyDatabase;
using OMPS.PresentationKatmani.Abstraction;

namespace OMPS.PresentationKatmani.Controller
{
    public class CompanyController : ApiController
    {
        public CompanyController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreateCompany(CreateCompayCommand request,CancellationToken cancellationToken)
        { 
            CreateCompanyCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

        [HttpGet("[action]")]
        public async Task<IActionResult> MigrateCompanyDatabases()
        {
            MCDCommand requst = new();
            MCDCommandResponse response = await _mediator.Send(requst);
            return Ok(response);
        }
        

    }
}
