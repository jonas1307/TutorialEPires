using System.Collections.Generic;
using CadastroClientes.Application.Interface;
using CadastroClientes.Domain.Entities;
using CadastroClientes.Domain.Interfaces.Services;

namespace CadastroClientes.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService) 
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais()
        {
            return _clienteService.ObterClientesEspeciais(_clienteService.GetAll());
        }
    }
}
