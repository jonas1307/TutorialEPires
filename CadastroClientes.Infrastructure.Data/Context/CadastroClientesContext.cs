using System.Data.Entity;
using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Infrastructure.Data.Context
{
    public class CadastroClientesContext : DbContext
    {
        public CadastroClientesContext()
            : base("CadastroClientes")
        { }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
