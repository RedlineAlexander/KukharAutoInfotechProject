using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KukharAutoInfotechProject.Models;
using Microsoft.EntityFrameworkCore;
namespace KukharAutoInfotechProject.Data
{
    public class KukharAutoInfotechProjectContext : DbContext
    {
        public KukharAutoInfotechProjectContext(DbContextOptions<KukharAutoInfotechProjectContext> options):base(options)
        {

        }
        public DbSet<Autos> Autos { get; set; } 
        public DbSet<Owners> Owners { get; set; }
        public DbSet<AutosAndOwners> AutosAndOwners { get; set; }
    }
}
