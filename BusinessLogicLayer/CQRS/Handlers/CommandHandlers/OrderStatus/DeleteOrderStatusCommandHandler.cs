using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.OrderStatus;
using BusinessLogicLayer.CQRS.Commands.Responses.OrderStatus;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.OrderStatus
{
    public class DeleteOrderStatusCommandHandler : IRequestHandler<DeleteOrderStatusCommandRequest, DeleteOrderStatusCommandResponse>
    {
        IMapper _mapper;
        IOrderStatusService _orderStatusService;

        public DeleteOrderStatusCommandHandler(IMapper mapper, IOrderStatusService orderStatusService)
        {
            _mapper = mapper;
            _orderStatusService = orderStatusService;
        }

        public Task<DeleteOrderStatusCommandResponse> Handle(DeleteOrderStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<OrderStatusDto>(request);

            var responseDto = _orderStatusService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteOrderStatusCommandResponse>(responseDto));

        }
    }
}
