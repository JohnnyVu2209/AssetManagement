using AssetManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Data.Repository.Interface
{
    public interface IRoleRepository
    {
        Task<Role> GetRoleByIdAsync(int id);
    }
}
