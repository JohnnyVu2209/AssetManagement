using Microsoft.EntityFrameworkCore;
using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class RoleRepository : IRoleRepository
    {
        private AssetManagementDbContext dbContext;

        public RoleRepository(AssetManagementDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Role?> GetRoleByIdAsync(int id)
        {
            return await dbContext.Roles.FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
