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
        public async Task<IEnumerable<Assignment>> GetAsync(string? searching, DateTime? assignDate, List<int>? state)
        {
            IQueryable<Assignment> query = _context.Assignments;
            if (!string.IsNullOrWhiteSpace(searching))
            {
                query = query.Where(x => x.AssetCode.Contains(searching) || x.AssetName.Contains(searching) || x.AssignTo.Contains(searching));
            }
            if (assignDate != null)
            {
                query = query.Where(x => x.AssignDate.Date == assignDate.Value.Date);
            }
            if(state != null && state.Count != 0)
            {
                query = query.Where(x => state.Contains((int)x.AssignmentState));
            }
            return await query.ToListAsync();
        }
    }
}
