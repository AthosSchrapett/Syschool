namespace Syschool.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(Guid id);
        IEnumerable<TEntity> Get();
        TEntity Get(Guid id);
    }
}
