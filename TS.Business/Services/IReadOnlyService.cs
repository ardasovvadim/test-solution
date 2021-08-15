using System;
using System.Collections.Generic;

namespace TS.Business.Services
{
    public interface IReadOnlyService<Dto, TEntity> 
        where Dto : class
        where TEntity : class 
    {
        Dto GetById(Guid key);
        IEnumerable<Dto> GetAll();
    }
}