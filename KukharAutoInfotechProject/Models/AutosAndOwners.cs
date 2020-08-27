using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace KukharAutoInfotechProject.Models
{
    public class AutosAndOwners
    {
      //  [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
     //   [Key, Column(Order=1)]
     // public int AutosAndOwnersID {get;set;}
        //  [Key]
     //   [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    [Key, Column(Order=2)]
        public int PKAutoID { get; set; }
       // [ForeignKey("AutosID")]
        public virtual Autos AutosFK { get; set; }
        //  [Key]
       // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    //    [Key, Column(Order=3)]
        public int PKOwnerID { get; set; }
        //
       // [ForeignKey("OwnersID")]
        public virtual  Owners OwnersFK { get; set; }
    }
}
