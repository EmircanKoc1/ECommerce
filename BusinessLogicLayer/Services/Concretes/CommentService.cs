using AutoMapper;
using BusinessLogicLayer.Extensions;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Exceptions;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class CommentService : ICommentService
    {
        ICommentRepository _repository;
        IMapper _mapper;

        public CommentService(ICommentRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public void CommentValidator(CommentDto dto)
        {
            Comment entity = null;

            if (dto is null)
                throw new ParameterValueNullException(nameof(Comment));

            if (dto.UserId is 0 || dto.ProductId is 0)
                if (dto.UserId is null || dto.ProductId is null)
                    throw new ForeignKeyOrNavigationPropertyNullException(nameof(Comment));

            if (dto.Id is not 0)
                entity = _repository.GetById(false, dto.Id);

            if (entity is not null)
                throw new EntityAlreadyExistsException(nameof(Comment));
        }

        public async Task CommentValidatorAsync(CommentDto dto)
        {
            Comment entity = null;

            if (dto is null)
                throw new ParameterValueNullException(nameof(Comment));

            if (dto.UserId is 0 || dto.ProductId is 0)
                if (dto.UserId is null || dto.ProductId is null)
                    throw new ForeignKeyOrNavigationPropertyNullException(nameof(Comment));

            if (dto.Id is not 0)
                entity = await _repository.GetByIdAsync(false, dto.Id);

            if (entity is not null)
                throw new EntityAlreadyExistsException(nameof(Comment));
        }
        public CommentDto Add(CommentDto dto)
        {
            Comment entity = null;

            CommentValidator(dto);

            entity = _mapper.Map<Comment>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<CommentDto>(entity);

        }

        public async Task<CommentDto> AddAsync(CommentDto dto)
        {
            Comment entity = null;

            CommentValidator(dto);

            entity = _mapper.Map<Comment>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<CommentDto>(entity);
        }

        public IEnumerable<CommentDto> AddRange(IEnumerable<CommentDto> dtos)
        {
            if (dtos is null)
                throw new ParameterValueNullException(nameof(dtos));

            foreach (CommentDto dto in dtos)
                CommentValidator(dto);

            var entities = _mapper.Map<IEnumerable<Comment>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<CommentDto>>(entities);

        }

        public async Task<IEnumerable<CommentDto>> AddRangeAsync(IEnumerable<CommentDto> dtos)
        {
            if (dtos is null)
                throw new ParameterValueNullException(nameof(Comment));

            foreach (CommentDto dto in dtos)
                await CommentValidatorAsync(dto);

            var entities = _mapper.Map<IEnumerable<Comment>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<CommentDto>>(entities);

        }

        public CommentDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull(nameof(Comment));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<CommentDto>(entity);
        }

        public CommentDto Delete(CommentDto dtos)
        {
            var entity = _repository.GetById(false, dtos.Id);

            entity.ThrowIfNull(nameof(Comment));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<CommentDto>(entity);
        }

        public async Task<CommentDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull(nameof(Comment));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<CommentDto>(entity);
        }

        public void DeleteRange(IEnumerable<CommentDto> dtos)
        {
            dtos.ThrowIfNull(nameof(Comment));

            foreach (CommentDto dto in dtos)
                dto.ThrowIfNull(nameof(Comment));

            var entities = _mapper.Map<IEnumerable<Comment>>(dtos);
            _repository.DeleteRange(entities);
            _repository.SaveChanges();

            //return _mapper.Map<IEnumerable<CommentDto>>(entities);
        }

        public void DeleteRange(Expression<Func<Comment, bool>> predicate)
        {
            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<CommentDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);
            return _mapper.Map<IEnumerable<CommentDto>>(entities);
        }

        public IEnumerable<CommentDto> GetAll(PaginationModel paginationModel, Expression<Func<Comment, bool>> predicate, Expression<Func<Comment, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Comment, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);
            return _mapper.Map<IEnumerable<CommentDto>>(entities);
        }

        public async Task<IEnumerable<CommentDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Comment, bool>> predicate, Expression<Func<Comment, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Comment, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);
            return _mapper.Map<IEnumerable<CommentDto>>(entities);
        }

        public CommentDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            entity.ThrowIfNull(nameof(Comment), CustomException.EntityNotFoundException);

            return _mapper.Map<CommentDto>(entity);
        }

        public async Task<CommentDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);

            entity.ThrowIfNull(nameof(Comment), CustomException.EntityNotFoundException);

            return _mapper.Map<CommentDto>(entity);
        }

        public CommentDto GetFirstOrDefault(Expression<Func<Comment, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate);

            entity.ThrowIfNull(nameof(Comment), CustomException.EntityNotFoundException);

            return _mapper.Map<CommentDto>(entity);
        }

        public async Task<CommentDto> GetFirstOrDefaultAsync(Expression<Func<Comment, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate);

            entity.ThrowIfNull(nameof(Comment), CustomException.EntityNotFoundException);

            return _mapper.Map<CommentDto>(entity);
        }

        public (CommentDto, CommentDto) Update(CommentDto dto)
        {
            dto.ThrowIfNull(nameof(Comment), CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull(nameof(Comment), CustomException.EntityNotFoundException);

            var newEntity = _mapper.Map<Comment>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();
            var oldEntity = _mapper.Map<CommentDto>(foundedEntity);

            return (oldEntity, dto);


        }
    }

}
