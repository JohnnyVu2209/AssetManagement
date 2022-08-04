using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories
{
    public interface IStateRepository
    {
        Task<List<State>> GetAllAsync();
    }
}