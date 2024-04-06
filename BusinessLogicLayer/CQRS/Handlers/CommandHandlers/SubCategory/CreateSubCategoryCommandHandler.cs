using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.SubCategory;
using BusinessLogicLayer.CQRS.Commands.Responses.SubCategory;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.SubCategory
{
    public class CreateSubCategoryCommandHandler : IRequestHandler<CreateSubCategoryCommandRequest, CreateSubCategoryCommandResponse>
    {
        IMapper _mapper;
        ISubCategoryService _subCategoryService;
        IValidator<SubCategoryDto> _validator;

        public CreateSubCategoryCommandHandler(IMapper mapper, ISubCategoryService subCategoryService, IValidator<SubCategoryDto> validator)
        {
            _mapper = mapper;
            _subCategoryService = subCategoryService;
            _validator = validator;
        }

        public async Task<CreateSubCategoryCommandResponse> Handle(CreateSubCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<SubCategoryDto>(request);

            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return null;

            var responseDto = _subCategoryService.AddAsync(dto);

            return _mapper.Map<CreateSubCategoryCommandResponse>(responseDto);
        }
    }
}
