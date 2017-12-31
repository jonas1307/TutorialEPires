using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using CadastroClientes.Infrastructure.CrossCutting.IoC;
using CadastroClientes.Mvc.AutoMapper;

namespace CadastroClientes.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            AutoMapperConfig.RegisterMappings();
            DependencyResolver.SetResolver(new NinjectConfig());
        }
    }
}
