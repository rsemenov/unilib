using System;
using NServiceBus;

namespace Unilib.Messages
{
    [Serializable]
    public class CreateAuthorRecordRelationCommand : IMessage
    {
        public Guid AuthorId { get; set; }
        public Guid RecordId { get; set; }
    }
}