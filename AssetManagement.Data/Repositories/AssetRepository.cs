using AssetManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Repositories
{
    public class AssetRepository : GenericRepository<Asset>, IAssetRepository
    {
        public AssetRepository(AssetManagementDbContext context) : base(context)
        {
            
        }

        public override IEnumerable<Asset> GetAll()
        {
            return Find(null, null, "State,Category,Location");
        }

        public override async Task<IEnumerable<Asset>> GetAllAsync()
        {
            return await FindAsync(null, null, "State,Category,Location");
        }

        public async Task<Asset?> GetByAssetCodeAsync(string code)
        {
            return await dbSet
                            .Include("State")
                            .Include("Category")
                            .Include("Location")
                            .FirstOrDefaultAsync(asset => asset.Code == code);
        }
    }
}