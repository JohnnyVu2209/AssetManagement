using AssetManagement.Contracts.AssignmentDTO;
using AssetManagement.Contracts.Constant;
using AssetManagement.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Data.Repositories
{
    public interface IAssignmentRepository
    {
        Task<IEnumerable<Assignment>> GetAsync(string? searching,DateTime? assignDate,List<int>? state);
        Task<PageResult<UserAssignmentViewModel>> GetUserAssignmentPaginationAsync(UserAssignmentViewRequest request);
        Task<ApiResult<bool>> AcceptRespondAsync(int assignmentId);
        Task<ApiResult<bool>> DeclineRespondAsync(int assignmentId);
        Task<IEnumerable<Assignment>> GetAsync(string? searching,DateTime? assignDate,List<int>? state, string orderBy);
        Task<Assignment> CreateAssignment(User assignedBy, User assignedTo, Asset asset, DateTime assignedDate, string note);
        Task<Assignment> GetAssignmentAsync(int id);
        Task UpdateAssignment(Asset asset, User assignTo, Assignment updateAssignment);
    }
}
