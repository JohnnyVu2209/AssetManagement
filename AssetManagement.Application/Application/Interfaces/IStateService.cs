using AssetManagement.Domain.Model;

namespace AssetManagement.Application.Application.Interfaces
{
    public interface IStateService
    {
        Task<IEnumerable<State>> GetAllAsync();
    }
}