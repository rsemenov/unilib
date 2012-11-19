using System;
using NServiceBus;

namespace Unilib.Messages
{
    [Serializable]
    public class CreateRecordCommand:IMessage
    {
        public Guid Id { get; set; }
        public string SortTitle { get; set; }
        public string FullTitle { get; set; }
        public string OtherTitle { get; set; }
        public string TitleDescription { get; set; }
        public string Responsibility { get; set; }
        public string ChapterName { get; set; }
        public string Publication { get; set; }
        public string PublicationInfo { get; set; }
        public string PublicationYear { get; set; }
    }
}