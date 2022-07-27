using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.Identity
{
    public interface ICurrentUser
    {
        string UserName { get; }
    }
}
