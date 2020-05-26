using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataModel.Repositories
{
    public interface IRepository<TSource> where TSource : class, IDisable, new()
    {
        Task<List<TSource>> GetAll();
        Task<TSource> Get(int id);

        Task Add(TSource source);
        Task<TSource> Update(int id, TSource source);

        Task<TSource> Disable(int id);
    }
}