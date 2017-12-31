using System;
using System.Collections.Generic;
using System.Web.Mvc;
using CadastroClientes.Application;
using CadastroClientes.Application.Interface;
using CadastroClientes.Domain.Interfaces.Repositories;
using CadastroClientes.Domain.Interfaces.Services;
using CadastroClientes.Domain.Services;
using CadastroClientes.Infrastructure.Data.Repositories;
using Ninject;

namespace CadastroClientes.Infrastructure.CrossCutting.IoC
{
    public class NinjectConfig : IDependencyResolver
    {
        private readonly IKernel _kernel;

        public NinjectConfig()
        {
            _kernel = new StandardKernel();
            AddBindings();
        }

        private void AddBindings()
        {
            _kernel.Bind(typeof(IAppServiceBase<>)).To(typeof(AppServiceBase<>));
            _kernel.Bind<IClienteAppService>().To<ClienteAppService>();
            _kernel.Bind<IProdutoAppService>().To<ProdutoAppService>();

            _kernel.Bind(typeof(IServiceBase<>)).To(typeof(ServiceBase<>));
            _kernel.Bind<IClienteService>().To<ClienteService>();
            _kernel.Bind<IProdutoService>().To<ProdutoService>();

            _kernel.Bind(typeof(IRepositoryBase<>)).To(typeof(RepositoryBase<>));
            _kernel.Bind<IClienteRepository>().To<ClienteRepository>();
            _kernel.Bind<IProdutoRepository>().To<ProdutoRepository>();
        }

        public object GetService(Type serviceType)
        {
            return _kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return _kernel.GetAll(serviceType);
        }
    }
}