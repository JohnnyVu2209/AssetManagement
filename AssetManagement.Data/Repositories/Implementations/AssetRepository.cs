using AssetManagement.Contracts.AssetDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.Constant.Enums;
using AssetManagement.Data.Repositories.Extensions;
using AssetManagement.Domain.Model;
using AssetManagement.Domain.Model.Enums;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class AssetRepository: IAssetRepository
    {
        private readonly AssetManagementDbContext context;
        private readonly ICategoryRepository categoryRepository;
        private readonly ICurrentUser currentUser;
        public AssetRepository(AssetManagementDbContext context, ICategoryRepository categoryRepository, ICurrentUser currentUser)
        {
            this.context = context;
            this.categoryRepository = categoryRepository;
            this.currentUser = currentUser;
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
                            .Include(x => x.Historical)
                            .FirstOrDefaultAsync(asset => asset.Code == code);
        }

        public string GetAssetCode(string categoryPrefix)
        {
            return context.Assets
                .Where(x => x.Code.StartsWith(categoryPrefix))
                .OrderBy(x => x.Code)
                .Select(x => x.Code)
                .LastOrDefault() ?? "";
        }

        public async Task<ApiResult<string>> CreateAsync(CreateAssetRequest request)
        {
            //Check state
            if (request.AssetStateId != (int)AssetState.Available && request.AssetStateId != (int)AssetState.NotAvailable)
            {
                return new ApiResult<string>(null)
                {
                    Message = "This asset state is not allowed!",
                    StatusCode = 400
                };
            }
            //Check category
            if (!CategoryIdExists(request.CategoryId))
            {
                return new ApiResult<string>(null)
                {
                    Message = "Category does not exist!",
                    StatusCode = 400
                };
            }
            var asset = new Asset()
            {
                Name = request.AssetName.Trim(),
                Specification = request.Specification.Trim(),
                InstalledDate = request.InstalledDate,
                CategoryID = request.CategoryId,
                StateID = request.AssetStateId,
                LocationID = currentUser.LocationId ?? 0
            };
            var categoryPrefix = GetCategoryPrefix(request.CategoryId);
            asset.Code = GenerateAssetCode(categoryPrefix);
            await context.Assets.AddAsync(asset);
            await context.SaveChangesAsync();

            return new ApiResult<string>(null)
            {
                Message = "Create asset successfully!",
                StatusCode = 200
            };
        }

        private bool CategoryIdExists(int categoryId)
        {
            var category = context.Categories.Where(c => c.Id == categoryId).FirstOrDefault();
            return category != null;
        }

        private string GenerateAssetCode(string categoryPrefix)
        {
            var lastAssetCode = GetAssetCode(categoryPrefix);

            if (lastAssetCode == "")
            {
                return categoryPrefix + "000001";
            }
            var subCode = Int32.Parse(lastAssetCode.Substring(3)) + 1;
            var generatedCode = categoryPrefix + subCode.ToString().PadLeft(6, '0');
            return generatedCode;
        }

        private string GetCategoryPrefix(int categoryId)
        {
            var prefix = categoryRepository.GetCategoryPrefix(categoryId);
            return prefix;
        }

        public Task<Asset?> GetAssetByIdAsync(int id)
        {
            return context.Assets.FindAsync(id).AsTask();
        }

        public async Task<Asset> UpdateAsync(Asset updateAsset)
        {
            var result = context.Assets.Update(updateAsset);
            await context.SaveChangesAsync();
            return result.Entity;
        }

        public Task<Asset?> GetAssetByIdAllIncludeAsync(int id)
        {
            return context.Assets
                .Include(x => x.Historical.Where(y => y.State == ReturnRequestStateEnums.Completed).OrderBy(y => y.AssignedDate))
                .ThenInclude(x => x.RequestedBy)
                .Include(x => x.Historical.Where(y => y.State == ReturnRequestStateEnums.Completed).OrderBy(y => y.AssignedDate))
                .ThenInclude(x => x.AssignedBy)
                .Include(x => x.Location)
                .Include(x => x.State)
                .Include(x => x.Category)
                .Where(x => x.Id == id)
                .FirstOrDefaultAsync();
        }

        public async Task SetAssetAvailable(Asset asset)
        {
            asset.StateID = 2;
            context.Assets.Update(asset);
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var result = await context.Assets.FirstOrDefaultAsync(x => x.Id == id);
            context.Assets.Remove(result);
            await context.SaveChangesAsync();
        }
    }
}