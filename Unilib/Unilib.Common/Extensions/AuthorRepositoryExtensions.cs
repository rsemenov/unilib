using System.Collections.Generic;
using System.Linq;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;

namespace Unilib.Common.Extensions
{
    public static class AuthorRepositoryExtensions
    {
        public static IEnumerable<AuthorEntity> GetAuthorsByName(this IRepository<AuthorEntity> repository, string name, string surname)
        {
            return repository.GetAllItems<AuthorEntity>().Where(entity => 
                                                                entity.FullName.ToLowerInvariant().Contains(name.ToLowerInvariant()) 
                                                                && entity.FullName.ToLowerInvariant().Contains(surname.ToLowerInvariant()));
        }
    }
}