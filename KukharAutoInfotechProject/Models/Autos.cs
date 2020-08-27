using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KukharAutoInfotechProject.Models
{
    public class Autos
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PK_AutoID { get; set; }

        public string AutoName { get; set; }

        public string AutoColor { get; set; }
        public DateTime YearFromPipeline { get; set; }
        //public  int? AutosAndOwners { get; set; }

        //public virtual ICollection<AutosAndOwners> FK_AutoFromOwners { get; set; }
        public virtual ICollection<AutosAndOwners> OwnersList { get; set; }
     //   public Autos()
       // {
         //   OwnersList = new List<Owners>();
        //}
     }
}
