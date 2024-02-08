using BusinessLogicLayer.Services.Abstracts.Base;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Abstracts
{
    public interface IBrandDetailService : IBaseReadService<BrandDetailDto, BrandDetail>, IBaseWriteService<BrandDetailDto, BrandDetail>
    {

       

    }
}
