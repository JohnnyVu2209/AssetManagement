using AssetManagement.Data.Repositories;
using AssetManagement.Data.Repositories.Implementations;

namespace AssetManagement.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AssetManagementDbContext _context;

        public IAssetRepository Assets {get; private set;}

        public IStateRepository States {get; private set;}

        public ICategoryRepository Catagories {get; private set;}

        public UnitOfWork(AssetManagementDbContext context)
        {
            _context = context;
            
            Assets = new AssetRepository(context);
            States = new StateRepository(context);
            Catagories = new CategoryRepository(context);
        }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}