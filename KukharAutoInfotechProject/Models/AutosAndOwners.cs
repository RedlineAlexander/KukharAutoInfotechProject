using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KukharAutoInfotechProject.Models
{
    public class AutosAndOwners
    {
        public int AutosAndOwnersID {get;set;}
        public int AutoID { get; set; }
        public int OwnerID { get; set; }

        public Autos Autos { get; set; }

        public Owners Owners { get; set; }
    }
}
