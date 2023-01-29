using Syschool.Domain.Entities;
using Syschool.Domain.Interfaces.Services;
using Syschool.Domain.Interfaces.UnitOfWork;

namespace Syschool.Service.Services
{
    public class BaseService<TEntity> : IBaseService<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork<TEntity> _unitOfWork;

        public BaseService(IUnitOfWork<TEntity> unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Delete(Guid id)
        {
            _unitOfWork.Repository.Delete(id);
        }

        public IEnumerable<TEntity> Get()
        {
            return _unitOfWork.Repository.Get();
        }

        public TEntity Get(Guid id)
        {
            return _unitOfWork.Repository.Get(id);
        }

        public void Insert(TEntity entity)
        {
            _unitOfWork.Repository.Insert(entity);
        }

        public void Update(TEntity entity)
        {
            _unitOfWork.Repository.Update(entity);
        }
    }
}
