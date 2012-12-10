using NServiceBus;
using Unilib.Common.Extensions;
using log4net;

namespace Unilib.ContentServer
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
                .JsonSerializer();
        }
        
    }
}
