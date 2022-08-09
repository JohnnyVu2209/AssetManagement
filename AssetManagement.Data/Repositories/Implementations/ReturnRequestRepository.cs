using AssetManagement.Domain.Model;
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

        public ReturnRequestRepository(AssetManagementDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ReturnRequest>> GetAsync(string? searching, DateTime? returnDate, List<int>? state)
        {
            IQueryable<ReturnRequest> query = _context.ReturnRequests.Include(x => x.Assignment).ThenInclude(x=>x.Asset).Include(x => x.AcceptedBy).Include(x => x.RequestedBy).AsQueryable();
            if (!string.IsNullOrWhiteSpace(searching))
            {
                query = query.Where(x => x.Assignment.Asset.Code.Contains(searching) || x.Assignment.Asset.Name.Contains(searching) || x.RequestedBy.UserName.Contains(searching));
            }
            if (returnDate != null)
            {
                query = query.Where(x => x.ReturnedDate.Date == returnDate.Value.Date);
            }
            if (state != null && state.Count != 0)
            {
                query = query.Where(x => state.Contains((int)x.State));
            }
            return await query.ToListAsync();
        }
        //public async Task<IEnumerable<Assignment>> GetAsync(string? searching, DateTime? assignDate, List<int>? state)
        //{
        //    IQueryable<Assignment> query = _context.Assignments.Include(x => x.Asset).Include(x => x.AssignedBy).Include(x => x.AssignedTo);
        //    if (!string.IsNullOrWhiteSpace(searching))
        //    {
        //        query = query.Where(x => x.Asset.Code.Contains(searching) || x.Asset.Name.Contains(searching) || x.AssignedTo.UserName.Contains(searching));
        //    }
        //    if (assignDate != null)
        //    {
        //        query = query.Where(x => x.AssignedDate.Date == assignDate.Value.Date);
        //    }
        //    if(state != null && state.Count != 0)
        //    {
        //        query = query.Where(x => state.Contains((int)x.AssignedState));
        //    }
        //    return await query.ToListAsync();
        //}
    }
}
