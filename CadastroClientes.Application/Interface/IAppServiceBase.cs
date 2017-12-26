using System;
using System.Collections.Generic;

namespace CadastroClientes.Application.Interface
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);

        TEntity GetById(int id);

        IEnumerable<TEntity> GetAll();

        void Update(TEntity obj);

        void Delete(TEntity obj);
    }
}
