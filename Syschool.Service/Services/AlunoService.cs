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

        public IEnumerable<Aluno> SelectAllAlunos() => _unitOfWork.AlunoRepository.Select();

        public Aluno SelectAlunoById(Guid id) => _unitOfWork.AlunoRepository.Select(id);

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
    }
}
