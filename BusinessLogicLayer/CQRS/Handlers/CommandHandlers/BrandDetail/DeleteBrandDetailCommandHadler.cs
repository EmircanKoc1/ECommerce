using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.BrandDetail;
using BusinessLogicLayer.CQRS.Commands.Responses.BrandDetail;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.BrandDetail
{
    public class DeleteBrandDetailCommandHadler : IRequestHandler<DeleteBrandDetailCommandRequest, DeleteBrandDetailCommandResponse>
    {
        IMapper _mapper;
        IBrandDetailService _brandDetailService;

        public DeleteBrandDetailCommandHadler(IMapper mapper, IBrandDetailService brandDetailService)
        {
            _mapper = mapper;
            _brandDetailService = brandDetailService;
        }

        public Task<DeleteBrandDetailCommandResponse> Handle(DeleteBrandDetailCommandRequest request, CancellationToken cancellationToken)
        {
            var brandDetailDto = _mapper.Map<BrandDetailDto>(request);
            var responseDto =_brandDetailService.Delete(brandDetailDto);

            return Task.FromResult(_mapper.Map<DeleteBrandDetailCommandResponse>(responseDto));

        }
    }
}
