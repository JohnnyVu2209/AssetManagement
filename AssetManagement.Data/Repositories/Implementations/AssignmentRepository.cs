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
        public async Task<IEnumerable<Assignment>> GetAsync()
        {
            return await _context.Assignments.ToListAsync();
        }
    }
}
