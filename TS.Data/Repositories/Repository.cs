using System.Linq;
using TS.Data.Database;
using TS.Data.Entities;

namespace TS.Data.Repositories
{
    public class Repository<T> : ReadOnlyRepository<T>, IRepository<T> where T : BaseEntity
    {
        public Repository(IDbContextProvider dbContextProvider) : base(dbContextProvider)
        {
        }

        public void Update(T entity) => Set.Update(entity);

        public void Insert(T entity) => Set.Add(entity);

        public void Delete(T entity) => Set.Remove(entity);

        public void Save() => Context.SaveChanges();

        public override IQueryable<T> GetQuery() => Set.AsQueryable();
    }
}