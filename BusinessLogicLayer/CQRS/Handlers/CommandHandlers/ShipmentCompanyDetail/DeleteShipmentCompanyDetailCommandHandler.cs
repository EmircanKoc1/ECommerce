using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompanyDetail;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ShipmentCompanyDetail
{
    public class DeleteShipmentCompanyDetailCommandHandler : IRequestHandler<DeleteShipmentCompanyDetailCommandRequest, DeleteShipmentCompanyDetailCommandResponse>
    {
        IMapper _mapper;
        IShipmentCompanyDetailService _shipmentDetailService;

        public DeleteShipmentCompanyDetailCommandHandler(IMapper mapper, IShipmentCompanyDetailService shipmentDetailService)
        {
            _mapper = mapper;
            _shipmentDetailService = shipmentDetailService;
        }

        public Task<DeleteShipmentCompanyDetailCommandResponse> Handle(DeleteShipmentCompanyDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ShipmentCompanyDetailDto>(request);

            var responseDto = _shipmentDetailService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteShipmentCompanyDetailCommandResponse>(responseDto));

        }
    }
}
