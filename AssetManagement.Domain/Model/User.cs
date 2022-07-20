using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Domain.Model
{
    public class User : IdentityUser<int>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public DateTime JoinedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDisabled { get; set; }
    }
}
