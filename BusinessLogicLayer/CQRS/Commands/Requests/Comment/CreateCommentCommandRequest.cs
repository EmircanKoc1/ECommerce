using BusinessLogicLayer.CQRS.Commands.Responses.Comment;
using CoreLayer.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Comment
{
    public class CreateCommentCommandRequest : IRequest<CreateCommentCommandResponse>
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public byte Score { get; set; }
        public long? ProductId { get; set; }
        public long? UserId { get; set; }
       

    }
}
