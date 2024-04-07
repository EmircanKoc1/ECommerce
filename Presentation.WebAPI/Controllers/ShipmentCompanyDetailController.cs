using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentCompanyDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ShipmentCompanyDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }

}
