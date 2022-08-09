using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.ReturnRequestDTO
{
    public class ReturnRequestDTO
    {
        public int Id { get; set; }
        public string AssetCode { get; set; }
        public string AssetName { get; set; }
        public string RequestedBy { get; set; }
        public DateTime AssignedDate { get; set; }
        public string AcceptedBy { get; set; }
        public DateTime ReturnedDate { get; set; }
        public ReturnRequestStateEnumsDTO State { get; set; }



    }
}
