using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories
{
    public class AssetRepository : GenericRepository<Asset>, IAssetRepository
    {
        public AssetRepository(AssetManagementDbContext context) : base(context) { }
    }
}