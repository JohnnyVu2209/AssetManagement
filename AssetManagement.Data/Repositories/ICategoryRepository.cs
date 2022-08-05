using AssetManagement.Contracts.CategoryDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Domain.Model;
using Microsoft.AspNetCore;

namespace AssetManagement.Data.Repositories
{
    public interface ICategoryRepository
    {
        public string GetCategoryPrefix(int categoryId);

        Task<List<CategoryViewModel>> GetAllAsync();

        Task<ApiResult<string>> CreateAsync(CreateCategoryRequest request);
    }
}