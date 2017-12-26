using System.Collections.Generic;
using CadastroClientes.Domain.Entities;
using CadastroClientes.Domain.Interfaces.Repositories;
using CadastroClientes.Domain.Interfaces.Services;

namespace CadastroClientes.Domain.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoRepository.BuscarPorNome(nome);
        }
    }
}
