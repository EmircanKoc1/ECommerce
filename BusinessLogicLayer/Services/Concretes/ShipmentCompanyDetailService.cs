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
    public class ShipmentCompanyDetailService : IShipmentCompanyDetailService
    {
        IMapper _mapper;
        IShipmentCompanyDetailRepository _repository;

        public ShipmentCompanyDetailService(IMapper mapper, IShipmentCompanyDetailRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        void CustomValidator(ShipmentCompanyDetailDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            if (dto.ShipmentCompanyId is null or 0)
                dto.ThrowIfNull("", CustomException.ForeignKeyOrNavigationPropertyNullException);

        }

        public ShipmentCompanyDetailDto Add(ShipmentCompanyDetailDto dto)
        {
            CustomValidator(dto);

            var entity = _mapper.Map<ShipmentCompanyDetail>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<ShipmentCompanyDetailDto>(entity);
        }

        public async Task<ShipmentCompanyDetailDto> AddAsync(ShipmentCompanyDetailDto dto)
        {

            CustomValidator(dto);

            var entity = _mapper.Map<ShipmentCompanyDetail>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<ShipmentCompanyDetailDto>(entity);
        }

        public IEnumerable<ShipmentCompanyDetailDto> AddRange(IEnumerable<ShipmentCompanyDetailDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<ShipmentCompanyDetail>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<ShipmentCompanyDetailDto>>(entities);
        }

        public async Task<IEnumerable<ShipmentCompanyDetailDto>> AddRangeAsync(IEnumerable<ShipmentCompanyDetailDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<ShipmentCompanyDetail>>(dtos);
            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<ShipmentCompanyDetailDto>>(entities);
        }

        public ShipmentCompanyDetailDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ShipmentCompanyDetailDto>(entity);

        }

        public ShipmentCompanyDetailDto Delete(ShipmentCompanyDetailDto dto)
        {
            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ShipmentCompanyDetailDto>(entity);
        }

        public async Task<ShipmentCompanyDetailDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ShipmentCompanyDetailDto>(entity);
        }

        public void DeleteRange(IEnumerable<ShipmentCompanyDetailDto> dtos)
        {

            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                CustomValidator(dto);

            var entities = _mapper.Map<IEnumerable<ShipmentCompanyDetail>>(dtos);
            _repository.DeleteRange(entities);
            _repository.SaveChanges();
        }

        public void DeleteRange(Expression<Func<ShipmentCompanyDetail, bool>> predicate)
        {

            _repository.DeleteRange(predicate);
            _repository.SaveChanges();
        }

        public IEnumerable<ShipmentCompanyDetailDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ShipmentCompanyDetailDto>>(entities);

        }

        public IEnumerable<ShipmentCompanyDetailDto> GetAll(PaginationModel paginationModel, Expression<Func<ShipmentCompanyDetail, bool>> predicate, Expression<Func<ShipmentCompanyDetail, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ShipmentCompanyDetail, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ShipmentCompanyDetailDto>>(entities);
        }

        public async Task<IEnumerable<ShipmentCompanyDetailDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<ShipmentCompanyDetail, bool>> predicate, Expression<Func<ShipmentCompanyDetail, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ShipmentCompanyDetail, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ShipmentCompanyDetailDto>>(entities);
        }

        public ShipmentCompanyDetailDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ShipmentCompanyDetailDto>(entity);

        }

        public async Task<ShipmentCompanyDetailDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ShipmentCompanyDetailDto>(entity);

        }

        public ShipmentCompanyDetailDto GetFirstOrDefault(Expression<Func<ShipmentCompanyDetail, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ShipmentCompanyDetailDto>(entity);

        }

        public async Task<ShipmentCompanyDetailDto> GetFirstOrDefaultAsync(Expression<Func<ShipmentCompanyDetail, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ShipmentCompanyDetailDto>(entity);
        }

        public (ShipmentCompanyDetailDto, ShipmentCompanyDetailDto) Update(ShipmentCompanyDetailDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<ShipmentCompanyDetailDto>(foundedEntity);
            var newEntity = _mapper.Map<ShipmentCompanyDetail>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);

        }
    }

}
