using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
