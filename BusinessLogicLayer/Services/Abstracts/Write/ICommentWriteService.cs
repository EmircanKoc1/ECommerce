using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DataTransferObjects.Comment;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts.Write
{
    public interface ICommentWriteService : IWriteService<CommentForUpdateDto, CommentForDeleteDto, CommentForAddDto, Comment>
    {
    }

}
