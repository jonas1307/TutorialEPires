using System.Collections.Generic;
using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Application.Interface
{
    public interface IProdutoAppService : IAppServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
