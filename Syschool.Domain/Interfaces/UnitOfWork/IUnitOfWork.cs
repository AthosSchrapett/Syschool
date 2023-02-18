using Syschool.Domain.Interfaces.Repositories;

namespace Syschool.Domain.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAlunoRepository AlunoRepository { get; }
        IProfessorRepository ProfessorRepository { get; }
        void CreateTransaction();
        void Commit();
        void Rollback();
        void Save();
    }
}
