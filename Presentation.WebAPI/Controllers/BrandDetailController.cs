using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandDetailController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BrandDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
