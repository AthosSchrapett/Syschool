using Microsoft.EntityFrameworkCore;
using Syschool.Domain.Interfaces.Repositories;
using Syschool.Infra.Data.Context;

namespace Syschool.Infra.Data.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        private readonly SyschoolContext _syschoolContext;

        public BaseRepository(SyschoolContext syschoolContext) => _syschoolContext = syschoolContext;

        public void Insert(TEntity entity) => _syschoolContext.Set<TEntity>().AddAsync(entity);
        public IEnumerable<TEntity> Get() => _syschoolContext.Set<TEntity>();
        public TEntity Get(Guid id) => _syschoolContext.Set<TEntity>().Find(id);
        public void Update(TEntity entity) => _syschoolContext.Entry(entity).State = EntityState.Modified;
        public void Delete(Guid id) => _syschoolContext.Set<TEntity>().Remove(Get(id));
    }
}
