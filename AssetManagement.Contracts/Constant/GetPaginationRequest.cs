using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.Constant
{
    public class GetPaginationRequest
    {
        public int Limit { get; set; }
        public int Page { get; set; }
    }
}
