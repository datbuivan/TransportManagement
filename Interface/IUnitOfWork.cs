using TransportManagement.Data.Entities.Cunstom;

namespace TransportManagement.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntities;
        Task<int> SaveChangesAsync();
    }
}
