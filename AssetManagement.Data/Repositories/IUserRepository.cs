using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.UserDTO;
using AssetManagement.Domain.Model;

namespace AssetManagement.Data.Repositories
{
    public interface IUserRepository
    {
        Task<UserViewDTO> GetByStaffCodeAsync(string staffcode);
        Task<PageResult<UserViewDTO>> GetPaginationAsync(ViewUserRequest request);
        Task<ApiResult<string>> UpdateAsync(UpdateUserDTO request);
        Task<List<RoleViewModel>> GetRolesAsync();
        IQueryable<User> FilterUsers(int location, string searching, string orderBy);
    }
}
