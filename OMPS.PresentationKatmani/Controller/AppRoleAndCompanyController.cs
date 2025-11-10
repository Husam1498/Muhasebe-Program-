using MediatR;
using Microsoft.AspNetCore.Mvc;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserAndCompanyFeatures.Commands.CreateAppUserAndComapny;
using OMPS.ApplicationKatmanı.Features.Commands.AppFeatures.AppUserAndCompanyFeatures.Commands.RemoveById;
using OMPS.PresentationKatmani.Abstraction;

namespace OMPS.PresentationKatmani.Controller
{
    public sealed class AppRoleAndCompanyController : ApiController
    {
        public AppRoleAndCompanyController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> Create(CreateAppUserAndComapnyCommand command, CancellationToken cancellationToken)
        {
            CreateAppUserAndComapnyResponse response = await _mediator.Send(command);

            return Ok(response);
        }
        [HttpDelete("[action]")]
        public async Task<IActionResult> RemoveById(RemoveByIdAppUserAndComapnyCommand command, CancellationToken cancellationToken)
        {
            RemoveByIdAppUserAndComapnyResponse response = await _mediator.Send(command);

            return Ok(response);
        }
    }
}
