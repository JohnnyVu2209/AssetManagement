namespace AssetManagement.Application.Application.Interfaces
{
    public interface ICurrentUser
    {
        string? UserName { get; }

        int? LocationId { get; }
    }
}
