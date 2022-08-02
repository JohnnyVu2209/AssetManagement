using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.AssetDTO
{
    public class AssetParameters : QueryStringParameters
    {
        public List<int>? State { get; set; } = new(new int[] { 1, 2, 3 });
        public List<int>? Category { get; set; }

        public string? Searching { get; set; }
    }
}
