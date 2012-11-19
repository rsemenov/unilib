using System;
using Unilib.CommunicationServer.Common;

namespace Unilib.CommunicationServer.DataEntities
{
    public class RecordEntity : IEntity
    {
        public virtual Guid Id { get; set; }
        public virtual string SortTitle { get; set; }
        public virtual string FullTitle { get; set; }
        public virtual string OtherTitle { get; set; }
        public virtual string TitleDescription { get; set; }
        public virtual string Responsibility { get; set; }
        public virtual string ChapterName { get; set; }
        public virtual string Publication { get; set; }
        public virtual string PublicationInfo { get; set; }
        public virtual string PublicationYear { get; set; }
    }
}