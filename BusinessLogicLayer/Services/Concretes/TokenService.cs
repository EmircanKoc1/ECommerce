using AutoMapper;
using BusinessLogicLayer.Extensions;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class TokenService : ITokenService
    {
        ITokenRepository _repository;
        IMapper _mapper;

        public TokenService(ITokenRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        void CustomValidator(TokenDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.User is null && dto.UserId is null or 0)
                dto.ThrowIfNull("");

        }
        public TokenDto Add(TokenDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<Token>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<TokenDto>(entity);
        }

        public async Task<TokenDto> AddAsync(TokenDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<Token>(dto);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<TokenDto>(entity);


        }

        public IEnumerable<TokenDto> AddRange(IEnumerable<TokenDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<Token>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<TokenDto>>(entities);
        }

        public async Task<IEnumerable<TokenDto>> AddRangeAsync(IEnumerable<TokenDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<Token>>(dtos);
            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<TokenDto>>(entities);
        }

        public TokenDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<TokenDto>(entity);
        }

        public TokenDto Delete(TokenDto dto)
        {
            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<TokenDto>(entity);
        }

        public async Task<TokenDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<TokenDto>(entity);
        }

        public void DeleteRange(IEnumerable<TokenDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<Token>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<Token, bool>> predicate)
        {
            predicate.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<TokenDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            entities.ThrowIfNull("", CustomException.ParameterValueNullException);

            return _mapper.Map<IEnumerable<TokenDto>>(entities);
        }

        public IEnumerable<TokenDto> GetAll(PaginationModel paginationModel, Expression<Func<Token, bool>> predicate, Expression<Func<Token, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Token, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<TokenDto>>(entities);
        }

        public async Task<IEnumerable<TokenDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Token, bool>> predicate, Expression<Func<Token, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Token, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<TokenDto>>(entities);
        }

        public TokenDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<TokenDto>(entity);
        }

        public async Task<TokenDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<TokenDto>(entity);
        }

        public TokenDto GetFirstOrDefault(Expression<Func<Token, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<TokenDto>(entity);

        }

        public async Task<TokenDto> GetFirstOrDefaultAsync(Expression<Func<Token, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<TokenDto>(entity);
        }

        public (TokenDto, TokenDto) Update(TokenDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<TokenDto>(foundedEntity);
            var newEntity = _mapper.Map<Token>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);

        }
    }

}
