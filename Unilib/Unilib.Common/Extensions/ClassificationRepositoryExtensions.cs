using System.Collections.Generic;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;
using System.Linq;

namespace Unilib.Common.Extensions
{
    public static class ClassificationRepositoryExtensions
    {
        public static IEnumerable<ThemeClassificationEntity> GetAllLeafEntities(this IRepository<ThemeClassificationEntity> repository)
        {
            return repository.GetAllItems<ThemeClassificationEntity>().Where(entity => entity.IsLeaf);
        }

        public static IEnumerable<ThemeClassificationEntity> GetAllNotLeafEntities(this IRepository<ThemeClassificationEntity> repository)
        {
            return repository.GetAllItems<ThemeClassificationEntity>().Where(entity => !entity.IsLeaf);
        }
    }
}