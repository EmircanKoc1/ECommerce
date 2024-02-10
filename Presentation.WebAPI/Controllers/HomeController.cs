using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IAddressService _addressService;

        public HomeController(IAddressService addressService)
        {
            _addressService = addressService;
        }

        [HttpPost]
        public IActionResult add(AddressDto dto)
        {
            dto = _addressService.Add(dto);

            return Ok(dto);
        }

    }
}
