using AssetManagement.Contracts.CategoryDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Domain.Model;
using Microsoft.AspNetCore;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AssetManagementDbContext context;
        public CategoryRepository(AssetManagementDbContext context) 
        {
            this.context = context;
        }

        public string GetCategoryPrefix(int categoryId)
        {
            return context.Categories
                .Where(x => x.Id == categoryId)
                .Select(x => x.Prefix)
                .FirstOrDefault() ?? "";
        }

        public async Task<List<CategoryViewModel>> GetAllAsync()
        {
            var category =  context.Categories
                            .Select(category => new CategoryViewModel()
                            {
                                Id = category.Id,
                                Name = category.Name,
                                Prefix = category.Prefix
                            }).ToList();
            return category;
        }

        public async Task<ApiResult<string>> CreateAsync(CreateCategoryRequest request)
        {
            if (CategoryIdExists(request.Prefix))
            {
                return new ApiResult<string>(null)
                {
                    Message = "Category prefix exists!",
                    StatusCode = 400
                };
            }
            if (CategoryNameExists(request.Name))
            {
                return new ApiResult<string>(null)
                {
                    Message = "Category name exists!",
                    StatusCode = 400
                };
            }
            var category = new Category()
            {
                Name = request.Name,
                Prefix = request.Prefix,
            };
            await context.Categories.AddAsync(category);
            await context.SaveChangesAsync();
            return new ApiResult<string>(null)
            {
                StatusCode = 200,
                Message = "Create new category successfully!",
            };
        }

        private bool CategoryIdExists(string categoryId)
        {
            var category = context.Categories.Where(c => c.Prefix == categoryId).FirstOrDefault();
            return category != null;
        }

        private bool CategoryNameExists(string categoryName)
        {
            var category = context.Categories.Where(c => c.Name == categoryName).FirstOrDefault();
            return category != null;
        }
    }
}