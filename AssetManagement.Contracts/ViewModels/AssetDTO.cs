namespace AssetManagement.Contracts.ViewModels
{
    public class AssetDTO
    {
        public string? Code { get; set; }

        public string? Name { get; set; }

        public string Category { get; set; } = string.Empty;

        public string State { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;
    }
}