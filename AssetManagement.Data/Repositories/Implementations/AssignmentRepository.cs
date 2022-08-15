using AssetManagement.Contracts.AssignmentDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.Constant.Enums;
using AssetManagement.Data.Repositories.Extensions;
using AssetManagement.Domain.Model;
using AssetManagement.Domain.Model.Enums;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class AssignmentRepository : IAssignmentRepository
    {
        private readonly AssetManagementDbContext _context;
        private readonly ICurrentUser _currentUser;

        public AssignmentRepository(AssetManagementDbContext context, ICurrentUser currentUser)
        {
            _context = context;
            _currentUser = currentUser;
        }

        public async Task<Assignment> CreateAssignment(User assignedBy, User assignedTo, Asset asset, DateTime assignedDate, string note)
        {
            asset.StateID = 1;
            var result = _context.Assignments.Add(new() { Asset = asset, AssignedTo = assignedTo, AssignedBy = assignedBy, Note = note, AssignedDate = assignedDate, AssignedState = Domain.Model.Enums.AssignmentStateEnums.Waiting });
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<IEnumerable<Assignment>> GetAsync(string? searching, DateTime? assignDate, List<int>? state)
        {
            IQueryable<Assignment> query = _context.Assignments.Include(x => x.Asset).Include(x => x.AssignedBy).Include(x => x.AssignedTo);
            if (!string.IsNullOrWhiteSpace(searching))
            {
                query = query.Where(x => x.Asset.Code.Contains(searching) || x.Asset.Name.Contains(searching) || x.AssignedTo.UserName.Contains(searching));
            }
            if (assignDate != null)
            {
                query = query.Where(x => x.AssignedDate.Date == assignDate.Value.Date);
            }
            if (state != null && state.Count != 0)
            {
                query = query.Where(x => state.Contains((int)x.AssignedState));
            }
            return await query.ToListAsync();
        }

        public async Task<PageResult<UserAssignmentViewModel>> GetUserAssignmentPaginationAsync(UserAssignmentViewRequest request)
        {
            var userId = await GetUserIdOfRequest();
            var result = (from a in _context.Assignments
                          join toUser in _context.Users on a.AssignedToId equals toUser.Id
                          join byUser in _context.Users on a.AssignedById equals byUser.Id
                          join asset in _context.Assets on a.AssetId equals asset.Id
                          join c in _context.Categories on a.Asset.CategoryID equals c.Id
                          where a.AssignedToId == userId && a.AssignedState != AssignmentStateEnums.Declined
                          select new UserAssignmentViewModel

                          {
                              Id = a.Id,
                              AssetCode = asset.Code,
                              AssetName = asset.Name,
                              CategoryName = c.Name,
                              Specification = asset.Specification,
                              AssignedToUserName = toUser.UserName,
                              AssignedByUserName = byUser.UserName,
                              AssignedDate = a.AssignedDate,
                              State = a.AssignedState,
                              Note = a.Note,
                          }).AsSplitQuery();

            //Check assigned date
            result = result.Where(p => DateTime.Compare(p.AssignedDate.Date, DateTime.Now.Date) <= 0);

            int totalRow = await result.CountAsync();

            request.Limit = request.Limit > 0 ? request.Limit : 10;
            request.Page = request.Page > (int)Math.Ceiling((double)totalRow / request.Limit) ? (int)Math.Ceiling((double)totalRow / request.Limit) : request.Page;
            request.Page = request.Page > 0 ? request.Page : 1;

            if (request.SortType == null) request.SortType = "asc";
            if (request.SortBy == null) request.SortBy = "assetcode";

            //Sort by AssetCode
            if (string.Equals(request.SortBy, "assetcode", StringComparison.OrdinalIgnoreCase))
            {
                if (string.Equals(request.SortType, "desc", StringComparison.OrdinalIgnoreCase))
                {
                    result = result.OrderByDescending(x => x.AssetCode);
                }
                else
                {
                    result = result.OrderBy(x => x.AssetCode);
                }
            }//Sort by AssetName
            else if (string.Equals(request.SortBy, "assetname", StringComparison.OrdinalIgnoreCase))
            {
                if (string.Equals(request.SortType, "desc", StringComparison.OrdinalIgnoreCase))
                {
                    result = result.OrderByDescending(x => (x.AssetName));
                }
                else
                {
                    result = result.OrderBy(x => (x.AssetName));
                }
            }//Sort by Category
            else if (string.Equals(request.SortBy, "category", StringComparison.OrdinalIgnoreCase))
            {
                if (request.SortType == "desc")
                {
                    result = result.OrderByDescending(x => x.CategoryName);
                }
                else
                {
                    result = result.OrderBy(x => x.CategoryName);
                }
            }//Sort by assigned date
            else if (string.Equals(request.SortBy, "assigneddate", StringComparison.OrdinalIgnoreCase))
            {
                if (string.Equals(request.SortType, "desc", StringComparison.OrdinalIgnoreCase))
                {
                    result = result.OrderByDescending(x => x.AssignedDate);
                }
                else
                {
                    result = result.OrderBy(x => x.AssignedDate);
                }
            }//Sort by state
            else if (string.Equals(request.SortBy, "state", StringComparison.OrdinalIgnoreCase))
            {
                if (string.Equals(request.SortType, "desc", StringComparison.OrdinalIgnoreCase))
                {
                    result = result.OrderByDescending(x => x.State);
                }
                else
                {
                    result = result.OrderBy(x => x.State);
                }
            }
            else
            {
                if (string.Equals(request.SortType, "desc", StringComparison.OrdinalIgnoreCase))
                {
                    result = result.OrderByDescending(x => x.AssetCode);
                }
                else
                {
                    result = result.OrderBy(x => x.AssetCode);
                }
            }

            result = result.Paged(request.Page, request.Limit);

            var data = await result.ToListAsync();

            var pagedResult = new PageResult<UserAssignmentViewModel>()
            {
                TotalRecords = totalRow,
                Items = data,
                Page = request.Page,
                Limit = request.Limit
            };

            return pagedResult;
        }

        private async Task<int> GetUserIdOfRequest()
        {
            var userName = _currentUser.UserName;
            var user = await _context.Users.Where(x => x.UserName == userName).FirstOrDefaultAsync();
            return user.Id;
        }

        public async Task<ApiResult<bool>> AcceptRespondAsync(int assignmentId)
        {
            var assignment = await _context.Assignments.Where(x => x.Id.Equals(assignmentId)).FirstOrDefaultAsync();

            if (assignment != null)
            {
                if (assignment.AssignedState == AssignmentStateEnums.Waiting)
                {
                    assignment.AssignedState = AssignmentStateEnums.Accepted;

                    var asset = _context.Assets.Where(a => a.Id == assignment.AssetId).FirstOrDefault();
                    asset.StateID = (int)AssetState.Assigned;

                    await _context.SaveChangesAsync();

                    return new ApiResult<bool>(true)
                    {
                        Message = "Assignment is accepted",
                        StatusCode = 200
                    };
                }
                else
                {
                    return new ApiResult<bool>(true)
                    {
                        Message = "Cannot update state, assignment was accepted",
                        StatusCode = 400
                    };
                }
            }
            else
            {
                return new ApiResult<bool>(true)
                {
                    Message = "Not found this assignment",
                    StatusCode = 404
                };
            }
        }

        public async Task<ApiResult<bool>> DeclineRespondAsync(int assignmentId)
        {
            var assignment = await _context.Assignments.Include(x => x.Asset).Include(x => x.AssignedBy).Where(x => x.Id.Equals(assignmentId)).FirstOrDefaultAsync();
            if (assignment != null)
            {
                if (assignment.AssignedState == AssignmentStateEnums.Waiting)
                {
                    assignment.AssignedState = AssignmentStateEnums.Declined;
                    var asset = _context.Assets.Where(a => a.Id == assignment.AssetId).FirstOrDefault();
                    asset.StateID = (int)AssetState.Available;
                    await _context.SaveChangesAsync();
                    return new ApiResult<bool>(true)
                    {
                        Message = "Remove assignment successfully",
                        StatusCode = 200
                    };
                }
                else
                {
                    return new ApiResult<bool>(true)
                    {
                        Message = "Failed, perhaps assignment state was accepted",
                        StatusCode = 400
                    };
                }
            }
            else
            {
                return new ApiResult<bool>(true)
                {
                    Message = "Assignment is not found",
                    StatusCode = 404
                };
            }
        }

        public async Task<IEnumerable<Assignment>> GetAsync(string? searching, DateTime? assignDate, List<int>? state, string orderBy)
        {
            IQueryable<Assignment> query = _context.Assignments.Include(x => x.Asset).Include(x => x.AssignedBy).Include(x => x.AssignedTo);
            if (!string.IsNullOrWhiteSpace(searching))
            {
                query = query.Where(x => x.Asset.Code.Contains(searching) || x.Asset.Name.Contains(searching) || x.AssignedTo.UserName.Contains(searching));
            }
            if (assignDate != null)
            {
                query = query.Where(x => x.AssignedDate.Date == assignDate.Value.Date);
            }
            if (state != null && state.Count != 0)
            {
                query = query.Where(x => state.Contains((int)x.AssignedState));
            }

            query = query.ApplySort(orderBy);

            return await query.ToListAsync();
        }

        public async Task<Assignment> GetAssignmentAsync(int id)
        {
            var result = await _context.Assignments.Include(x => x.Asset).Include(x => x.AssignedBy).Include(x => x.AssignedTo).Where(x => x.Id == id).FirstOrDefaultAsync();
            return result;
        }

        public async Task<Assignment> UpdateAssignment(Assignment updateAssignment)
        {
            var result = _context.Assignments.Update(updateAssignment);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task UpdateAssignment(Asset asset, User assignTo, Assignment updateAssignment)
        {
            asset.StateID = 1;
            updateAssignment.Asset = asset;
            updateAssignment.AssignedTo = assignTo;
            _context.Assignments.Update(updateAssignment);
            await _context.SaveChangesAsync();
        }
    }
}