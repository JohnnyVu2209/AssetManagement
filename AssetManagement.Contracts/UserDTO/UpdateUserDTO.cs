using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.UserDTO
{
    public class UpdateUserDTO
    {
        public string StaffCode { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoinedDate { get; set; }
        public int Gender { get; set; }
        public int TypeId { get; set; }
    }
}
