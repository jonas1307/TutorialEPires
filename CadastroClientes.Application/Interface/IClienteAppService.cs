using System.Collections.Generic;
using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Application.Interface
{
    public interface IClienteAppService : IAppServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClientesEspeciais();
    }
}
