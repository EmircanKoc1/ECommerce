using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface ICommentService : IBaseReadService<CommentDto, Comment>, IBaseWriteService<CommentDto, Comment>
    {
    }
}
