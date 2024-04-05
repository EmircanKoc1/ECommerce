using AutoMapper;
using BusinessLogicLayer.CQRS.Commands.Requests.Category;
using BusinessLogicLayer.CQRS.Commands.Responses.Category;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using MediatR;

namespace BusinessLogicLayer.CQRS.Handlers.CommandHandlers.Category
{
    public class DeleteCategoryCommadHandler : IRequestHandler<DeleteCategoryCommandRequest, DeleteCategoryCommandResponse>
    {

        IMapper _mapper;
        ICategoryService _categoryService;

        public DeleteCategoryCommadHandler(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        public Task<DeleteCategoryCommandResponse> Handle(DeleteCategoryCommandRequest request, CancellationToken cancellationToken)
        {
            var dto = _mapper.Map<CategoryDto>(request);
            var responseDto = _categoryService.Delete(dto);

            return Task.FromResult(_mapper.Map<DeleteCategoryCommandResponse>(responseDto));
        }
    }
}
