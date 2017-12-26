using CadastroClientes.Domain.Entities;
using CadastroClientes.Domain.Interfaces;

namespace CadastroClientes.Infrastructure.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    { }
}
