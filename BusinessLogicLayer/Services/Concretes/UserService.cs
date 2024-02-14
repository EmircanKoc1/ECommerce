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
    public class UserService : IUserService
    {
        IHashService _hashService;
        IUserRepository _repository;
        IMapper _mapper;

        public UserService(IHashService hashService, IUserRepository repository, IMapper mapper)
        {
            _hashService = hashService;
            _repository = repository;
            _mapper = mapper;
        }

        public UserDto Add(UserDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _mapper.Map<User>(dto);
            entity.Password = _hashService.HashPassword(dto.Password, dto.Username);

            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<UserDto>(entity);

        }

        public async Task<UserDto> AddAsync(UserDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _mapper.Map<User>(dto);
            entity.Password = _hashService.HashPassword(dto.Password, dto.Username);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<UserDto>(entity);
        }

        public IEnumerable<UserDto> AddRange(IEnumerable<UserDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<User>>(dtos);

            foreach (var user in entities)
                user.Password = _hashService.HashPassword(user.Password, user.Username);

            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<UserDto>>(entities);
        }

        public async Task<IEnumerable<UserDto>> AddRangeAsync(IEnumerable<UserDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<User>>(dtos);

            foreach (var user in entities)
                user.Password = _hashService.HashPassword(user.Password, user.Username);

            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<UserDto>>(entities);
        }

        public UserDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<UserDto>(entity);
        }

        public UserDto Delete(UserDto dtos)
        {
            var entity = _repository.GetById(false, dtos.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<UserDto>(entity);
        }

        public async Task<UserDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);
            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<UserDto>(entity);
        }

        public void DeleteRange(IEnumerable<UserDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<User>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<User, bool>> predicate)
        {
            predicate.ThrowIfNull("", CustomException.ParameterValueNullException);

            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<UserDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);
            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<UserDto>>(entities);
        }

        public IEnumerable<UserDto> GetAll(PaginationModel paginationModel, Expression<Func<User, bool>> predicate, Expression<Func<User, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<User, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<UserDto>>(entities);
        }

        public async Task<IEnumerable<UserDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<User, bool>> predicate, Expression<Func<User, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<User, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<UserDto>>(entities);
        }

        public UserDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<UserDto>(entity);
        }

        public async Task<UserDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<UserDto>(entity);
        }

        public UserDto GetFirstOrDefault(Expression<Func<User, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<UserDto>(entity);
        }

        public async Task<UserDto> GetFirstOrDefaultAsync(Expression<Func<User, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<UserDto>(entity);
        }

        public (UserDto, UserDto) Update(UserDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);
            var oldEntity = _mapper.Map<UserDto>(foundedEntity);
            var newEntity = _mapper.Map<User>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);

        }
    }

}
