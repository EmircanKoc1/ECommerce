using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentCardController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PaymentCardController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
