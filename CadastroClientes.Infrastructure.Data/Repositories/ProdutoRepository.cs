using System.Collections.Generic;
using System.Linq;
using CadastroClientes.Domain.Entities;
using CadastroClientes.Domain.Interfaces.Repositories;

namespace CadastroClientes.Infrastructure.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _context.Produtos.Where(w => w.Nome == nome);
        }
    }
}
