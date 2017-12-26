using System.Collections.Generic;
using System.Linq;
using CadastroClientes.Domain.Entities;
using CadastroClientes.Domain.Interfaces.Repositories;
using CadastroClientes.Domain.Interfaces.Services;

namespace CadastroClientes.Domain.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private IClienteRepository _clienteRepository;

        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes)
        {
            return clientes.Where(w => w.ClienteEspecial(w));
        }
    }
}
