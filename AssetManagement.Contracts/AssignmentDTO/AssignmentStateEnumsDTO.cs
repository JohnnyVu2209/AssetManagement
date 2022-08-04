﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.AssignmentDTO
{
    public enum AssignmentStateEnumsDTO
    {
        [Description("Accepted")]
        Accepted = 1,
        [Description("Waiting for acceptance")]
        Waiting = 2,
    }
}