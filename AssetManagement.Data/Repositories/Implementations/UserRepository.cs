using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.UserDTO;
using AssetManagement.Data.Repositories.Extensions;
using AssetManagement.Domain.Model;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Linq.Dynamic.Core;
using System.Reflection;
using System.Text;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class UserRepository : IUserRepository
    {
        private readonly AssetManagementDbContext _context;
        private readonly ICurrentUser _currentUser;
        private readonly UserManager<User> _userManager;
        public UserRepository(AssetManagementDbContext context, UserManager<User> userManager, ICurrentUser currentUser)
        {
            _context = context;
            _userManager = userManager;
            _currentUser = currentUser;
        }

        public async Task<UserViewDTO> GetByStaffCodeAsync(string staffcode)
        {
            var result = await (from u in _context.Users
                                join ur in _context.UserRoles on u.Id equals ur.UserId
                                join r in _context.Roles on ur.RoleId equals r.Id
                                where u.IsDisabled == false && u.StaffCode == staffcode
                                select new UserViewDTO
                                {
                                    Id = u.Id,
                                    StaffCode = u.StaffCode,
                                    FirstName = u.FirstName,
                                    LastName = u.LastName,
                                    UserName = u.UserName,
                                    DateOfBirth = u.DateOfBirth,
                                    Gender = u.Gender == true ? 1 : 0,
                                    JoinedDate = u.JoinedDate,
                                    Type = r.Name,
                                    TypeId = r.Id,
                                    LocationId = u.LocationId,
                                    LocationName = u.Location.LocationName
                                }).FirstOrDefaultAsync();
            return result;
        }

        public async Task<PageResult<UserViewDTO>> GetPaginationAsync(ViewUserRequest request)
        {
            var result = (from u in _context.Users
                          join ur in _context.UserRoles on u.Id equals ur.UserId
                          join r in _context.Roles on ur.RoleId equals r.Id
                          where u.IsDisabled == false
                          select new UserViewDTO
                          {
                              Id = u.Id,
                              StaffCode = u.StaffCode,
                              FirstName = u.FirstName,
                              LastName = u.LastName,
                              UserName = u.UserName,
                              DateOfBirth = u.DateOfBirth,
                              Gender = u.Gender == true ? 1 : 0,
                              JoinedDate = u.JoinedDate,
                              Type = r.Name,
                              TypeId = r.Id,
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

            var pagedResult = new PageResult<UserViewDTO>()
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

        public async Task<ApiResult<string>> UpdateAsync(UpdateUserDTO request)
        {
            string staffCode = request.StaffCode;

            var user = await _context.Users.Where(x => x.StaffCode == staffCode && x.IsDisabled == false).FirstOrDefaultAsync();
            if (user == null) return new ApiResult<string>(null)
            {
                StatusCode = 400,
                Message = "User is not found!"
            };

            if (await GetLocationOfRequest() != user.LocationId) return new ApiResult<string>(null)
            {
                StatusCode = 400,
                Message = "Can not update user at another locations!"
            };

            var currentDate = DateTime.Now;
            var dob = request.DateOfBirth;
            if (currentDate.Year - dob.Year < 18) return new ApiResult<string>(null)
            {
                StatusCode = 400,
                Message = "User is under 18!"
            };

            var joinedDate = request.JoinedDate;
            if (joinedDate.DayOfWeek == DayOfWeek.Saturday || joinedDate.DayOfWeek == DayOfWeek.Sunday) 
                return new ApiResult<string>(null)
                {
                    StatusCode = 400,
                    Message = "Joined date is Sat or Sun!"
                };

            user.DateOfBirth = request.DateOfBirth;
            user.JoinedDate = request.JoinedDate;

            if (request.Gender == 1) user.Gender = true;
            else user.Gender = false;

            user.UpdatedDate = DateTime.Now;

            await _context.SaveChangesAsync();

            var currentRole = await _context.UserRoles.Where(ur => ur.UserId == user.Id).FirstOrDefaultAsync();
            if (currentRole.RoleId != request.TypeId)
            {
                var oldRole = await _userManager.GetRolesAsync(user);
                var newRole = await _context.Roles.Where(r => r.Id == request.TypeId).FirstOrDefaultAsync();
                await _userManager.RemoveFromRolesAsync(user, oldRole);
                await _userManager.AddToRoleAsync(user, newRole.Name);
            }

            return new ApiResult<string>(null)
            {
                StatusCode = 200,
                Message = "Update user information successfully!"
            };
        }

        public async Task<List<RoleViewModel>> GetRolesAsync()
        {
            return await _context.Roles.Select(r => new RoleViewModel()
            {
                Id = r.Id,
                Name = r.Name
            }).ToListAsync();
        }

        public IQueryable<User> FilterUsers(int location, string searching, string orderBy)
        {
            var users = _context.Users.Include(x => x.UserRoles).ThenInclude(x => x.Role).Include(x => x.Location).AsQueryable();

            if (users.Any() && location != 0)
                users = users.Where(x => x.LocationId == location);

            if (users.Any() && !string.IsNullOrWhiteSpace(searching))
                users = users.Where(x => x.StaffCode.ToLower().Contains(searching.Trim().ToLower()) || x.FullName.ToLower().Contains(searching.Trim().ToLower()));
            if(orderBy.ToLower().Contains("type"))
            {
                if (orderBy.ToLower().Contains("asc"))
                    users = users.OrderBy(x => x.UserRoles.FirstOrDefault().RoleId);
                else
                    users = users.OrderByDescending(x => x.UserRoles.FirstOrDefault().RoleId);
            }
            else
                users = users.ApplySort(orderBy);

            return users;
        }

    }
}
