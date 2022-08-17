using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Contracts.AssetDTO
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

        public List<Historical> History { get; set; }
    }

    public class Historical
    {
        public DateTime Date { get; set; }
        public string AssignedTo { get; set; }
        public string? AssignedBy { get; set; }
        public DateTime ReturnedDate { get; set; }
    }
}