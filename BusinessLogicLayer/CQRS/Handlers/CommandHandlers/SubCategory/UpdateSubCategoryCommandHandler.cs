using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.SubCategory;
using BusinessLogicLayer.CQRS.Commands.Responses.SubCategory;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.SubCategory
{
    public class UpdateSubCategoryCommandHandler : IRequestHandler<UpdateSubCategoryCommandRequest, (UpdateSubCategoryCommandResponse, UpdateSubCategoryCommandResponse)>
    {
        IMapper _mapper;
        IValidator<SubCategoryDto> _validator;
        ISubCategoryService _subCategoryService;

        public UpdateSubCategoryCommandHandler(IMapper mapper, IValidator<SubCategoryDto> validator, ISubCategoryService subCategoryService)
        {
            _mapper = mapper;
            _validator = validator;
            _subCategoryService = subCategoryService;
        }

        public async Task<(UpdateSubCategoryCommandResponse, UpdateSubCategoryCommandResponse)> Handle(UpdateSubCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<SubCategoryDto>(request);

            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return (null, null);

            var tupleDto = _subCategoryService.Update(dto);

            var old = _mapper.Map<UpdateSubCategoryCommandResponse>(tupleDto.Item1);
            var @new = _mapper.Map<UpdateSubCategoryCommandResponse>(tupleDto.Item2);

            return (old, @new);

        }


    }
}
