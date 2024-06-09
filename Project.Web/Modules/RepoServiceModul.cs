using Autofac;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Project.Caching;

//using Project.Caching;
using Project.Core.Repositories;
using Project.Core.Services;
using Project.Core.UnitOfWorks;
using Project.Repository;
using Project.Repository.Repositories;
using Project.Repository.UnitOfWorks;
using Project.Service.Mapping;
using Project.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace Project.Web.Modules
{
    public class RepoServiceModul:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();

            builder.RegisterGeneric(typeof(Service<>)).As(typeof(IService<>)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();

            var apiAssembly = Assembly.GetExecutingAssembly();
            var repoAssembly = Assembly.GetAssembly(typeof(AppDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith
            ("Repository")).AsImplementedInterfaces().InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(apiAssembly, repoAssembly, serviceAssembly).Where(x => x.Name.EndsWith
            ("Service")).AsImplementedInterfaces().InstancePerLifetimeScope();


            builder.RegisterType<ProductServiceWithCaching>().As<IProductService>();

           
        }
    }
}
