using TS.Data.Entities;

namespace TS.Data.Repositories
{
    public interface IRepository<T> : IReadOnlyRepository<T> where T : BaseEntity
    {
        void Update(T entity);
        void Insert(T entity);
        void Delete(T entity);
        void Save();
    }
}