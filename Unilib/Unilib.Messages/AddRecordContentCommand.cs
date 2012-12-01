using System;
using NServiceBus;

namespace Unilib.Messages
{
    [Serializable]
    public class AddRecordContentCommand : IMessage
    {
        public Guid RecordId { get; set; }
        public int DataType { get; set; }
        public byte[] ContentFile { get; set; }
        public byte[] DescriptionFile { get; set; }
    }
}