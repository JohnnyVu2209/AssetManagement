using AssetManagement.Domain.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.AssignmentDTO
{
    public class UserAssignmentViewModel
    {
        public int Id { get; set; }
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string CategoryName { get; set; }
        public string Specification { get; set; }
        public string AssignedToUserName { get; set; }
        public string AssignedByUserName { get; set; }

        [DataType(DataType.Date)]
        public DateTime AssignedDate { get; set; }

        public AssignmentStateEnums State { get; set; }
        public string Note { get; set; }
    }
}
