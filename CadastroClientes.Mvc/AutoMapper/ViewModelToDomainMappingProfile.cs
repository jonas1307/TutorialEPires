using AutoMapper;
using CadastroClientes.Domain.Entities;
using CadastroClientes.Mvc.ViewModels;

namespace CadastroClientes.Mvc.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<ClienteViewModel, Cliente>();
            Mapper.CreateMap<ProdutoViewModel, Produto>();
        }
    }
}