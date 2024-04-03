﻿using BusinessLogicLayer.CQRS.Commands.Responses.ShipmentCompany;
using MediatR;

namespace BusinessLogicLayer.CQRS.Commands.Requests.ShipmentCompanyDetail
{
    public class UpdateShipmentCompanyCommandRequest : IRequest<(UpdateShipmentCompanyCommandResponse, UpdateShipmentCompanyCommandResponse)>
    {
    }
}
