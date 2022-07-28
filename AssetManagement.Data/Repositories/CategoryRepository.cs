using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(AssetManagementDbContext context) : base(context) { }
    }
}