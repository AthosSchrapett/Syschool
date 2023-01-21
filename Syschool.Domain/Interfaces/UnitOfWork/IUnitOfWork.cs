using Syschool.Domain.Interfaces.Repositories;

namespace Syschool.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork
    {
        public IAlunoRepository AlunoRepository { get; }
        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
    }
}
