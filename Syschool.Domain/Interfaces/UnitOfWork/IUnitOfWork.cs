using Syschool.Domain.Interfaces.Repositories;

namespace Syschool.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        IAlunoRepository AlunoRepository { get; }
        IProfessorRepository ProfessorRepository { get; }
        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
    }
}
