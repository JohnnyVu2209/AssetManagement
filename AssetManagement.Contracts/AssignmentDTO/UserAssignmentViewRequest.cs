using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.AssignmentDTO
{
    public class UserAssignmentViewRequest : GetPaginationRequest
    {
        public List<AssignmentStateEnumsDTO>? State { get; set; }
        public List<DateTime>? AssignedDate { get; set; }
        public string? Keyword { get; set; }
        public string? SortBy { get; set; }
        public string? SortType { get; set; }
    }
}
