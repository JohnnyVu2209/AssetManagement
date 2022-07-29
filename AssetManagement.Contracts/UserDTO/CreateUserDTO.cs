using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.UserDTO
{
    public class CreateUserDTO
    {
        [Required(ErrorMessage ="First name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Please select date of birth")]
        public DateTime DateOfBirth { get; set; }
        [Range(0,1)]
        public int Gender { get; set; }
        public DateTime JoinedDate { get; set; }
        public int Type { get; set; }
    }
}
