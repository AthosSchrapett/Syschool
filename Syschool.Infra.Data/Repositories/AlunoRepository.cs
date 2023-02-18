using Syschool.Domain.Entities;
using Syschool.Domain.Interfaces.Repositories;
using Syschool.Infra.Data.Context;
using Syschool.Infra.Data.Repository;

namespace Syschool.Infra.Data.Repositories
{
    public class AlunoRepository : BaseRepository<Aluno>, IAlunoRepository
    {
        public AlunoRepository(SyschoolContext syschoolContext) : base(syschoolContext)
        {
        }
    }
}
