using Syschool.Domain.Entities;
using Syschool.Domain.Interfaces.Services;
using Syschool.Domain.Interfaces.UnitOfWork;

namespace Syschool.Service.Services
{
    public class AlunoService : IAlunoService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AlunoService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void InsertAluno(Aluno aluno)
        {
            _unitOfWork.AlunoRepository.Insert(aluno);
            _unitOfWork.Save();
        }

        public void UpdateAluno(Aluno aluno)
        {
            _unitOfWork.AlunoRepository.Update(aluno);
            _unitOfWork.Save();
        }

        public void DeleteAluno(Guid id)
        {
            _unitOfWork.AlunoRepository.Delete(id);
            _unitOfWork.Save();
        }

        public IEnumerable<Aluno> Get()
        {
           return _unitOfWork.AlunoRepository.Get();
        }

        public Aluno Get(Guid id)
        {
            return _unitOfWork.AlunoRepository.Get(id);
        }
    }
}
