using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentNHibernate.Mapping;
using Unilib.CommunicationServer.DataEntities;

namespace Unilib.CommunicationServer.Mappings
{
    public class AuthorMap : ClassMap<AuthorEntity>
    {
        public AuthorMap()
        {
            //Schema("UniLib");
            Id(x => x.AuthorId).Column("AuthorId");
            Map(x => x.FirstPart).Not.Nullable();
            Map(x => x.FullName).Not.Nullable();
            Map(x => x.Name).Not.Nullable();
            Map(x => x.NameAddition).Not.Nullable();
            Map(x => x.OtherNames).Not.Nullable();
            Map(x => x.SufixPart).Not.Nullable();
            Table("Authors");
        }
    }
}
