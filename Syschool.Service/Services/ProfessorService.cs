using Syschool.Domain.Entities;
using Syschool.Domain.Interfaces.Services;
using Syschool.Domain.Interfaces.UnitOfWork;

namespace Syschool.Service.Services
{
    public class ProfessorService : BaseService<Professor>, IProfessorService
    {
        public ProfessorService(IUnitOfWork<Professor> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
