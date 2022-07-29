using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Model
{
    public class Category : BaseEntity
    {
        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Prefix { get; set; }

        public virtual List<Asset> Assets { get; set; } = new List<Asset>();
    }
}