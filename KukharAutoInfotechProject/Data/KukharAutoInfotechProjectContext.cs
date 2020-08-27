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

            protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autos>().HasData(
                new Autos
                {
                    PK_AutoID = 3,
                    AutoName = "Mazda",
                    AutoColor = "Red",
                    YearFromPipeline = new DateTime(2013,7,10,23,49,0)

                }
                ) ; 
            modelBuilder.Entity<Owners>().HasData(
                new Owners
                {
                  PK_OwnerID = 3,
                    LastName = "Oleks",
                    FirstName = "Tyxy",
                    FatherName = "Oleksiovic",
                    BirthDate = new DateTime(2002, 7,10,23,45,0)
                }
                     );
            modelBuilder.Entity<AutosAndOwners>().HasKey(c => new { c.PK_AutoID, c.PK_OwnerID });

          

           
        }
        public DbSet<Autos> Autos { get; set; } 
        public DbSet<Owners> Owners { get; set; }
        public DbSet<AutosAndOwners> AutosAndOwners { get; set; }
    }
}
