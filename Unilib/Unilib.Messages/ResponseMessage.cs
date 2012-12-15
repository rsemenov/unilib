using System;
using NServiceBus;

namespace Unilib.Messages
{
    [Serializable]
    public class ResponseMessage : IMessage
    {
        public string SomeField { get; set; }
    }
}