using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Domain.Model.Enums
{
    public enum ReturnRequestStateEnums:int
    {
        [Description("Completed")]
        Completed = 1,
        [Description("Waiting for returning")]
        Waiting =2,
    }
}
