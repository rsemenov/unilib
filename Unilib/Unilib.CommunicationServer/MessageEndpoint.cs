using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NServiceBus;
using Unilib.Common.Extensions;

namespace Unilib.CommunicationServer
{
    public class MessageEndpoint : IConfigureThisEndpoint, AsA_Server, IWantCustomInitialization
    {
        /// <summary>
        /// Perform initialization logic.
        /// </summary>
        public void Init()
        {
            Configure.With()
                .ForUnilib()
                .JsonSerializer();
        }
        
    }
}
