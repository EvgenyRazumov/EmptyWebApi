using Core.Entities;
using System;
using System.Collections.Generic;

namespace Core.Repositories
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        T GetById(int id);

        IEnumerable<T> Get(Func<T, bool> filter);

        IEnumerable<T> GetAll();

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
