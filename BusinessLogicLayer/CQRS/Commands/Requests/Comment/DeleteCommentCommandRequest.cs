﻿using BusinessLogicLayer.CQRS.Commands.Requests.Base;
using BusinessLogicLayer.CQRS.Commands.Responses.Comment;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CQRS.Commands.Requests.Comment
{
    public class DeleteCommentCommandRequest : BaseRequest, IRequest<DeleteCommentCommandResponse>
    {

    }
}
