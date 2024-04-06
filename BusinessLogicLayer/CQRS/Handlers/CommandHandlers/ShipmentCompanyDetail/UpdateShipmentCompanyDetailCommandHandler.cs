using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail;
using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompanyDetail;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.ShipmentCompanyDetail
{
    public class UpdateShipmentCompanyDetailCommandHandler : IRequestHandler<UpdateShipmentCompanyDetailCommandRequest, (UpdateShipmentCompanyDetailCommandResponse, UpdateShipmentCompanyDetailCommandResponse)>
    {
        IMapper _mapper;
        IValidator<ShipmentCompanyDetailDto> _validator;
        IShipmentCompanyDetailService _shipmentCompanyDetailService;

        public UpdateShipmentCompanyDetailCommandHandler(IMapper mapper, IValidator<ShipmentCompanyDetailDto> validator, IShipmentCompanyDetailService shipmentCompanyDetailService)
        {
            _mapper = mapper;
            _validator = validator;
            _shipmentCompanyDetailService = shipmentCompanyDetailService;
        }

        public async Task<(UpdateShipmentCompanyDetailCommandResponse, UpdateShipmentCompanyDetailCommandResponse)> Handle(UpdateShipmentCompanyDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<ShipmentCompanyDetailDto>(request);
            var validationResult = await _validator.ValidateAsync(dto);
            if (!validationResult.IsValid)
                return (null, null);

            var tupleDto = _shipmentCompanyDetailService.Update(dto);
            var old = _mapper.Map<UpdateShipmentCompanyDetailCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateShipmentCompanyDetailCommandResponse>(tupleDto.Item2);

            return (old, @new);
        }
    }
}
