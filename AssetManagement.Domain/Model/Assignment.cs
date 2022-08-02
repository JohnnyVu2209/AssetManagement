using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Domain.Model
{
    public class Assignment
    {
        public int Id { get; set; }
        public int AssetId { get; set; }
        public int? UserId { get; set; }
        public string AssetCode { get; set; }
        public string StaffCode { get; set; }
        public string AssetName { get; set; }
        public string AssignTo { get; set; }
        public string AssignBy { get; set; }
        public bool AssignmentState { get; set; }
        public DateTime AssignDate { get; set; }
        public  Asset Asset { get; set; }
        public  User User { get; set; }

    }
}
