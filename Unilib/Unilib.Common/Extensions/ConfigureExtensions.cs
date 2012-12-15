using System;
using System.Text;
using Autofac;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NServiceBus;
using Unilib.Common.Interfaces;

namespace Unilib.Common.Extensions
{
    public static class ConfigureExtensions
    {
        public static Configure ForUnilib(this Configure configuration)
        {
            ISessionFactory sessionFactory = Fluently.Configure()
               .Database(MsSqlConfiguration.MsSql2008
                             .ConnectionString(@"Data Source=.\SqlExpress2008;Initial Catalog=Unilib;Integrated Security=True")
                             .ShowSql())
               .Mappings(m => m.FluentMappings.AddFromAssemblyOf<IEntity>())
               .ExposeConfiguration((config) => { new SchemaUpdate(config); })
               .BuildSessionFactory();

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterInstance<ISessionFactory>(sessionFactory);
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>))
                .WithProperty("SessionFactory", sessionFactory);
            var container = builder.Build();

            return configuration.AutofacBuilder(container);
        }
    }
}
