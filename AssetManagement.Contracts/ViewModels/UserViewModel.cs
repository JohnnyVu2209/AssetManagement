using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.ViewModels
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string StaffCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Type { get; set; }
        public int TypeId { get; set; }
        public int Gender { get; set; }

        [DataType(DataType.Date)]
        public DateTime JoinedDate { get; set; }

        public int LocationId { get; set; }
        public string LocationName { get; set; }
    }
}
