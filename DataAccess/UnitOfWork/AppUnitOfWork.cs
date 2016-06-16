using Core.UnitOfWork;
using Core.Entities;
using Core.Repositories;
using DataContext;
using DataAccess.Repositories;
using System;

namespace DataAccess.UnitOfWork
{
    public class AppUnitOfWork : IDisposable, IAppUnitOfWork
    {
        private readonly IAppDataContext _context;

        public AppUnitOfWork(IAppDataContext context)
        {
            _context = context;
        }

        public IGenericRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new GenericRepository<T>(_context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
            }
        }
    }
}
