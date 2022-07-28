using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Model
{
    public class State
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        public virtual List<Asset> Assets { get; set; } = new List<Asset>();
    }
}