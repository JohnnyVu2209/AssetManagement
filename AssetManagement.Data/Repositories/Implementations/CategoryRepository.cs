using AssetManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AssetManagementDbContext context;
        public CategoryRepository(AssetManagementDbContext context) 
        {
            this.context = context;
        }

        public Task<List<Category>> GetAllAsync()
        {
            return context.Categories.ToListAsync();
        }
    }
}