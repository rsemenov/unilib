﻿using FluentNHibernate.Mapping;
using Unilib.Common.DataEntities;

namespace Unilib.Common.Mappings
{
    public class AuthorMap : ClassMap<AuthorEntity>
    {
        public AuthorMap()
        {
            //Schema("UniLib");
            Id(x => x.AuthorId).Column("AuthorId").Unique();
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