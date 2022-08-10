using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Domain.Model
{
    public class Role: IdentityRole<int>
    {
        public ICollection<UserRole> UserRoles { get; set; }
    }
}
