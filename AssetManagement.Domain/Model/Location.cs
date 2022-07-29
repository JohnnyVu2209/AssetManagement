using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetManagement.Domain.Model
{
    public class Location
    {
        public int Id { get; set; }
        
        public string LocationName { get; set; }

        public virtual List<User> Users { get; set; }

        public virtual List<Asset> Assets {get; set;}
    }
}
