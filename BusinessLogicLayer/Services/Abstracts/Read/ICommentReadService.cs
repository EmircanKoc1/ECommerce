using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Comment;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Read
{
    public interface ICommentReadService : IReadService<CommentForReadDto,Comment>
    {
    }
}
