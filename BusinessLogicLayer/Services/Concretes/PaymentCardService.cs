using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class PaymentCardService : IPaymentCardService
    {
        public PaymentCardDto Add(PaymentCardDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentCardDto> AddAsync(PaymentCardDto dto)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentCardDto> AddRange(IEnumerable<PaymentCardDto> dtos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaymentCardDto>> AddRangeAsync(IEnumerable<PaymentCardDto> dtos)
        {
            throw new NotImplementedException();
        }

        public PaymentCardDto Delete(long id)
        {
            throw new NotImplementedException();
        }

        public PaymentCardDto Delete(PaymentCardDto dtos)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentCardDto> DeleteAsync(long id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentCardDto> DeleteRange(IEnumerable<PaymentCardDto> dtos)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentCardDto> DeleteRange(Expression<Func<PaymentCard, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentCardDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PaymentCardDto> GetAll(PaginationModel paginationModel, Expression<Func<PaymentCard, bool>> predicate, Expression<Func<PaymentCard, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<PaymentCard, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PaymentCardDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<PaymentCard, bool>> predicate, Expression<Func<PaymentCard, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<PaymentCard, long>>[] thenByKeySelector)
        {
            throw new NotImplementedException();
        }

        public PaymentCardDto GetById(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentCardDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public PaymentCardDto GetFirstOrDefault(Expression<Func<PaymentCard, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public Task<PaymentCardDto> GetFirstOrDefaultAsync(Expression<Func<PaymentCard, bool>> predicate, bool tracking = false)
        {
            throw new NotImplementedException();
        }

        public (PaymentCardDto, PaymentCardDto) Update(PaymentCardDto dtos)
        {
            throw new NotImplementedException();
        }
    }

}
