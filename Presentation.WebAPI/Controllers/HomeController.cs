using AutoMapper;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using DataAccessLayer.Repositories.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IAddressService _addressService;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public HomeController(IAddressService addressService, IUserRepository userRepository, IMapper mapper)
        {
            _addressService = addressService;
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("/address")]
        public IActionResult add(AddressDto dto)
        {
            dto = _addressService.Add(dto);

            return Ok(dto);
        }

        [HttpPost]
        [Route("/user")]
        public IActionResult add(UserDto dto)
        {
            var entity = _mapper.Map<DataAccessLayer.Entities.User>(dto);
            _userRepository.Add(entity);
            _userRepository.SaveChanges();
            return Ok(entity);
        }

    }
}
