using AssetManagement.Data.Repository.Interface;
using AssetManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Data.Repository
{
    public class RoleRepository : IRoleRepository
    {
        private AssetManagementDbContext dbContext;
        public RoleRepository(AssetManagementDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Task<Role?> GetRoleByIdAsync(int id)
        {
            return dbContext.Roles.FirstOrDefaultAsync(r => r.Id == id);
        }
    }
}
