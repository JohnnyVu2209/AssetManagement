using AssetManagement.Domain.Model;
using AssetManagement.Data;

namespace AssetManagement.Application.Application.Interfaces
{
    public class AssetService : IAssetService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AssetService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Asset>> GetAllAsync()
        {
            return await _unitOfWork.Assets.FindAsync(null, null, includeProperties: "State,Category,Location");
        }
    }
}