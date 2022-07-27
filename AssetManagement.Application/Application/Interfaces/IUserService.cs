using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.Request;
using AssetManagement.Contracts.ViewModels;
namespace AssetManagement.Application.Application.Interfaces
{
    public interface IUserService
    {
        Task<List<UserViewModel>> GetAllAsync();
        Task<UserViewModel> GetByStaffCodeAsync(string staffcode);
        Task<PagedResult<UserViewModel>> GetPaginationAsync(ViewUserRequest request);
        Task<bool> UpdateAsync(UpdateUserRequest request);
        Task<List<RoleViewModel>> GetRolesAsync();
    }
}