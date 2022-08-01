using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Data;
using AssetManagement.Domain.Model;

namespace AssetManagement.Application.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ICurrentUser _currentUser;

        public CategoryService(IUnitOfWork unitOfWork, ICurrentUser currentUser)
        {
            _unitOfWork = unitOfWork;
            _currentUser = currentUser;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _unitOfWork.Catagories.GetAllAsync();
        }
    }
}