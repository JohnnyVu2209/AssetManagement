using AssetManagement.Domain.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class ReportRepository : IReportRepository
    {
        private readonly AssetManagementDbContext _context;
        public ReportRepository(AssetManagementDbContext context)
        {
            _context = context;
        }
        public async Task<List<Report>> GetReport(string username)
        {
            var user = await _context.Users.FirstOrDefaultAsync(x => x.UserName == username);

            var categories = await _context.Categories
                .Include(x => x.Assets.Where(y => y.LocationID == user.LocationId))
                .ThenInclude(x => x.State).ToListAsync();
            var report = new List<Report>();
            foreach (var item in categories)
            {
                report.Add(new Report
                {
                    Category = item,
                    Total = item.Assets.Count(),
                    Assigned = item.Assets.Where(x => x.StateID == 1).Count(),
                    Available = item.Assets.Where(x => x.StateID == 2).Count(),
                    NotAvailable = item.Assets.Where(x => x.StateID == 3).Count(),
                    WaitingForRecycling = item.Assets.Where(x => x.StateID == 4).Count(),
                    Recycled = item.Assets.Where(x => x.StateID == 5).Count()
                });
            }
            return report;
        }
    }
}
