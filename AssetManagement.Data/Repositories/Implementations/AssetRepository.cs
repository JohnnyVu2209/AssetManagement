using AssetManagement.Data.Repositories.Extensions;
using AssetManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class AssetRepository: IAssetRepository
    {
        private readonly AssetManagementDbContext context;
        public AssetRepository(AssetManagementDbContext context) 
        {
            this.context = context;
        }

        public IQueryable<Asset> GetAssetsByFilter(int location, List<int>? state, List<int>? category, string? searching, string? orderBy)
        {
            var assets = context.Assets
                .Include(x => x.Category)
                .Include(x => x.Location)
                .Include(x => x.State).AsQueryable();

            if (assets.Any() && location != 0)
                assets = assets.Where(x => x.LocationID == location);

            if (assets.Any() && !string.IsNullOrWhiteSpace(searching))
                assets = assets.Where(x => x.Name.ToLower().Contains(searching.Trim().ToLower()) || x.Code.ToLower().Contains(searching.Trim().ToLower()));

            if (assets.Any() && state != null && state.Count != 0)
                assets = assets.Where(x => state.Contains(x.StateID));

            if (assets.Any() && category != null && category.Count != 0)
                assets = assets.Where(x => category.Contains(x.CategoryID));

            assets = assets.ApplySort(orderBy);

            return assets;
        }

        public async Task<Asset?> GetByAssetCodeAsync(string code)
        {
            return await context.Assets
                            .Include("State")
                            .Include("Category")
                            .Include("Location")
                            .FirstOrDefaultAsync(asset => asset.Code == code);
        }
    }
}