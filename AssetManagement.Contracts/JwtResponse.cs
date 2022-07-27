namespace AssetManagement.Contracts
{
    public class JwtResponse
    {
        public string Token { get; set; }
        public string RefreshToken { get; set; }
        public DateTime Expiration { get; set; }
        public string Username { get; set; }
        public string Role { get; set; }

        public bool IsPasswordChanged { get; set; }
    }
}
