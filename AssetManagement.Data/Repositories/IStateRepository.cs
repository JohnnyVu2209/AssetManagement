using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories
{
    public interface IStateRepository
    {
        Task<List<State>> GetAllAsync();
        Task<State> GetByIdAsync(int id);
    }
}