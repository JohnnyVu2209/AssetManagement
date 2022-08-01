using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories
{
    public interface IAssetRepository : IGenericRpository<Asset>
    {
        public Task<Asset?> GetByAssetCodeAsync(string code);
    }
}