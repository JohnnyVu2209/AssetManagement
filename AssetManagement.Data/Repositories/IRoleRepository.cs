using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories
{
    public interface IRoleRepository
    {
        Task<Role?> GetRoleByIdAsync(int id);
    }
}
