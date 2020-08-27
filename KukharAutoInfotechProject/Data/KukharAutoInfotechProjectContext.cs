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
                    PK_AutoID = 1,
                    AutoName = "Mazda",
                    AutoColor = "Blue",
                    YearFromPipeline = new DateTime(2014,7,10,23,49,0)

                }
                ) ; 
            modelBuilder.Entity<Owners>().HasData(
                new Owners
                {
                    PK_OwnerID = 1,
                    LastName = "Oleksa",
                    FirstName = "Tyxyi",
                    FatherName = "Oleksiovich",
                    BirthDate = new DateTime(2000, 7,10,23,45,0)
                }

                );
        }
        public DbSet<Autos> Autos { get; set; } 
        public DbSet<Owners> Owners { get; set; }
        public DbSet<AutosAndOwners> AutosAndOwners { get; set; }
    }
}
