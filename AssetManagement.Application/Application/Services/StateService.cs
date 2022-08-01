using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Data;
using AssetManagement.Domain.Model;

namespace AssetManagement.Application.Application.Services
{
    public class StateService : IStateService
    {
        private readonly IUnitOfWork _unitOfWork;

        private readonly ICurrentUser _currentUser;

        public StateService(IUnitOfWork unitOfWork, ICurrentUser currentUser)
        {
            _unitOfWork = unitOfWork;
            _currentUser = currentUser;
        }

        public async Task<IEnumerable<State>> GetAllAsync()
        {
            return await _unitOfWork.States.GetAllAsync();
        }
    }
}