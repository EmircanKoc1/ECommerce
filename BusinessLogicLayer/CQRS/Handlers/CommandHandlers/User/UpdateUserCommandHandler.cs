using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.User;
using BusinessLogicLayer.CQRS.Commands.Responses.User;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.User
{
    public class UpdateUserCommandHandler : IRequestHandler<UpdateUserCommandRequest, (UpdateUserCommandResponse, UpdateUserCommandResponse)>
    {
        IMapper _mapper;
        IUserService _userService;
        IValidator<UserDto> _validator;

        public UpdateUserCommandHandler(IMapper mapper, IUserService userService, IValidator<UserDto> validator)
        {
            _mapper = mapper;
            _userService = userService;
            _validator = validator;
        }

        public async Task<(UpdateUserCommandResponse, UpdateUserCommandResponse)> Handle(UpdateUserCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<UserDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return (null, null);

            var tupleDto = _userService.Update(dto);
            var old = _mapper.Map<UpdateUserCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateUserCommandResponse>(tupleDto.Item2);

            return (old, @new);

        }
    }
}
