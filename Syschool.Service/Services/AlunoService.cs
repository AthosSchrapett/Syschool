using Syschool.Domain.Entities;
using Syschool.Domain.Interfaces.Services;
using Syschool.Domain.Interfaces.UnitOfWork;

namespace Syschool.Service.Services
{
    public class AlunoService : BaseService<Aluno>, IAlunoService
    {
        public AlunoService(IUnitOfWork<Aluno> unitOfWork) : base(unitOfWork)
        {
        }
    }
}
