using CoreLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Responses.Base
{
    public abstract class BaseCommentCommandResponse
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public byte Score { get; set; }
        public long? ProductId { get; set; }
        public long? UserId { get; set; }
    }
}
