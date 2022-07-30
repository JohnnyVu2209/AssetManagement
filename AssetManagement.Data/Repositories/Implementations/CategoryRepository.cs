using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AssetManagementDbContext context) : base(context) { }
    }
}