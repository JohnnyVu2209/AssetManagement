using AssetManagement.Data.Repositories.Extensions;
using AssetManagement.Domain.Model;
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

        public AssignmentRepository(AssetManagementDbContext context)
        {
            _context = context;
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
            if(state != null && state.Count != 0)
            {
                query = query.Where(x => state.Contains((int)x.AssignedState));
            }
            return await query.ToListAsync();
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
    }
}
