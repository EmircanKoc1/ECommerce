using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Category;
using BusinessLogicLayer.CQRS.Commands.Responses.Category;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Category
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommandRequest, CreateCategoryCommandResponse>
    {
        IMapper _mapper;
        IValidator<CategoryDto> _validator;
        ICategoryService _categoryService;

        public CreateCategoryCommandHandler(IMapper mapper, IValidator<CategoryDto> validator, ICategoryService categoryService)
        {
            _mapper = mapper;
            _validator = validator;
            _categoryService = categoryService;
        }

        public async Task<CreateCategoryCommandResponse> Handle(CreateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<CategoryDto>(request);

            var validationResult = await _validator.ValidateAsync(dto);

            if (!validationResult.IsValid)
                return null;

            var responseDto = _categoryService.AddAsync(dto);

            return _mapper.Map<CreateCategoryCommandResponse>(responseDto);

        }
    }
}
