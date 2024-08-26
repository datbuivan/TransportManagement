using TransportManagement.Data.Entities.Cunstom;
using TransportManagement.Specifications;

namespace TransportManagement.Interface
{
    public interface IGenericRepository<T> where T : BaseEntities
    {
        Task<T> GetByIdAsync(Guid? id);
        Task<IEnumerable<T>> ListAllAsync();
        Task<T> GetEntityWithSpec(ISpecification<T> spec);
        Task<IEnumerable<T>> ListAsync(ISpecification<T> spec);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
