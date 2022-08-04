using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.AssetDTO
{
    public class CreateAssetRequest
    {
        public string AssetName { get; set; }
        public string Specification { get; set; }
        public DateTime InstalledDate { get; set; }
        public int CategoryId { get; set; }
        public int AssetStateId { get; set; }
    }
}
