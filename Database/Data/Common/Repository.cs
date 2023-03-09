using Microsoft.EntityFrameworkCore;

namespace Database.Data.Common
{
    public class Repository
    {
        protected DbContext Context { get; set; }

        protected DbSet<T> DbSet<T>() where T : class
        {
            return this.Context.Set<T>();
        }
        public Repository(FootballDataDBContext context)
        {
            Context = context;
        }

    }
}
