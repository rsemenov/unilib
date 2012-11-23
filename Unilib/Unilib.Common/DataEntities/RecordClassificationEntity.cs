using System;
using Unilib.Common.Interfaces;

namespace Unilib.Common.DataEntities
{
    public class RecordClassificationEntity : IEntity
    {
        public virtual int Id { get; set; }
        public virtual Guid RecordId { get; set; }
        public virtual string ISBN { get; set; }
        public virtual string ISSN { get; set; }
        public virtual string NationalNumber { get; set; }
        public virtual string OtherIdentifier { get; set; }
        public virtual string DocumentNumber { get; set; }
        public virtual int ThemeClassificationId { get; set; }
    }
}