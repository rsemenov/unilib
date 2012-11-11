using Autofac.Builder;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NServiceBus;
using Autofac;
using Unilib.CommunicationServer.Common;

namespace Unilib.CommunicationServer
{
    public class MessageEndpoint : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
        /// <summary>
        /// Perform initialization logic.
        /// </summary>
        public void Init()
        {
            ISessionFactory sessionFactory = Fluently.Configure()
                .Database(MsSqlConfiguration.MsSql2008
                              .ConnectionString(@"Data Source=.\SqlExpress2008;Initial Catalog=UniLib;Integrated Security=True")
                              .ShowSql())
                .Mappings(m => m.FluentMappings.AddFromAssemblyOf<MessageEndpoint>())
                .ExposeConfiguration(BuildSchema).BuildSessionFactory();

            ContainerBuilder builder = new ContainerBuilder();
            builder.RegisterInstance<ISessionFactory>(sessionFactory);     
            builder.RegisterGeneric(typeof (Repository<>)).As(typeof (IRepository<>))
                .WithProperty("SessionFactory",sessionFactory);
            var container = builder.Build();

            Configure.With()
                .AutofacBuilder(container)
                .JsonSerializer();
            //.Configurer.RegisterSingleton<ISessionFactory>(sessionFactory);

            //.ConfigureComponent(typeof(Repository<>), DependencyLifecycle.InstancePerCall);
        }

        private static void BuildSchema(Configuration config)
        {
            // this NHibernate tool takes a configuration (with mapping info in)
            // and exports a database schema from it
            new SchemaExport(config)
                .Create(true, true);
        }
    }
}
