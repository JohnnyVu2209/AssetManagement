using AssetManagement.Domain.Model;

namespace AssetManagement.Application.Application.Interfaces
{
    public interface IAssetService
    {
        Task<IEnumerable<Asset>> GetAllAsync();
    }
}