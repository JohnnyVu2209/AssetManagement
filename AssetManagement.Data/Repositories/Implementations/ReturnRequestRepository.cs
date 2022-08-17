using AssetManagement.Contracts.Constant;
using AssetManagement.Contracts.ReturnRequestDTO;
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
    public class ReturnRequestRepository : IReturnRequestRepository
    {
        private readonly AssetManagementDbContext _context;
        private readonly ICurrentUser _currentUser;

        public ReturnRequestRepository(AssetManagementDbContext context,  ICurrentUser currentUser)
        {
            _currentUser = currentUser;
            _context = context;
        }

        public async Task<IEnumerable<ReturnRequest>> GetAsync(string? searching, DateTime? returnDate, List<int>? state)
        {
            IQueryable<ReturnRequest> query = _context.ReturnRequests.Include(x => x.Assignment).Include(x=>x.Asset).Include(x => x.AcceptedBy).Include(x => x.RequestedBy).AsQueryable();
            if (!string.IsNullOrWhiteSpace(searching))
            {
                query = query.Where(x => x.Asset.Code.Contains(searching) || x.Asset.Name.Contains(searching) || x.RequestedBy.UserName.Contains(searching));
            }
            if (returnDate != null)
            {
                query = query.Where(x => x.ReturnedDate!=null && x.ReturnedDate.Value.Date == returnDate.Value.Date);
            }
            if (state != null && state.Count != 0)
            {
                query = query.Where(x => state.Contains((int)x.State));
            }
            return await query.ToListAsync();
        }

        public async Task<ReturnRequest> GetAsyncById(int id)
        {
            return await _context.ReturnRequests.FirstOrDefaultAsync(x => x.Id == id);

        }

        public async Task PutAsync(int id, bool status)
        {
            var getReturnRequest=await _context.ReturnRequests.Include(x=>x.Assignment).Include(x=>x.Asset).FirstOrDefaultAsync(x => x.Id == id);
            var getAsset = await _context.Assets.FirstOrDefaultAsync(x => x.Id == getReturnRequest.Asset.Id);
            var getAssignment = await _context.Assignments.FirstOrDefaultAsync(x => x.Id == getReturnRequest.AssignmentId);
            var user = _currentUser.UserName;
            var getUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == user);

            if (status)
            {
                getReturnRequest.State = ReturnRequestStateEnums.Completed;
                getReturnRequest.ReturnedDate = DateTime.Now;
                getReturnRequest.AcceptedById = getUser.Id;
                getAsset.StateID = 2;
                getAssignment.AssignedState = AssignmentStateEnums.Returned;
                _context.Assignments.Remove(getAssignment);
            }
            else
            {
                getAssignment.AssignedState = AssignmentStateEnums.Accepted;
                _context.ReturnRequests.Remove(getReturnRequest);
            }
            await _context.SaveChangesAsync();
        }

        public async Task<ApiResult<bool>> CreateAsync(int assignmentId)
        {
            var user = _currentUser.UserName;
            var getUser = await _context.Users.FirstOrDefaultAsync(x => x.UserName == user);
            var getAssignment = await _context.Assignments.FirstOrDefaultAsync(x=>x.Id==assignmentId);
            var returnRequest = await _context.Assignments.Where(a => a.Id == assignmentId && a.AssignedState == AssignmentStateEnums.Accepted).Select(a => new ReturnRequest()
            {
                AssignmentId = a.Id,
                AssetId = a.AssetId,
                RequestedById = getUser.Id,
                AssignedDate = getAssignment.AssignedDate,
                State = ReturnRequestStateEnums.Waiting,
                AssignedById = getAssignment.AssignedById
            }).FirstOrDefaultAsync();

            if (returnRequest != null)
            {
                await _context.ReturnRequests.AddAsync(returnRequest);

                var assignment = await _context.Assignments.Where(a => a.Id == assignmentId).FirstOrDefaultAsync();
                assignment.AssignedState = AssignmentStateEnums.Returned;

                await _context.SaveChangesAsync();

                return new ApiResult<bool>(true)
                {
                    StatusCode = 200,
                    Message = "Create return request successfully!"
                };
            }

            return new ApiResult<bool>(true)
            {
                StatusCode = 400,
                Message = "Can not find assigment or assignment state is wrong!"
            };
        }
    }
}