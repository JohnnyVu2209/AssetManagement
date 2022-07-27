using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Contracts.Authentication
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
