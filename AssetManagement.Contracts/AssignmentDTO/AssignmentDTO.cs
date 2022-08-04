using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.AssignmentDTO
{
    public class AssignmentDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Asset code is required")]
        public string AssetCode { get; set; }
        [Required(ErrorMessage = "Staff code is required")]
        public string StaffCode { get; set; }
        public string AssetName{ get; set; }
        public string AssignTo { get; set; }
        public string AssignBy { get; set; }
        public DateTime AssignDate { get; set; }
        [Range(1, 2)]
        public AssignmentStateEnumsDTO AssignmentState { get; set; }
    }
}
