using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentCompanyController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShipmentCompanyController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
