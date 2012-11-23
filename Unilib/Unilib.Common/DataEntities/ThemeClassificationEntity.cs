using Unilib.Common.Interfaces;

namespace Unilib.Common.DataEntities
{
    public class ThemeClassificationEntity:IEntity
    {
        public virtual int Id { get; set; }
        public virtual int ParentId { get; set; }
        public virtual string Title { get; set; }
        public virtual string Description { get; set; }
        public virtual bool IsLeaf { get; set; }
    }
}