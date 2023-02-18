using Syschool.Domain.Entities;

namespace Syschool.Domain.Interfaces.Services
{
    public interface IProfessorService
    {
        void InsertProfessor(Professor professor);
        void UpdateProfessor(Professor professor);
        void DeleteProfessor(Guid id);
        IEnumerable<Professor> Get();
        Professor Get(Guid id);
    }
}
