using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.SubCategory;
using BusinessLogicLayer.CQRS.Commands.Responses.SubCategory;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.SubCategory
{
    public class DeleteSubCategoryCommandHandler : IRequestHandler<DeleteSubCategoryCommandRequest, DeleteSubCategoryCommandResponse>
    {
        IMapper _mapper;
        ISubCategoryService _subCategoryService;

        public DeleteSubCategoryCommandHandler(IMapper mapper, ISubCategoryService subCategoryService)
        {
            _mapper = mapper;
            _subCategoryService = subCategoryService;
        }

        public Task<DeleteSubCategoryCommandResponse> Handle(DeleteSubCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<SubCategoryDto>(request);

            var responseDto = _subCategoryService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteSubCategoryCommandResponse>(dto));
        }
    }
}
