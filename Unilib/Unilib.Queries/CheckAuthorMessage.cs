using NServiceBus;
using System;

namespace Unilib.Queries
{
    [Serializable]
    public class CheckAuthorMessage : IMessage
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MiddleName { get; set; }
    }
}