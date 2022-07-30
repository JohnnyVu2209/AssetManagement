using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Contracts.ViewModels
{
    public record AssetDetailDTO : AssetDTO
    {
        public int CategoryID { get; set; }

        public int StateID { get; set; }
        
        public int LocationID { get; set; }

        [Required]
        public string? Specification { get; set; }

        [Required]
        public DateTime InstalledDate { get; set; }

        public string? History { get; set; }
    }
}