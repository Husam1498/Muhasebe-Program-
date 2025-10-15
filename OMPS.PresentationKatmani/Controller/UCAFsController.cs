using MediatR;
using Microsoft.AspNetCore.Mvc;
using OMPS.ApplicationKatmanı.Features.Commands.CompanyFeatures.UCAFFeatures.Commands.CreateUCAF;
using OMPS.PresentationKatmani.Abstraction;


namespace OMPS.PresentationKatmani.Controller
{
    public class UCAFsController : ApiController
    {
        public UCAFsController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost("[Action]")]
        public async Task<IActionResult> CreateUCAF( CreateUCAFCommand request, CancellationToken cancellationToken)
        {
            CreateUCAFCommandResponse response = await _mediator.Send(request, cancellationToken);
            return Ok(response);
        }

    }
}
