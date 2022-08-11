using System.ComponentModel.DataAnnotations;

namespace AssetManagement.Contracts.AssignmentDTO
{
    public class AssignmentDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Asset code is required")]
        public string AssetCode { get; set; }
        public string AssetName{ get; set; }
        public string AssignedTo { get; set; }
        public string AssignedBy { get; set; }
        public string Specification { get; set; }
        public DateTime AssignedDate { get; set; }
        public string Note { get; set; }
        public  AssignmentStateEnumsDTO AssignedState { get; set; }
    }
}
