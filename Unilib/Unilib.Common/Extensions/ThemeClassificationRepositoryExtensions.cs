using System.Linq;
using Unilib.Common.DataEntities;
using Unilib.Common.Interfaces;

namespace Unilib.Common.Extensions
{
    public static class ThemeClassificationRepositoryExtensions
    {
        public static ThemeClassificationEntity GetThemeClassificationEntityByTitle(IRepository<ThemeClassificationEntity> repository, string title)
        {
            return repository.GetAllItems<ThemeClassificationEntity>().FirstOrDefault(e => e.Title == title);
        }
    }
}