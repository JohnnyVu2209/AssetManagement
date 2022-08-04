namespace AssetManagement.Data.Repositories
{
    public interface ICurrentUser
    {
        string? UserName { get; }

        int? LocationId { get; }
    }
}
