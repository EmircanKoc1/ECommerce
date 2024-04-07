using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.User;
using BusinessLogicLayer.CQRS.Commands.Responses.User;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.User
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommandRequest, CreateUserCommandResponse>
    {
        IMapper _mapper;
        IValidator<UserDto> _validator;
        IUserService _userService;

        public CreateUserCommandHandler(IMapper mapper, IValidator<UserDto> validator, IUserService userService)
        {
            _mapper = mapper;
            _validator = validator;
            _userService = userService;
        }

        public async Task<CreateUserCommandResponse> Handle(CreateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<UserDto>(request);    
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return null;

            var responseDto =await  _userService.AddAsync(dto);

            return _mapper.Map<CreateUserCommandResponse>(responseDto);

        }
    }
}
