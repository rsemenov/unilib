using System;
using NServiceBus;

namespace Unilib.Messages
{
    [Serializable]
    public class AddRecordClassificationCommand : IMessage
    {
        public int Id { get; set; }
        public Guid RecordId { get; set; }
        public string ISBN { get; set; }
        public string ISSN { get; set; }
        public string NationalNumber { get; set; }
        public string OtherIdentifier { get; set; }
        public string DocumentNumber { get; set; }
        public string ThemeClassificationTitle { get; set; }
    }
}