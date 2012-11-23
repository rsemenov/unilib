using System;
using Unilib.Common.Interfaces;

namespace Unilib.Common.DataEntities
{
    public class AuthorRecordEntity:IEntity
    {
        public virtual int Id { get; set; }
        public virtual Guid AuthorId { get; set; }
        public virtual Guid RecordId { get; set; }
    }
}