using NServiceBus;

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
                .DefaultBuilder()
                .JsonSerializer();
        }
    }
}
