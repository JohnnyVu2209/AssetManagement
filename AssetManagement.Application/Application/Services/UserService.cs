using AssetManagement.Application.Application.Interfaces;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.UserDTO;
using AssetManagement.Contracts.Utilities;
using AssetManagement.Contracts.ViewModels;
using AssetManagement.Data;
using AssetManagement.Domain.Model;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Application.Application.Services
{
    public class UserService : IUserService
    {
        private readonly AssetManagementDbContext _context;
        private readonly IMapper _mapper;
        private readonly ICurrentUser _currentUser;
        private readonly UserManager<User> _userManager;
        public UserService(AssetManagementDbContext context, IMapper mapper, UserManager<User> userManager, ICurrentUser currentUser)
        {
            _context = context;
            _mapper = mapper;
            _userManager = userManager;
            _currentUser = currentUser;
        }

        public async Task<List<UserViewModel>> GetAllAsync()
        {
            return await _context.Users.Select(user => _mapper.Map<UserViewModel>(user)).ToListAsync();
        }

        public async Task<UserViewModel> GetByStaffCodeAsync(string staffcode)
        {
            var result = await (from u in _context.Users
                          join ur in _context.UserRoles on u.Id equals ur.UserId
                          join r in _context.Roles on ur.RoleId equals r.Id
                          where u.IsDisabled == false && u.StaffCode== staffcode
                          select new UserViewModel
                          {
                              Id = u.Id,
                              StaffCode = u.StaffCode,
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                              UserName = u.UserName,
                              DateOfBirth = u.DateOfBirth,
                              Gender = u.Gender ==true ? 1:0,
                              JoinedDate = u.JoinedDate,
                              Type = r.Name,
                              TypeId = r.Id,
                              LocationId = u.LocationId,
                              LocationName = u.Location.LocationName
                          }).FirstOrDefaultAsync();
            return result;
        }

        public async Task<PagedResult<UserViewModel>> GetPaginationAsync(ViewUserRequest request)
        {
            var result = (from u in _context.Users
                          join ur in _context.UserRoles on u.Id equals ur.UserId
                          join r in _context.Roles on ur.RoleId equals r.Id
                          where u.IsDisabled == false
                          select new UserViewModel
                          {
                              Id = u.Id,
                              StaffCode = u.StaffCode,
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                              UserName = u.UserName,
                              DateOfBirth = u.DateOfBirth,
                              Gender = u.Gender==true?1:0,
                              JoinedDate = u.JoinedDate,
                              Type = r.Name,
                              TypeId=r.Id,
                              LocationId = u.LocationId,
                              LocationName = u.Location.LocationName
                          }).AsSplitQuery();
            //Search
            if (!string.IsNullOrEmpty(request.Keyword))
            {
                result = result.Where(p => (p.FirstName + " " + p.LastName).Contains(request.Keyword) || (p.StaffCode).Contains(request.Keyword));
            }
            //Type check
            if (request.Type != null && request.Type.Count > 0)
            {
                result = result.Where(p => request.Type.Contains(p.Type));
            }
            //Location check
            int location = await GetLocationOfRequest();
            result = result.Where(p => (p.LocationId == location));

            //Pagination
            int totalRow = result.Count();

            request.Limit = request.Limit > 0 ? request.Limit : 1000;
            request.Page = request.Page > (int)Math.Ceiling((double)totalRow / request.Limit) ? (int)Math.Ceiling((double)totalRow / request.Limit) : request.Page;
            request.Page = request.Page > 0 ? request.Page : 1;

            //Sort
            if (request.SortBy == null)
            {
                if (request.Ascending) result = result.OrderBy(x => x.Id);
                else result = result.OrderByDescending(x => x.Id);
            }
            else if (request.SortBy == "Name")
            {
                if (request.Ascending) result = result.OrderBy(x => (x.FirstName + " " + x.LastName));
                else result = result.OrderByDescending(x => (x.FirstName + " " + x.LastName));
            }
            else if (request.SortBy == "JoinDate")
            {
                if (request.Ascending) result = result.OrderBy(x => x.JoinedDate);
                else result = result.OrderByDescending(x => x.JoinedDate);
            }
            else if (request.SortBy == "Type")
            {
                if (request.Ascending) result = result.OrderBy(x => x.Type);
                else result = result.OrderByDescending(x => x.Type);
            }
            else
            {
                if (request.Ascending) result = result.OrderBy(x => x.Id);
                else result = result.OrderByDescending(x => x.Id);
            }

            result = result.Paged(request.Page, request.Limit);

            var data = await result.ToListAsync();

            List<string> categoryNames = new List<string>();

            var pagedResult = new PagedResult<UserViewModel>()
            {
                TotalRecords = totalRow,
                Items = data,
                Page = request.Page,
                Limit = request.Limit
            };

            return pagedResult;
        }

        private async Task<int> GetLocationOfRequest()
        {
            var userName = _currentUser.UserName;
            var user = await _context.Users.Where(x => x.UserName == userName).FirstOrDefaultAsync();
            return user.LocationId;
        }

        public async Task<bool> UpdateAsync(UpdateUserRequest request)
        {
            string staffCode = request.StaffCode;

            var user = await _context.Users.Where(x => x.StaffCode == staffCode && x.IsDisabled==false).FirstOrDefaultAsync();
            if (user == null) return false;

            if (await GetLocationOfRequest() != user.LocationId)
            {
                return false;
            }

            var currentDate = DateTime.Now;
            var dob = request.DateOfBirth;
            var joinedDate = request.JoinedDate;
            if (currentDate.Year - dob.Year < 18) return false;
            if (joinedDate.DayOfWeek == DayOfWeek.Saturday || joinedDate.DayOfWeek == DayOfWeek.Sunday) return false;

            user.DateOfBirth = request.DateOfBirth;
            user.JoinedDate = request.JoinedDate;
            if (request.Gender == 1) user.Gender = true;
            else user.Gender = false;
            user.UpdatedDate = DateTime.Now;
            await _context.SaveChangesAsync();

            var currentRole = await _context.UserRoles.Where(ur=> ur.UserId == user.Id).FirstOrDefaultAsync();
            if (currentRole.RoleId != request.TypeId)
            {
                var oldRole = await _userManager.GetRolesAsync(user);
                var newRole = await _context.Roles.Where(r => r.Id == request.TypeId).FirstOrDefaultAsync();
                await _userManager.RemoveFromRolesAsync(user, oldRole);
                await _userManager.AddToRoleAsync(user, newRole.Name);
            }

            return true;
        }

        public async Task<List<RoleViewModel>> GetRolesAsync()
        {
            return await _context.Roles.Select(r => new RoleViewModel()
            {
                Id = r.Id,
                RoleName = r.Name
            }).ToListAsync();
        }
    }
}
