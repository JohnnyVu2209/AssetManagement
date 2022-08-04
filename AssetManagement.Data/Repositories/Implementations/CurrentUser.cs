using System.Security.Claims;
using Microsoft.AspNetCore.Http;

namespace AssetManagement.Data.Repositories.Implementations
{
    public class CurrentUser : ICurrentUser
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly AssetManagementDbContext _context;

        public CurrentUser(AssetManagementDbContext context,
            IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        public string? UserName
        {
            get => _httpContextAccessor.HttpContext?
                .User.Claims.Single(x => x.Type == ClaimTypes.Name).Value;
        }

        public int? LocationId
        {
            get
            {
                return _context.Users
                            .Where(x => x.UserName == this.UserName)
                            .FirstOrDefault()?.LocationId;
            }
        }
    }
}
