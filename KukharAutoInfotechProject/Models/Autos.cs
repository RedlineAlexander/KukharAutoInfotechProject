using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KukharAutoInfotechProject.Models
{
    public class Autos
    {
        [Key]
        public int AutoID { get; set; }

        public string AutoName { get; set; }

        public string AutoColor { get; set; }
        public DateTime YearFromPipeline { get; set; }

        public List<AutosAndOwners> AutoAndOwners { get; set; }
     }
}
