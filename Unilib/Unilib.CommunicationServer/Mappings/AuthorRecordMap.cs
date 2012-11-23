using FluentNHibernate.Mapping;
using Unilib.CommunicationServer.DataEntities;

namespace Unilib.CommunicationServer.Mappings
{
    public class AuthorRecordMap : ClassMap<AuthorRecordEntity>
    {
        public AuthorRecordMap()
        {
            Id(x => x.Id).Column("Id");
            Map(x => x.AuthorId).Column("AuthorId").Not.Nullable();
            Map(x => x.RecordId).Column("RecordId").Not.Nullable();
            Table("AuthorRecord");
        }
    }
}