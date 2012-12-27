using System;
using NServiceBus;
using Unilib.Common;

namespace Unilib.Messages
{
    [Serializable]
    public class AddRecordContentCommand : IMessage
    {
        public Guid RecordId { get; set; }
        public DataTypes DataType { get; set; }
        public byte[] ContentFile { get; set; }
        public byte[] DescriptionFile { get; set; }
    }
}