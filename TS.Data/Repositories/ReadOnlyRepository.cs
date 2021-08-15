using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TS.Data.Database;
using TS.Data.Entities;
using DbContext = TS.Data.Database.DbContext;

namespace TS.Data.Repositories
{
    public class ReadOnlyRepository<T> : IReadOnlyRepository<T> where T : BaseEntity
    {
        private readonly IDbContextProvider _dbContextProvider;
        protected DbContext Context => _dbContextProvider.Context;
        protected DbSet<T> Set => Context.Set<T>();

        public ReadOnlyRepository(IDbContextProvider dbContextProvider)
        {
            _dbContextProvider = dbContextProvider;
        }

        public virtual T GetById(Guid key) => GetQuery().FirstOrDefault(e => e.Id == key);

        public virtual IEnumerable<T> GetAll() => GetQuery().AsEnumerable();

        public virtual IQueryable<T> GetQuery() => Set.AsNoTracking();
    }
}