using AssetManagement.Domain.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Domain.Model
{
    public class Assignment: BaseEntity
    {
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
        public int AssignedToId { get; set; }
        public User AssignedTo { get; set; }
        public int AssignedById { get; set; }
        public User? AssignedBy { get; set; }
        public DateTime AssignedDate { get; set; }
        public AssignmentStateEnums AssignedState { get; set; }
        public string Note { get; set; }
    }
}
