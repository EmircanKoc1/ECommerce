using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Category;
using BusinessLogicLayer.CQRS.Commands.Responses.Category;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using FluentValidation;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Category
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommandRequest, (UpdateCategoryCommandResponse, UpdateCategoryCommandResponse)>
    {
        IMapper _mapper;
        ICategoryService _categoryService;
        IValidator<CategoryDto> _validator;

        public UpdateCategoryCommandHandler(IMapper mapper, ICategoryService categoryService, IValidator<CategoryDto> validator)
        {
            _mapper = mapper;
            _categoryService = categoryService;
            _validator = validator;
        }

        public async Task<(UpdateCategoryCommandResponse, UpdateCategoryCommandResponse)> Handle(UpdateCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var cateogoryDto = _mapper.Map<CategoryDto>(request);

            var validationResult = await _validator.ValidateAsync(cateogoryDto);

            if (!validationResult.IsValid)
                return (null, null);

            var responseTuple = _categoryService.Update(cateogoryDto);
            var old = _mapper.Map<UpdateCategoryCommandResponse>(responseTuple.Item1);
            var @new = _mapper.Map<UpdateCategoryCommandResponse>(responseTuple.Item2);

            return (old, @new);

        }
    }
}
