using Syschool.Domain.Entities;
using Syschool.Domain.Interfaces.Repositories;
using Syschool.Infra.Data.Context;
using Syschool.Infra.Data.Repository;

namespace Syschool.Infra.Data.Repositories
{
    public class ProfessorRepository : BaseRepository<Professor>, IProfessorRepository
    {
        public ProfessorRepository(SyschoolContext syschoolContext) : base(syschoolContext)
        {
        }
    }
}
