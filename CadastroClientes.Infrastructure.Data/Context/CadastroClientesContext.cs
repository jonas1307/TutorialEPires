using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using CadastroClientes.Domain.Entities;

namespace CadastroClientes.Infrastructure.Data.Context
{
    public class CadastroClientesContext : DbContext
    {
        public CadastroClientesContext()
            : base("CadastroClientes")
        { }

        #region Overrides EF

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Produto -> Produtoes
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            //Evitar deletar em cascata
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            // Setar campo XptoId como ID da tabela
            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "Id")
                .Configure(p => p.IsKey());

            // Setar todas strings como VARCHAR
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));

            // Quando não houver MAXLENGHT, setar para 255 ao invés de MAX
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(255));
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries().Where(entry => entry.Entity.GetType().GetProperty("DataCadastro") != null))
            {
                if (entry.State == EntityState.Added)
                    entry.Property("DataCadastro").CurrentValue = DateTime.Now;

                if (entry.State == EntityState.Modified)
                    entry.Property("DataCadastro").IsModified = false;
            }

            return base.SaveChanges();
        }

        #endregion

        public DbSet<Cliente> Clientes { get; set; }
    }
}
