using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Address;
using BusinessLogicLayer.CQRS.Commands.Responses.Address;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Model;
using DataAccessLayer.Repositories.Abstracts;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IAddressService _addressService;
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly IHashService _hashService;
        private readonly ITokenService _tokenService;
        private readonly IMediator _mediator;

        public HomeController(IAddressService addressService, IUserRepository userRepository, IMapper mapper, IHashService hashService, ITokenService tokenService, IMediator mediator)
        {
            _addressService = addressService;
            _userRepository = userRepository;
            _mapper = mapper;
            _hashService = hashService;
            _tokenService = tokenService;
            _mediator = mediator;
        }

        [HttpPost]
        [Route("/address")]
        public IActionResult add(AddressDto dto)
        {
            dto = _addressService.Add(dto);

            return Ok(dto);
        }

        [HttpPost]
        [Route("/modelcheck")]
        public IActionResult Get(PaginationModel model) => Ok(model);


        [HttpPost]
        [Route("/user")]
        public IActionResult add(UserDto dto)
        {
            var entity = _mapper.Map<DataAccessLayer.Entities.User>(dto);
            _userRepository.Add(entity);
            _userRepository.SaveChanges();
            return Ok(entity);
        }

        [HttpPost]
        [Route("/hash")]
        public IActionResult hash(string x)
        {

            var model = _tokenService.GenerateTokenModel(new UserDto());
            return Ok(model);
        }

        [HttpPost]
        [Route("/mediatr")]
        public IActionResult MediatR(CreateAddressCommandRequest param)
            => Ok(_mediator.Send<CreateAddressCommandResponse>(param));
    }
}
