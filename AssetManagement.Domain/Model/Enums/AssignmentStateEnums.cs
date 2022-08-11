using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Domain.Model.Enums
{
    public enum AssignmentStateEnums:int
    {
        [Description("Accepted")]
        Accepted = 1,
        [Description("Waiting for acceptance")]
        Waiting =2,
        [Description("Declined")]
        Declined = 3,
        [Description("Returned")]
        Returned = 4,
    }
}
