using System.Collections.Generic;
using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Domain.Interfaces.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais(IEnumerable<Cliente> clientes);
    }
}
