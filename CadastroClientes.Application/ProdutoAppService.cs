using System.Collections.Generic;
using CadastroClientes.Domain.Entities;
using CadastroClientes.Domain.Interfaces.Services;

namespace CadastroClientes.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BuscarPorNome(string nome)
        {
            return _produtoService.BuscarPorNome(nome);
        }
    }
}
