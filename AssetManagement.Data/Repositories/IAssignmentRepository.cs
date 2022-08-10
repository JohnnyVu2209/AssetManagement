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
        Task<IEnumerable<Assignment>> GetAsync(string? searching,DateTime? assignDate,List<int>? state, string orderBy);

        Task<Assignment> CreateAssignment(User assignedBy, User assignedTo, Asset asset, DateTime assignedDate, string note);
    }
}
