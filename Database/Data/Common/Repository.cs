using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Database.Data.Common
{
    public class Repository : IRepository
    {
        protected DbContext Context { get; set; }

        public Repository(FootballDataDBContext context)
        {
            Context = context;
        }

        public Repository()
        {
        }

        protected DbSet<T> DbSet<T>() where T : class
        {
            return this.Context.Set<T>();
        }

        public async Task AddAsync<T>(T entity) where T : class
        {
            await DbSet<T>().AddAsync(entity);
        }

        public async Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class
        {
            await DbSet<T>().AddRangeAsync(entities);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await this.Context.SaveChangesAsync();
        }

        public async Task AllReadonly<T>()
        {
           
        }
    }
}
