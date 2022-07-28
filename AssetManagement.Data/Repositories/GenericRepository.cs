using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Repositories
{
    public class GenericRepository<T> : IGenericRpository<T> where T : class
    {
        protected readonly AssetManagementDbContext _context;

        protected readonly DbSet<T> dbSet;

        public GenericRepository(AssetManagementDbContext context)
        {
            _context = context;
            dbSet = _context.Set<T>();
        }

        private IQueryable<T> FindImpl(
            Expression<Func<T, bool>>? filter,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
            string? includeProperties
        )
        {
            IQueryable<T> query = dbSet;

            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                query = query.Include(includeProperties);
            }

            if (orderBy != null)
            {
                return orderBy(query);
            }
            else
            {
                return query;
            }
        }

        public IEnumerable<T> Find(
            Expression<Func<T, bool>>? filter,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
            string? includeProperties)
        {
            return FindImpl(filter, orderBy, includeProperties).ToList();
        }

        public async Task<IEnumerable<T>> FindAsync(
            Expression<Func<T, bool>>? filter,
            Func<IQueryable<T>, IOrderedQueryable<T>>? orderBy,
            string? includeProperties)
        {
            return await FindImpl(filter, orderBy, includeProperties).ToListAsync();
        }

        public T? GetByID(object id)
        {
            return dbSet.Find(id);
        }

        public async ValueTask<T?> GetByIDAsync(object id)
        {
            return await dbSet.FindAsync(id);
        }

        public IEnumerable<T> GetAll()
        {
            return dbSet.ToList();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await dbSet.ToListAsync();
        }

        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        public void AddRange(IEnumerable<T> entities)
        {
            dbSet.AddRange(entities);
        }

        public void Remove(T entityToDelete)
        {
            dbSet.Remove(entityToDelete);
        }

        public void RemoveRange(IEnumerable<T> entitiesToDelete){
            dbSet.RemoveRange(entitiesToDelete);
        }
    }
}