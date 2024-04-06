using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.OrderStatus;
using BusinessLogicLayer.CQRS.Commands.Responses.OrderStatus;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.OrderStatus
{
    public class UpdateOrderStatusCommandHandler : IRequestHandler<UpdateOrderStatusCommandRequest, (UpdateOrderStatusCommandResponse, UpdateOrderStatusCommandResponse)>
    {
        IMapper _mapper;
        IValidator<OrderStatusDto> _validator;
        IOrderStatusService _orderStatusService;

        public UpdateOrderStatusCommandHandler(IMapper mapper, IValidator<OrderStatusDto> validator, IOrderStatusService orderStatusService)
        {
            _mapper = mapper;
            _validator = validator;
            _orderStatusService = orderStatusService;
        }

        public async Task<(UpdateOrderStatusCommandResponse, UpdateOrderStatusCommandResponse)> Handle(UpdateOrderStatusCommandRequest request, CancellationToken cancellationToken)
        {

            var dto = _mapper.Map<OrderStatusDto>(request);

            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return (null, null);

            var tupleDto = _orderStatusService.Update(dto);

            var old = _mapper.Map<UpdateOrderStatusCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateOrderStatusCommandResponse>(tupleDto.Item2);

            return (old, @new);
        }
    }
}
