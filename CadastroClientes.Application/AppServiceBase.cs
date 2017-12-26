using System;
using System.Collections.Generic;
using CadastroClientes.Application.Interface;
using CadastroClientes.Domain.Interfaces.Services;

namespace CadastroClientes.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public void Add(TEntity obj)
        {
            _serviceBase.Add(obj);
        }

        public void Delete(TEntity obj)
        {
            _serviceBase.Delete(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public void Update(TEntity obj)
        {
            _serviceBase.Update(obj);
        }

        public void Dispose()
        {
            //_serviceBase.Dispose();
        }
    }
}
