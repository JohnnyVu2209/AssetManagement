using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Domain.Model
{
    public class Asset : BaseEntity
    {
        [Required]
        public string? Code { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        public string? Specification { get; set; }

        [Required]
        public DateTime InstalledDate { get; set; }


        public int CategoryID { get; set; }

        [Required]
        public virtual Category? Category { get; set; }

        public int StateID { get; set; }

        [Required]
        public virtual State? State { get; set; }

        public int LocationID { get; set; }

        [Required]
        public virtual Location? Location { get; set; }
        public List<ReturnRequest> Historical { get; set; } = new List<ReturnRequest>();
        public virtual List<Assignment> Assignments { get; set; } = new List<Assignment>();

    }
}