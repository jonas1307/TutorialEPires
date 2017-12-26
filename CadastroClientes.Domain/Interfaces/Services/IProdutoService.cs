using System.Collections.Generic;
using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Domain.Interfaces.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
