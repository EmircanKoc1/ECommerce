using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class OrderItemService : IOrderItemService
    {
        public OrderItemDto Add(OrderItemDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItemDto> AddAsync(OrderItemDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderItemDto> AddRange(IEnumerable<OrderItemDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItemDto>> AddRangeAsync(IEnumerable<OrderItemDto> dtos)
        {
            throw new NotImplementedException();
        }

        public OrderItemDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public OrderItemDto Delete(OrderItemDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItemDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderItemDto> DeleteRange(IEnumerable<OrderItemDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderItemDto> DeleteRange(Expression<Func<OrderItem, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderItemDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderItemDto> GetAll(PaginationModel paginationModel, Expression<Func<OrderItem, bool>> predicate, Expression<Func<OrderItem, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<OrderItem, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItemDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<OrderItem, bool>> predicate, Expression<Func<OrderItem, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<OrderItem, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public OrderItemDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItemDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public OrderItemDto GetFirstOrDefault(Expression<Func<OrderItem, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<OrderItemDto> GetFirstOrDefaultAsync(Expression<Func<OrderItem, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (OrderItemDto, OrderItemDto) Update(OrderItemDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
