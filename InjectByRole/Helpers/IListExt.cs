using System.Collections.Generic;
using System.Linq;
using LanguageExt;

namespace InjectByRole.Handlers
{
    public static class IListExt
    {
        public static bool IsNullOrEmpty<T>(this IList<T> list)
        {
            return list.IsNull() || !list.Any();
        }
    }
}
