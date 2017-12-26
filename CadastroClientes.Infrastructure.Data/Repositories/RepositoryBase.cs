using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using CadastroClientes.Domain.Interfaces;
using CadastroClientes.Domain.Interfaces.Repositories;
using CadastroClientes.Infrastructure.Data.Context;

namespace CadastroClientes.Infrastructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected CadastroClientesContext _context = new CadastroClientesContext();

        public void Add(TEntity obj)
        {
            _context.Set<TEntity>().Add(obj);
            _context.SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _context.Set<TEntity>().ToList();
        }

        public void Update(TEntity obj)
        {
            _context.Entry(obj).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void Delete(TEntity obj)
        {
            _context.Set<TEntity>().Remove(obj);
            _context.SaveChanges();
        }

        void IDisposable.Dispose()
        { }
    }
}
