using AssetManagement.Domain.Model;

namespace AssetManagement.Application.Application.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
    }
}