using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.OrderStatus;
using BusinessLogicLayer.CQRS.Commands.Responses.OrderStatus;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.OrderStatus
{
    public class CreateOrderStatusCommandHandler : IRequestHandler<CreateOrderStatusCommandRequest, CreateOrderStatusCommandResponse>
    {
        IMapper _mapper;
        IOrderStatusService _orderStatusService;
        IValidator<OrderStatusDto> _validator;

        public CreateOrderStatusCommandHandler(IMapper mapper, IOrderStatusService orderStatusService, IValidator<OrderStatusDto> validator)
        {
            _mapper = mapper;
            _orderStatusService = orderStatusService;
            _validator = validator;
        }

        public async Task<CreateOrderStatusCommandResponse> Handle(CreateOrderStatusCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<OrderStatusDto>(request);

            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return null;


            var responseDto = _orderStatusService.AddAsync(dto);

            return _mapper.Map<CreateOrderStatusCommandResponse>(responseDto);

        }
    }
}
