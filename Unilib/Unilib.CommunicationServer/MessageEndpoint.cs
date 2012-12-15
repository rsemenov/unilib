using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NServiceBus;
using Unilib.Common.Extensions;
using log4net;

namespace Unilib.CommunicationServer
{
    public class MessageEndpoint : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
        /// <summary>
        /// Perform initialization logic.
        /// </summary>
        public void Init()
        {
            SetLoggingLibrary.Log4Net(log4net.Config.XmlConfigurator.Configure);
            
            Configure.With()
                .ForUnilib()
                .RunCustomAction(() => Configure.Instance.Configurer.ConfigureComponent(() => LogManager.GetLogger("Loger"), DependencyLifecycle.SingleInstance))
                .XmlSerializer();
        }
        
    }
}
