using Autofac;
using RestApiProject.Application;
using RestApiProject.Application.Interfaces;
using RestApiProject.Application.Mapper;
using RestApiProject.Application.Mapper.Interfaces;
using RestApiProject.Domain.Core.Interfaces.Repositories;
using RestApiProject.Domain.Core.Interfaces.Services;
using RestApiProject.Domain.Services;
using RestApiProject.Infrastructure.Data.Repositories;

namespace RestApiProject.Infrastructure.CrossCutting.IoC
{
    public class ConfigurationIoC
    {
        public static void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ApplicationServiceCliente>().As<IApplicationServiceCliente>();
            builder.RegisterType<ApplicationServiceProduto>().As<IApplicationServiceProduto>();

            builder.RegisterType<ServicoCliente>().As<IServicoCliente>();
            builder.RegisterType<ServicoProduto>().As<IServicoProduto>();

            builder.RegisterType<RepositorioCliente>().As<IRepositorioCliente>();
            builder.RegisterType<RepositorioProduto>().As<IRepositorioProduto>();

            builder.RegisterType<MapperCliente>().As<IMapperCliente>();
            builder.RegisterType<MapperProduto>().As<IMapperProduto>();
        }
    }
}
