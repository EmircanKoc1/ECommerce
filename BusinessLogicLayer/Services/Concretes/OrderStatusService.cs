using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class OrderStatusService : IOrderStatusService
    {
        public OrderStatusDto Add(OrderStatusDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<OrderStatusDto> AddAsync(OrderStatusDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderStatusDto> AddRange(IEnumerable<OrderStatusDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderStatusDto>> AddRangeAsync(IEnumerable<OrderStatusDto> dtos)
        {
            throw new NotImplementedException();
        }

        public OrderStatusDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public OrderStatusDto Delete(OrderStatusDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<OrderStatusDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderStatusDto> DeleteRange(IEnumerable<OrderStatusDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderStatusDto> DeleteRange(Expression<Func<OrderStatus, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderStatusDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderStatusDto> GetAll(PaginationModel paginationModel, Expression<Func<OrderStatus, bool>> predicate, Expression<Func<OrderStatus, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<OrderStatus, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderStatusDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<OrderStatus, bool>> predicate, Expression<Func<OrderStatus, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<OrderStatus, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public OrderStatusDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<OrderStatusDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public OrderStatusDto GetFirstOrDefault(Expression<Func<OrderStatus, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<OrderStatusDto> GetFirstOrDefaultAsync(Expression<Func<OrderStatus, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (OrderStatusDto, OrderStatusDto) Update(OrderStatusDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
