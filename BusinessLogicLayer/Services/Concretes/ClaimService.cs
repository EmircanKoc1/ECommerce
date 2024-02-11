using AutoMapper;
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
    public class ClaimService : IClaimService
    {
        IClaimRepository _repository;
        IMapper _mapper;

        public ClaimService(IClaimRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ClaimDto Add(ClaimDto dto)
        {
            if (dto is null)
                throw new ParameterValueNullException(nameof(Claim));

            var entity = _mapper.Map<Claim>(dto);

            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<ClaimDto>(entity);

        }

        public async Task<ClaimDto> AddAsync(ClaimDto dto)
        {
            if (dto is null)
                throw new ParameterValueNullException(nameof(Claim));

            var entity = _mapper.Map<Claim>(dto);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<ClaimDto>(entity);

        }

        public IEnumerable<ClaimDto> AddRange(IEnumerable<ClaimDto> dtos)
        {
            if (dtos is null)
                throw new ParameterValueNullException(nameof(Claim));

            var entities = _mapper.Map<IEnumerable<Claim>>(dtos);

            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<ClaimDto>>(entities);
        }

        public async Task<IEnumerable<ClaimDto>> AddRangeAsync(IEnumerable<ClaimDto> dtos)
        {
            if (dtos is null)
                throw new ParameterValueNullException(nameof(Claim));

            var entities = _mapper.Map<IEnumerable<Claim>>(dtos);

            await _repository.SaveChangesAsync();
            await _repository.AddRangeAsync(entities);

            return _mapper.Map<IEnumerable<ClaimDto>>(entities);
        }

        public ClaimDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Claim));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ClaimDto>(entity);

        }

        public ClaimDto Delete(ClaimDto dto)
        {
            if (dto is null)
                throw new ParameterValueNullException(nameof(Claim));

            var entity = _repository.GetById(false, dto.Id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Claim));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ClaimDto>(entity);
        }

        public async Task<ClaimDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Claim));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ClaimDto>(entity);
        }

        public IEnumerable<ClaimDto> DeleteRange(IEnumerable<ClaimDto> dtos)
        {
            if (dtos is null)
                throw new ParameterValueNullException(nameof(Claim));

            var entities = _mapper.Map<IEnumerable<Claim>>(dtos);
            _repository.DeleteRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<ClaimDto>>(entities);

        }

        public IEnumerable<ClaimDto> DeleteRange(Expression<Func<Claim, bool>> predicate)
        {
            var entities = _repository.GetAll(false).Where(predicate).AsEnumerable();

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<ClaimDto>>(entities);
        }

        public IEnumerable<ClaimDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            return _mapper.Map<IEnumerable<ClaimDto>>(entities);

        }

        public IEnumerable<ClaimDto> GetAll(PaginationModel paginationModel, Expression<Func<Claim, bool>> predicate, Expression<Func<Claim, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Claim, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<ClaimDto>>(entities);
        }

        public async Task<IEnumerable<ClaimDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Claim, bool>> predicate, Expression<Func<Claim, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Claim, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<ClaimDto>>(entities);
        }

        public ClaimDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);
            if (entity is null)
                throw new EntityNotFoundException(nameof(Claim));

            return _mapper.Map<ClaimDto>(entity);


        }

        public async Task<ClaimDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);
            if (entity is null)
                throw new EntityNotFoundException(nameof(Claim));

            return _mapper.Map<ClaimDto>(entity);
        }

        public ClaimDto GetFirstOrDefault(Expression<Func<Claim, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Claim));

            return _mapper.Map<ClaimDto>(entity);
        }

        public async Task<ClaimDto> GetFirstOrDefaultAsync(Expression<Func<Claim, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Claim));

            return _mapper.Map<ClaimDto>(entity);
        }

        public (ClaimDto, ClaimDto) Update(ClaimDto dto)
        {

            if (dto is null)
                throw new ParameterValueNullException(nameof(Claim));

            var foundedEntity = _repository.GetById(false, dto.Id);

            if (foundedEntity is null)
                throw new EntityNotFoundException(nameof(Claim));

            var oldEntity = _mapper.Map<ClaimDto>(foundedEntity);
            var newEntity = _mapper.Map<Claim>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);

        }
    }

}
