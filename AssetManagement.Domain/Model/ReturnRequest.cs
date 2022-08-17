using AssetManagement.Domain.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Domain.Model
{

    public class ReturnRequest
    { 

        public int Id { get; set; }
        public User RequestedBy { get; set; }
        public int RequestedById { get; set; }
        public User? AcceptedBy { get; set; }
        public int? AcceptedById { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public DateTime AssignedDate { get; set; }
        public ReturnRequestStateEnums State { get; set; }
        public int AssignmentId { get; set; }
        public Assignment Assignment { get; set; }
        public int AssetId { get; set; }
        public Asset Asset { get; set; }
        public int? AssignedById { get; set; }
        public User? AssignedBy { get; set; }
    }
}
