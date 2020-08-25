using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace KukharAutoInfotechProject.Models
{
    public class Owners
    {
        [Key]
        public int OwnerID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public DateTime BirthDate { get; set; }


        public virtual ICollection<AutosAndOwners> AutosAndOwners { get; set; }
    }
}
