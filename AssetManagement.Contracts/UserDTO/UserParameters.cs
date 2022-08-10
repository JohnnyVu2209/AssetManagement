using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.UserDTO
{
    public class UserParameters: PagingParameters
    {
        public UserParameters()
        {
            OrderBy = "staffCode";
        }
        public string? Searching { get; set; }
    }
}
