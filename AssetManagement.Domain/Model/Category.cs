using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Model
{
    public class Category
    {
        public int Id { get; set; }
        
        public string? Name { get; set; }

        public virtual List<Asset> Assets { get; set; } = new List<Asset>();
    }
}