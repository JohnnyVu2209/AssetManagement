using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Contracts.Request
{
    public class ChangePasswordDTO
    {
        [Required(ErrorMessage = "Current password is required")]
        public string OldPassword { get; set; }
        [Required(ErrorMessage = "New password is required")]
        public string NewPassword { get; set; }
    }
}
