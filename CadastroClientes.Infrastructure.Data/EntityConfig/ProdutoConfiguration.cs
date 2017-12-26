using System.Data.Entity.ModelConfiguration;
using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Infrastructure.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(c => c.ProdutoId);

            Property(c => c.Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(c => c.Valor)
                .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.ClienteId);
        }
    }
}
