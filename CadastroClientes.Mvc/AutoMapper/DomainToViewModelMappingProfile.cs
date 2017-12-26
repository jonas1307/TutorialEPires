using AutoMapper;
using CadastroClientes.Domain.Entities;
using CadastroClientes.Mvc.ViewModels;

namespace CadastroClientes.Mvc.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }

        protected override void Configure()
        {
            Mapper.CreateMap<Cliente, ClienteViewModel>();
            Mapper.CreateMap<Produto, ProdutoViewModel>();
        }
    }
}