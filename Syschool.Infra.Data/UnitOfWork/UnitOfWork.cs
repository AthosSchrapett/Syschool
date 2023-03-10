using Microsoft.EntityFrameworkCore.Storage;
using Syschool.Domain.Interfaces.Repositories;
using Syschool.Domain.Interfaces.UnitOfWork;
using Syschool.Infra.Data.Context;
using Syschool.Infra.Data.Repositories;
using Syschool.Infra.Data.Repository;
using System.ComponentModel.DataAnnotations;

namespace Syschool.Infra.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        #region Repositories

        private IAlunoRepository _alunoRepository;
        private IProfessorRepository _professorRepository;

        #endregion

        private readonly SyschoolContext _syschoolContext;

        private bool _disposed;
        private IDbContextTransaction _objTran;

        public UnitOfWork(SyschoolContext syschoolContext) => _syschoolContext = syschoolContext;

        public void CreateTransaction()
        {
            _objTran = _syschoolContext.Database.BeginTransaction();
        }

        public IAlunoRepository AlunoRepository
        {
            get => _alunoRepository = _alunoRepository == null ? new AlunoRepository(_syschoolContext) : _alunoRepository;
        }

        public IProfessorRepository ProfessorRepository
        {
            get => _professorRepository = _professorRepository == null ? new ProfessorRepository(_syschoolContext) : _professorRepository;
        }

        IBaseRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if(_syschoolContext != null)
                return  BaseRepository<TEntity>(_syschoolContex);
            else
                return null;
        }

        public void Commit()
        {
            _objTran.Commit();
        }

        public void Rollback()
        {
            _objTran.Rollback();
            _objTran.Dispose();
        }

        public void Save()
        {
            try
            {
                _syschoolContext.SaveChanges();
            }
            catch (ValidationException validationException)
            {
                throw new Exception(validationException.Message);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _objTran.Dispose();
            _disposed = true;
        }
    }
}
