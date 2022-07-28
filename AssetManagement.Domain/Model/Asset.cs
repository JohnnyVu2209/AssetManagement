using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace AssetManagement.Domain.Model
{
    public class Asset
    {
        public int Id { get; set; }

        [Required]
        public string? Code { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Specification { get; set; }

        [Required]
        public DateTime InstalledDate { get; set; }

        public string? History { get; set; }

        public int CategoryID { get; set; }

        [Required]
        public virtual Category? Category { get; set; }

        public int StateID { get; set; }

        [Required]
        public virtual State? State { get; set; }

        public int LocationID { get; set; }

        [Required]
        public virtual Location? Location { get; set; }
    }
}