using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.ReturnRequestDTO
{
    public enum ReturnRequestStateEnumsDTO
    {
        [Description("Completed")]
        Completed = 1,
        [Description("Waiting for returning")]
        Waiting = 2,
    }
}
