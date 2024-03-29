﻿using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using DataAccessLayer.Entities;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface ITokenService : IBaseReadService<TokenDto, Token>, IBaseWriteService<TokenDto, Token>
    {

        string CreateAccessToken(UserDto userDto);
        string CreateRefreshToken();

        TokenReponseDto GenerateTokenModel(UserDto userDto);
     



    }
}
