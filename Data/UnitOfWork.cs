using Microsoft.EntityFrameworkCore;
using System.Collections;
using TransportManagement.Data.Entities.Cunstom;
using TransportManagement.Infrastructure;
using TransportManagement.Interface;

namespace TransportManagement.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TransportContext _context;
        private Hashtable _repositories;
        public UnitOfWork(TransportContext context)
        {
            _context = context;
        }
        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntities
        {
            if (_repositories == null) _repositories = new Hashtable();
            var type = typeof(TEntity).Name;
            if (!_repositories.ContainsKey(type))
            {
                var repositoryType = typeof(GenericRepository<>);
                var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(TEntity)), _context);
                _repositories.Add(type, repositoryInstance);
            }
            return (IGenericRepository<TEntity>)_repositories[type];
        }
    }
}
