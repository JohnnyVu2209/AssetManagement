using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.Constant.Enums
{
    public enum AssetState
    {
        [Description("Assigned")]
        Assigned = 1,

        [Description("Available")]
        Available = 2,

        [Description("Not Available")]
        NotAvailable = 3,
    }
}
