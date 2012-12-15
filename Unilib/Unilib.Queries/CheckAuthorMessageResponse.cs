using System;
using NServiceBus;

namespace Unilib.Queries
{
    [Serializable]
    public class CheckAuthorMessageResponse : IMessage
    {
        public Guid? AuthorId { get; set; }
    }
}