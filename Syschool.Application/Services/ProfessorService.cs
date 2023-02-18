using Syschool.Domain.Entities;
using Syschool.Domain.Interfaces.Services;
using Syschool.Domain.Interfaces.UnitOfWork;

namespace Syschool.Service.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProfessorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void InsertProfessor(Professor professor)
        {
            _unitOfWork.ProfessorRepository.Insert(professor);
            _unitOfWork.Save();
        }

        public void UpdateProfessor(Professor professor)
        {
            _unitOfWork.ProfessorRepository.Update(professor);
            _unitOfWork.Save();
        }

        public void DeleteProfessor(Guid id)
        {
            _unitOfWork.ProfessorRepository.Delete(id);
            _unitOfWork.Save();
        }

        public IEnumerable<Professor> Get()
        {
            return _unitOfWork.ProfessorRepository.Get();
        }

        public Professor Get(Guid id)
        {
            return _unitOfWork.ProfessorRepository.Get(id);
        }
    }
}
