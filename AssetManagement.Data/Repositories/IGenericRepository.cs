using System.Linq.Expressions;

namespace AssetManagement.Data.Repositories
{
    public interface IGenericRpository<T> where T : class
    {
        public IEnumerable<T> Find(
            Expression<Func<T, bool>>? filter,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
            string? includeProperties);

        public Task<IEnumerable<T>> FindAsync(
            Expression<Func<T, bool>>? filter,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
            string? includeProperties);

        public T? GetByID(object id);

        public ValueTask<T?> GetByIDAsync(object id);

        public IEnumerable<T> GetAll();

        public Task<IEnumerable<T>> GetAllAsync();

        public void Add(T entities);

        public void AddRange(IEnumerable<T> entities);

        public void Remove(T entitiesToDelete);

        public void RemoveRange(IEnumerable<T> entitiesToDelete);

        // public void Update(T entityToUpdate);
    }
}