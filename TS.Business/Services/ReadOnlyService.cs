using System;
using System.Collections.Generic;
using AutoMapper;
using TS.Data.Entities;
using TS.Data.Repositories;

namespace TS.Business.Services
{
    public class ReadOnlyService<Dto, Entity> : IReadOnlyService<Dto, Entity>
        where Dto : class
        where Entity : BaseEntity
    {
        private readonly IReadOnlyRepository<Entity> _repository;
        private readonly IMapper _mapper;

        public ReadOnlyService(IReadOnlyRepository<Entity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public Dto GetById(Guid key)
        {
            var entity = _repository.GetById(key);
            return entity == null ? null : _mapper.Map<Dto>(entity);
        }

        public IEnumerable<Dto> GetAll() => _mapper.Map<IEnumerable<Dto>>(_repository.GetAll());
    }
}