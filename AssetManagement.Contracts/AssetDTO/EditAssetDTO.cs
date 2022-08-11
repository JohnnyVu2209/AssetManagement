using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Contracts.AssetDTO
{
    public class EditAssetDTO
    {
        public string Name { get; set; }
        public string  Specification { get; set; }
        public DateTime InstalledDate { get; set; }
        public int StateId { get; set; }
    }
}
