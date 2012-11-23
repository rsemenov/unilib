using System;
using Unilib.CommunicationServer.Common;

namespace Unilib.CommunicationServer.DataEntities
{
    public class AuthorRecordEntity:IEntity
    {
        public virtual int Id { get; set; }
        public virtual Guid AuthorId { get; set; }
        public virtual Guid RecordId { get; set; }
    }
}