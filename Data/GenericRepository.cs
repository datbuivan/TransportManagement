using Microsoft.EntityFrameworkCore;
using TransportManagement.Data.Entities.Cunstom;
using TransportManagement.Infrastructure;
using TransportManagement.Interface;
using TransportManagement.Specifications;

namespace TransportManagement.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntities
    {
        private readonly TransportContext _context;
        private readonly DbSet<T> _dbSet;
        public GenericRepository(TransportContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }
        private IQueryable<T> ApplySpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_context.Set<T>().AsQueryable(), spec);
        }
        public async Task<T> GetByIdAsync(Guid? id)
        {
            return await _dbSet.FindAsync(id);
        }
        public async Task<IEnumerable<T>> ListAllAsync()
        {
            return await _dbSet.ToListAsync();
        }
        public Task<IEnumerable<T>> ListAsync(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }
        public Task<T> GetEntityWithSpec(ISpecification<T> spec)
        {
            throw new NotImplementedException();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }
        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() =>
            {
                _dbSet.Attach(entity);
                _context.Entry(entity).State = EntityState.Modified;
            });
        }
        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() =>
            {
                if (_context.Entry(entity).State == EntityState.Detached)
                {
                    _dbSet.Attach(entity);
                }
                _dbSet.Remove(entity);
            });
        }
    }
}
