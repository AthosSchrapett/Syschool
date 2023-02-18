using Syschool.Domain.Entities;

namespace Syschool.Domain.Interfaces.Services
{
    public interface IAlunoService
    {
        void InsertAluno(Aluno aluno);
        void UpdateAluno(Aluno aluno);
        void DeleteAluno(Guid id);
        IEnumerable<Aluno> Get();
        Aluno Get(Guid id);
    }
}
