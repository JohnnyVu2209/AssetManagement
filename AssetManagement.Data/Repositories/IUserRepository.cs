using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.UserDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Data.Repositories
{
    public interface IUserRepository
    {
        Task<UserViewDTO> GetByStaffCodeAsync(string staffcode);
        Task<PageResult<UserViewDTO>> GetPaginationAsync(ViewUserRequest request);
        Task<ApiResult<string>> UpdateAsync(UpdateUserDTO request);
        Task<List<RoleViewModel>> GetRolesAsync();
    }
}
