using CadastroClientes.Domain.Entities;
using CadastroClientes.Domain.Interfaces.Repositories;

namespace CadastroClientes.Infrastructure.Data.Repositories
{
    public class ClienteRepository : RepositoryBase<Cliente>, IClienteRepository
    { }
}
