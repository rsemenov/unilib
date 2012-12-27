using System;
using Unilib.Common.Interfaces;

namespace Unilib.Common.DataEntities
{
    public class RecordContentEntity:IEntity
    {
        public virtual Guid RecordId { get; set; }
        public virtual DataTypes DataType { get; set; }
        public virtual byte[] FileContent { get; set; }
        public virtual byte[] DescriptionContent { get; set; }
    }
}