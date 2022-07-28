using AssetManagement.Data.Repositories;

namespace AssetManagement.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IAssetRepository Assets {get;}

        IStateRepository States {get;}

        ICategoryRepository Catagories {get;}

        int Complete();

        Task<int> CompleteAsync();
    }
}