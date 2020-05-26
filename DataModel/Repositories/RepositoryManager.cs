using DataModel.StockDbContext;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DataModel.Repositories
{
    public class RepositoryManager<TSource> : IRepository<TSource> where TSource : class, IDisable, new()
    {
        private readonly ApplicationDbContext _context;

        public RepositoryManager(ApplicationDbContext context)
        {
            this._context = context;
        }

        public Task Add(TSource source)
        {
            this._context.Entry(source).State = EntityState.Added;
            return this._context.SaveChangesAsync();
        }

        public async Task<TSource> Disable(int id)
        {
            var source = await this._context.Set<TSource>().FindAsync(id);
            if (source != null)
            {
                source.Enable = false;
                await this._context.SaveChangesAsync();
            }

            return source;
        }

        public Task<TSource> Get(int id)
        {
            return this._context.Set<TSource>().FindAsync(id).AsTask();
        }

        public Task<List<TSource>> GetAll()
        {
            return this._context.Set<TSource>().ToListAsync();
        }

        public async Task<TSource> Update(int id, TSource source)
        {
            this._context.Entry(source).State = EntityState.Modified;
            await this._context.SaveChangesAsync();
            return source;
        }
    }
}