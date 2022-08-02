using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.AssignmentDTO
{
    public class AssignmentParameters : QueryStringParameters
    {
        public List<bool>? State { get; set; } = new(new bool[] { true,false });
        public DateTime? AssignDate { get; set; }

        public string? Searching { get; set; }
    }
}
