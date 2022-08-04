namespace AssetManagement.Contracts.AssetDTO
{
    public record AssetDTO
    {
        public string? Code { get; set; }

        public string? Name { get; set; }

        public string? Category { get; set; }

        public string? State { get; set; }

        public string? Location { get; set; }
    }
}