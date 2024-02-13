using AutoMapper;
using BusinessLogicLayer.Extensions;
using BusinessLogicLayer.Services.Abstracts;
using CoreLayer.DTOs;
using CoreLayer.Enums;
using CoreLayer.Model;
using DataAccessLayer.Entities;
using DataAccessLayer.Repositories.Abstracts;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System.Linq.Expressions;

namespace BusinessLogicLayer.Services.Concretes
{
    public class ShipmentCompanyService : IShipmentCompanyService
    {
        IMapper _mapper;
        IShipmentCompanyRepository _repository;

        public ShipmentCompanyService(IMapper mapper, IShipmentCompanyRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public ShipmentCompanyDto Add(ShipmentCompanyDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _mapper.Map<ShipmentCompany>(dto);

            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<ShipmentCompanyDto>(entity);
        }

        public async Task<ShipmentCompanyDto> AddAsync(ShipmentCompanyDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _mapper.Map<ShipmentCompany>(dto);

            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<ShipmentCompanyDto>(entity);
        }

        public IEnumerable<ShipmentCompanyDto> AddRange(IEnumerable<ShipmentCompanyDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<ShipmentCompany>>(dtos);
            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<ShipmentCompanyDto>>(entities);

        }

        public async Task<IEnumerable<ShipmentCompanyDto>> AddRangeAsync(IEnumerable<ShipmentCompanyDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<ShipmentCompany>>(dtos);
            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();

            return _mapper.Map<IEnumerable<ShipmentCompanyDto>>(entities);
        }

        public ShipmentCompanyDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();


            return _mapper.Map<ShipmentCompanyDto>(entity);
        }

        public ShipmentCompanyDto Delete(ShipmentCompanyDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entity = _repository.GetById(false, dto.Id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ShipmentCompanyDto>(entity);
        }

        public async Task<ShipmentCompanyDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<ShipmentCompanyDto>(entity);
        }

        public void DeleteRange(IEnumerable<ShipmentCompanyDto> dtos)
        {
            dtos.ThrowIfNull("", CustomException.ParameterValueNullException);

            foreach (var dto in dtos)
                dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var entities = _mapper.Map<IEnumerable<ShipmentCompany>>(dtos);

            _repository.DeleteRange(entities);
            _repository.SaveChanges();

        }

        public void DeleteRange(Expression<Func<ShipmentCompany, bool>> predicate)
        {
            _repository.DeleteRange(predicate);
            _repository.SaveChanges();

        }

        public IEnumerable<ShipmentCompanyDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entites = _repository.GetAll(paginationModel, tracking);
            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ShipmentCompanyDto>>(entites);
        }

        public IEnumerable<ShipmentCompanyDto> GetAll(PaginationModel paginationModel, Expression<Func<ShipmentCompany, bool>> predicate, Expression<Func<ShipmentCompany, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ShipmentCompany, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ShipmentCompanyDto>>(entities);
        }

        public async Task<IEnumerable<ShipmentCompanyDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<ShipmentCompany, bool>> predicate, Expression<Func<ShipmentCompany, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<ShipmentCompany, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            entities.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<IEnumerable<ShipmentCompanyDto>>(entities);
        }

        public ShipmentCompanyDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ShipmentCompanyDto>(entity);

        }

        public async Task<ShipmentCompanyDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ShipmentCompanyDto>(entity);
        }

        public ShipmentCompanyDto GetFirstOrDefault(Expression<Func<ShipmentCompany, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ShipmentCompanyDto>(entity);
        }

        public async Task<ShipmentCompanyDto> GetFirstOrDefaultAsync(Expression<Func<ShipmentCompany, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate);

            entity.ThrowIfNull("", CustomException.EntityNotFoundException);

            return _mapper.Map<ShipmentCompanyDto>(entity);
        }

        public (ShipmentCompanyDto, ShipmentCompanyDto) Update(ShipmentCompanyDto dto)
        {
            dto.ThrowIfNull("", CustomException.ParameterValueNullException);

            var foundedEntity = _repository.GetById(false, dto.Id);

            foundedEntity.ThrowIfNull("", CustomException.EntityNotFoundException);

            var oldEntity = _mapper.Map<ShipmentCompanyDto>(foundedEntity);
            var newEntity = _mapper.Map<ShipmentCompany>(dto);

            _repository.Update(newEntity);
            _repository.SaveChanges();

            return (oldEntity, dto);
        }
    }

}
