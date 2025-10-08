using Microsoft.AspNetCore.Mvc;
using OMPS.PresentationKatmani.Abstraction;

namespace OMPS.PresentationKatmani.Controller
{
    public sealed class TestController: ApiController
    {
        [HttpGet()]
        public IActionResult Get()
        {
            return Ok("Test başarılı");
        }


    }
}
