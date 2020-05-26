using System.Collections.Generic;

namespace GiJoStock
{
    public interface IRepository<TSource>
    {
        List<TSource> GetAll(Dictionary<string, object> filter = null);
        TSource Get(int id);

        TSource Add(TSource source);
        TSource Update(TSource source);

        TSource Disable(int id);
    }
}