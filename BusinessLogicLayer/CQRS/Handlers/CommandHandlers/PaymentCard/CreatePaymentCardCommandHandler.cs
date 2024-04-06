using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.PaymentCard;
using BusinessLogicLayer.CQRS.Commands.Responses.PaymentCard;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.PaymentCard
{
    public class CreatePaymentCardCommandHandler : IRequestHandler<CreatePaymentCardCommandRequest, CreatePaymentCardCommandResponse>
    {
        IMapper _mapper;
        IValidator<PaymentCardDto> _validator;
        IPaymentCardService _paymentCardService;

        public CreatePaymentCardCommandHandler(IMapper mapper, IValidator<PaymentCardDto> validator, IPaymentCardService paymentCardService)
        {
            _mapper = mapper;
            _validator = validator;
            _paymentCardService = paymentCardService;
        }

        public async Task<CreatePaymentCardCommandResponse> Handle(CreatePaymentCardCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<PaymentCardDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return null;

            var responseDto = await _paymentCardService.AddAsync(dto);

            return _mapper.Map<CreatePaymentCardCommandResponse>(responseDto);
        }
    }
}
