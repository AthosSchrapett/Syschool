using Syschool.Domain.Entities;

namespace Syschool.Domain.Interfaces.Services
{
    public interface IAlunoService: IBaseService<Aluno>
    {
        public IEnumerable<Guid> GetIds();
    }
}
