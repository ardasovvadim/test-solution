using System;
using System.Collections.Generic;
using System.Linq;
using TS.Data.Entities;

namespace TS.Data.Repositories
{
    public interface IReadOnlyRepository<T> where T : BaseEntity
    {
        T GetById(Guid key);
        IEnumerable<T> GetAll();
        IQueryable<T> GetQuery();
    }
}