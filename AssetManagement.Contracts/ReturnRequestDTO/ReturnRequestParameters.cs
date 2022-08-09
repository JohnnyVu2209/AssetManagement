using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.ReturnRequestDTO
{
    public class ReturnRequestParameters:PagingParameters
    {
        public List<int>? State { get; set; } = new(new int[] { 1, 2 });
        public DateTime? ReturnedDate { get; set; }

        public string? Searching { get; set; }
    }
}
