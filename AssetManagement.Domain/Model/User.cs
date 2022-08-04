using Microsoft.AspNetCore.Identity;

namespace AssetManagement.Domain.Model
{
    public class User : IdentityUser<int>
    {
        public string? StaffCode { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public DateTime JoinedDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public bool IsDisabled { get; set; }
        public bool IsPasswordChanged { get; set; }
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        public virtual List<Assignment> Assignments { get; set; } = new List<Assignment>();

    }
}
