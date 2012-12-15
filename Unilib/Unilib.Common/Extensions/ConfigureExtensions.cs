using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Autofac;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Tool.hbm2ddl;
using NServiceBus;
using Unilib.Common.Interfaces;
using Unilib.Common.DataEntities;

namespace Unilib.Common.Extensions
{
    public static class ConfigureExtensions
    {
        public static Configure ForUnilib(this Configure configuration)
        {
            ISessionFactory sessionFactory = Fluently.Configure()
               .Database(MsSqlConfiguration.MsSql2008
                             .ConnectionString(@"Data Source=.\SqlExpress;Initial Catalog=Unilib;Integrated Security=True")
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

    public static class ThemeClassificationRepositoryExtensions
    {
        public static ThemeClassificationEntity GetThemeClassificationEntityByTitle(IRepository<ThemeClassificationEntity> repository, string title)
        {
            return repository.GetAllItems<ThemeClassificationEntity>().FirstOrDefault(e => e.Title == title);
        }
    }

}
