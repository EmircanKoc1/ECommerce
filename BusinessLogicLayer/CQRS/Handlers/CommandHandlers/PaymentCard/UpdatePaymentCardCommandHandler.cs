using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.PaymentCard;
using BusinessLogicLayer.CQRS.Commands.Responses.PaymentCard;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.PaymentCard
{
    public class UpdatePaymentCardCommandHandler : IRequestHandler<UpdatePaymentCardCommandRequest, (UpdatePaymentCardCommandResponse, UpdatePaymentCardCommandResponse)>
    {
        IMapper _mapper;
        IPaymentCardService _paymentCardService;
        IValidator<PaymentCardDto> _validator;

        public UpdatePaymentCardCommandHandler(IMapper mapper, IPaymentCardService paymentCardService, IValidator<PaymentCardDto> validator)
        {
            _mapper = mapper;
            _paymentCardService = paymentCardService;
            _validator = validator;
        }

        public async Task<(UpdatePaymentCardCommandResponse, UpdatePaymentCardCommandResponse)> Handle(UpdatePaymentCardCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<PaymentCardDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return (null, null);

            var tupleDto = _paymentCardService.Update(dto);
            var old = _mapper.Map<UpdatePaymentCardCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdatePaymentCardCommandResponse>(tupleDto.Item2);

            return (old, @new);
        }
    }
}
