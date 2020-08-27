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
       // protected override void OnModelCreating(ModelBuilder modelBuilder)
     //   {
       //     modelBuilder.Entity<Autos>().HasKey(s => s.AutoID);
        //    modelBuilder.Entity<Owners>().HasKey(s => s.OwnerID);
        //    modelBuilder.Entity<AutosAndOwners>().HasKey(s =>
        //    new {
        //        s.AutoID,
        //        s.OwnerID
        //
        //    });
    //
         //   modelBuilder.Entity<Autos>().HasOne(s => s.AutoAndOwners)
          //      .WithMany(s => s.Owners)
         //       .HasForeignKey(s => s.AutosAndOwners)
          //      .OnDelete(DeleteBehavior.Restrict);

          //  modelBuilser

       // }
        public DbSet<Autos> Autos { get; set; } 
        public DbSet<Owners> Owners { get; set; }
        public DbSet<AutosAndOwners> AutosAndOwners { get; set; }
    }
}
