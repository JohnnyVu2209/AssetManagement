using AssetManagement.Contracts.AssetDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories
{
    public interface IAssetRepository
    {
        Task<Asset?> GetByAssetCodeAsync(string code);

        IQueryable<Asset> GetAssetsByFilter(int location ,List<int>? state, List<int>? category, string? searching, string? orderBy);

        Task<ApiResult<string>> CreateAsync(CreateAssetRequest request);
    }
}