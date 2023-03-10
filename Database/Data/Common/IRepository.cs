using System.Linq.Expressions;

namespace Database.Data.Common
{
    public interface IRepository
    {
        Task AddAsync<T>(T entity) where T : class;
       
        Task AddRangeAsync<T>(IEnumerable<T> entities) where T : class;

        Task<int> SaveChangesAsync();

        Task AllReadonly<T>();

    }
}
