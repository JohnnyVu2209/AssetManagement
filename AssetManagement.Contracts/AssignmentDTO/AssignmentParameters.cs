using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.AssignmentDTO
{
    public class AssignmentParameters : PagingParameters
    {
        public AssignmentParameters()
        {
            OrderBy = "Id asc";
        }
        public List<int>? State { get; set; } = new(new int[] {1,2,3,4});
        public DateTime? AssignDate { get; set; }

        public string? Searching { get; set; }
    }
}
