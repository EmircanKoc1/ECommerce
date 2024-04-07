using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.User;
using BusinessLogicLayer.CQRS.Commands.Responses.User;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.User
{
    public class DeleteUserCommandHandler : IRequestHandler<DeleteUserCommandRequest, DeleteUserCommandResponse>
    {
        IMapper _mapper;
        IUserService _userService;

        public DeleteUserCommandHandler(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        public Task<DeleteUserCommandResponse> Handle(DeleteUserCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<UserDto>(request);
            var responseDto = _userService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteUserCommandResponse>(request));

        }
    }
}
