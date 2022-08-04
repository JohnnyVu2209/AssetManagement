using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AssetManagementDbContext context;
        public CategoryRepository(AssetManagementDbContext context) 
        {
            this.context = context;
        }
    }
}