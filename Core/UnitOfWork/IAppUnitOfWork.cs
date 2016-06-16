using Core.Entities;
using Core.Repositories;

namespace Core.UnitOfWork
{
    public interface IAppUnitOfWork
    {
        void Save();

        IGenericRepository<T> GetRepository<T>() where T : BaseEntity;
    }
}
