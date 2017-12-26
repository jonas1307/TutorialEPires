using System.Collections.Generic;
using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Domain.Interfaces.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BuscarPorNome(string nome);
    }
}
