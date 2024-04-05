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
using System.Runtime.InteropServices;

namespace BusinessLogicLayer.Services.Concretes
{
    public class AddressService : IAddressService
    {
        private readonly IMapper _mapper;
        private readonly IAddressRepository _repository;
        public AddressService(IMapper mapper, IAddressRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public AddressDto Add(AddressDto dto)
        {

            

            if (dto.User is null)
                if (dto.UserId is null)
                    throw new ForeignKeyOrNavigationPropertyNullException
                        ($"{nameof(Address)}-{nameof(Address.User)} - {nameof(Address.UserId)} ");



            var entity = _repository.GetById(false, dto.Id);

            if (entity is not null)
                throw new EntityAlreadyExistsException(nameof(Address));


            entity = _mapper.Map<Address>(dto);
            _repository.Add(entity);
            _repository.SaveChanges();

            return _mapper.Map<AddressDto>(entity);


        }

        public async Task<AddressDto> AddAsync(AddressDto dto)
        {

            if (dto.User is null)
                if (dto.UserId is null)
                    throw new ForeignKeyOrNavigationPropertyNullException($"{nameof(Address)}-{nameof(Address.User)} - {nameof(Address.UserId)} ");


            var entity = await _repository.GetByIdAsync(false, dto.Id);


            if (entity is not null)
                throw new EntityAlreadyExistsException(nameof(Address));


            entity = _mapper.Map<Address>(dto);
            await _repository.AddAsync(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<AddressDto>(entity);
        }

        public IEnumerable<AddressDto> AddRange(IEnumerable<AddressDto> dtos)
        {
            var control = dtos.EnumerableChecker(x => x.UserId is null && x.User is null);

            if (control)
                throw new ForeignKeyOrNavigationPropertyNullException(nameof(Address));

            var entities = _mapper.Map<IEnumerable<Address>>(dtos);

            _repository.AddRange(entities);
            _repository.SaveChanges();

            return _mapper.Map<IEnumerable<AddressDto>>(entities);
        }

        public async Task<IEnumerable<AddressDto>> AddRangeAsync(IEnumerable<AddressDto> dtos)
        {
            var control = dtos.EnumerableChecker(x => x.UserId is null && x.User is null);

            if (control)
                throw new ForeignKeyOrNavigationPropertyNullException(nameof(Address));

            var entities = _mapper.Map<IEnumerable<Address>>(dtos);

            await _repository.AddRangeAsync(entities);
            await _repository.SaveChangesAsync();


            return _mapper.Map<IEnumerable<AddressDto>>(entities);
        }

        public AddressDto Delete(long id)
        {
            var entity = _repository.GetById(false, id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Address));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<AddressDto>(entity);

        }

        public AddressDto Delete(AddressDto dto)
        {

            var entity = _repository.GetById(false, dto.Id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Address));

            _repository.Delete(entity);
            _repository.SaveChanges();

            return _mapper.Map<AddressDto>(entity);

        }

        public async Task<AddressDto> DeleteAsync(long id)
        {
            var entity = await _repository.GetByIdAsync(false, id);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Address));

            

            _repository.Delete(entity);
            await _repository.SaveChangesAsync();

            return _mapper.Map<AddressDto>(entity);

        }

        public void DeleteRange(IEnumerable<AddressDto> dtos)
        {
            if (dtos is null)
                throw new ArgumentNullException(nameof(Address));

            var control = dtos.EnumerableChecker(x => x == null);

            if (control)
                throw new ArgumentNullException(nameof(Address));

            foreach (var dto in dtos)
                _repository.Delete(dto.Id);

            _repository.SaveChanges();

          //  return _mapper.Map<IEnumerable<AddressDto>>(dtos);
        }

        public void DeleteRange(Expression<Func<Address, bool>> predicate)
        {
            var entities = _repository.GetAll().Where(predicate);

            foreach (var entity in entities)
                _repository.Delete(entity);


            _repository.SaveChanges();

            //return _mapper.Map<IEnumerable<AddressDto>>(entities);

        }


        public IEnumerable<AddressDto> GetAll(PaginationModel paginationModel, bool tracking = false)
        {
            var entities = _repository.GetAll(paginationModel, tracking);

            return _mapper.Map<IEnumerable<AddressDto>>(entities);

        }

        public IEnumerable<AddressDto> GetAll(PaginationModel paginationModel, Expression<Func<Address, bool>> predicate, Expression<Func<Address, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Address, long>>[] thenByKeySelector)
        {
            var entities = _repository.GetAll(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<AddressDto>>(entities);
            
        }

        public async Task<IEnumerable<AddressDto>> GetAllAsync(PaginationModel paginationModel, Expression<Func<Address, bool>> predicate, Expression<Func<Address, long>> orderByKeySelector, OrderByDirection direction, bool tracking = false, params Expression<Func<Address, long>>[] thenByKeySelector)
        {
            var entities = await _repository.GetAllAsync(paginationModel, predicate, orderByKeySelector, direction, tracking, thenByKeySelector);

            return _mapper.Map<IEnumerable<AddressDto>>(entities);
        }

        public AddressDto GetById(bool tracking = false, params object[] keyValues)
        {
            var entity = _repository.GetById(tracking, keyValues);

            return _mapper.Map<AddressDto>(entity);
        }

        public async Task<AddressDto> GetByIdAsync(bool tracking = false, params object[] keyValues)
        {
            var entity = await _repository.GetByIdAsync(tracking, keyValues);

            return _mapper.Map<AddressDto>(entity);
        }

        public AddressDto GetFirstOrDefault(Expression<Func<Address, bool>> predicate, bool tracking = false)
        {
            var entity = _repository.GetFirstOrDefault(predicate, tracking);

            if (entity is null)
                throw new EntityNotFoundException(nameof(Address));

            return _mapper.Map<AddressDto>(entity);

        }

        public async Task<AddressDto> GetFirstOrDefaultAsync(Expression<Func<Address, bool>> predicate, bool tracking = false)
        {
            var entity = await _repository.GetFirstOrDefaultAsync(predicate, tracking);

            if (entity is null)
                throw new EntityNotFoundException($"{nameof(Address)}");

            return _mapper.Map<AddressDto>(entity);

        }

        public (AddressDto, AddressDto) Update(AddressDto dto)
        {
            if (dto is null)
                throw new ParameterValueNullException(nameof(Address));

            var foundedEntity = _repository.GetById(false, dto.Id);

            if (foundedEntity is null)
                throw new EntityNotFoundException(nameof(Address));

            var oldEntity = _mapper.Map<AddressDto>(foundedEntity);

            var entity = _mapper.Map<Address>(dto);

            _repository.Update(entity);
            _repository.SaveChanges();

            var newEntity = _mapper.Map<AddressDto>(entity);

            return (oldEntity, newEntity);

        }
    }

}
