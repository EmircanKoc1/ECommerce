using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.PaymentCard;
using BusinessLogicLayer.CQRS.Commands.Responses.PaymentCard;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.PaymentCard
{
    public class DeletePaymentCardCommandHandler : IRequestHandler<DeletePaymentCardCommandRequest, DeletePaymentCardCommandResponse>
    {
        IMapper _mapper;
        IPaymentCardService _paymentCardService;

        public DeletePaymentCardCommandHandler(IMapper mapper, IPaymentCardService paymentCardService)
        {
            _mapper = mapper;
            _paymentCardService = paymentCardService;
        }

        public Task<DeletePaymentCardCommandResponse> Handle(DeletePaymentCardCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<PaymentCardDto>(request);
            var responseDto = _paymentCardService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeletePaymentCardCommandResponse>(responseDto));
        }
    }
}
