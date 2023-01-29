using Syschool.Domain.Interfaces.Repositories;

namespace Syschool.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork<TEntity> where TEntity : class
    {
        public IBaseRepository<TEntity> Repository { get; }
        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
    }
}
