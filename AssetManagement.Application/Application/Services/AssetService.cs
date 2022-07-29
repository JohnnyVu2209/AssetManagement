using AssetManagement.Domain.Model;
using AssetManagement.Data;

namespace AssetManagement.Application.Application.Interfaces
{
    public class AssetService : IAssetService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ICurrentUser _currentUser;

        public AssetService(IUnitOfWork unitOfWork, ICurrentUser currentUser)
        {
            _unitOfWork = unitOfWork;
            _currentUser = currentUser;
        }

        public async Task<IEnumerable<Asset>> GetAllAsync()
        {

            return await _unitOfWork.Assets
                                .FindAsync(
                                    asset => asset.LocationID == _currentUser.LocationId,
                                    null, "State,Category,Location");
        }

        public async Task<Asset?> GetByAssetCodeAsync(string code)
        {
            return await _unitOfWork.Assets.GetByAssetCodeAsync(code);
        }
    }
}