using AssetManagement.Contracts.CategoryDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Domain.Model;
//using Microsoft.AspNetCore.Mvc;

namespace AssetManagement.Data.Repositories
{
    public interface ICategoryRepository
    {
        Task<List<Category>> GetAllCategoriesAsync();
        public string GetCategoryPrefix(int categoryId);

        Task<List<CategoryViewModel>> GetAllAsync();

        Task<ApiResult<string>> CreateAsync(CreateCategoryRequest request);
    }
}