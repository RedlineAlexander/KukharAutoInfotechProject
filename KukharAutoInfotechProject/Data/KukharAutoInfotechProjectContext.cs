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
                    AutoColor = "Red",
                    YearFromPipeline = new DateTime(2013,7,10,23,49,0)

                },
           
           
          //  modelBuilder.Entity<Autos>().HasData(
            new Autos
            {
                PK_AutoID = 2,
                AutoName = "Mazda",
                AutoColor = "Blue",
                YearFromPipeline = new DateTime(2013, 7, 10, 23, 49, 0)

            },
               new Autos
               {
                   PK_AutoID = 3,
                   AutoName = "Dodge",
                   AutoColor = "Red",
                   YearFromPipeline = new DateTime(2013, 7, 10, 23, 49, 0)

               },
                  new Autos
                  {
                      PK_AutoID = 4,
                      AutoName = "Renault",
                      AutoColor = "Red",
                      YearFromPipeline = new DateTime(2013, 7, 10, 23, 49, 0)

                  },
                     new Autos
                     {
                         PK_AutoID = 5,
                         AutoName = "Vuxhall",
                         AutoColor = "Red",
                         YearFromPipeline = new DateTime(2013, 7, 10, 23, 49, 0)

                     },
                      new Autos
                      {
                          PK_AutoID = 6,
                          AutoName = "Bentley",
                          AutoColor = "Red",
                          YearFromPipeline = new DateTime(2013, 7, 10, 23, 49, 0)

                      },
               new Autos
               {
                   PK_AutoID = 7,
                   AutoName = "Maybach",
                   AutoColor = "Red",
                   YearFromPipeline = new DateTime(2013, 7, 10, 23, 49, 0)

               },
                  new Autos
                  {
                      PK_AutoID = 8,
                      AutoName = "Mercedes",
                      AutoColor = "Red",
                      YearFromPipeline = new DateTime(2013, 7, 10, 23, 49, 0)

                  },
                     new Autos
                     {
                         PK_AutoID = 9,
                         AutoName = "Mitsubishi",
                         AutoColor = "Red",
                         YearFromPipeline = new DateTime(2013, 7, 10, 23, 49, 0)

                     },
                      new Autos
                      {
                          PK_AutoID = 10,
                          AutoName = "Opel",
                          AutoColor = "Red",
                          YearFromPipeline = new DateTime(2013, 7, 10, 23, 49, 0)

                      }


                     );


            modelBuilder.Entity<Owners>().HasData(
               new Owners
               {
                   PK_OwnerID = 1,
                   LastName = "Oleks",
                   FirstName = "Tyxy",
                   FatherName = "Oleksiovic",
                   BirthDate = new DateTime(2002, 7, 10, 23, 45, 0)
               },
                   new Owners
                   {
                       PK_OwnerID = 2,
                       LastName = "Mstisyavskiy",
                       FirstName = "Myroslav",
                       FatherName = "Oleksiovic",
                       BirthDate = new DateTime(2002, 7, 10, 23, 45, 0)
                   },
                       new Owners
                       {
                           PK_OwnerID = 3,
                           LastName = "Milog",
                           FirstName = "Milosh",
                           FatherName = "Oleksiovic",
                           BirthDate = new DateTime(2000, 7, 10, 23, 45, 0)
                       },
                           new Owners
                           {
                               PK_OwnerID = 4,
                               LastName = "Oblakevich",
                               FirstName = "Tayanna",
                               FatherName = "Oleksioviivna",
                               BirthDate = new DateTime(2004, 7, 10, 23, 45, 0)
                           },
                               new Owners
                               {
                                   PK_OwnerID = 5,
                                   LastName = "Oleksashenko",
                                   FirstName = "Boghdan",
                                   FatherName = "Oleksiovic",
                                   BirthDate = new DateTime(2003, 7, 10, 23, 45, 0)
                               },
                                   new Owners
                                   {
                                       PK_OwnerID = 6,
                                       LastName = "Soblevskyi",
                                       FirstName = "Miron",
                                       FatherName = "Oleksiovic",
                                       BirthDate = new DateTime(2002, 7, 10, 23, 45, 0)
                                   },
                                       new Owners
                                       {
                                           PK_OwnerID = 7,
                                           LastName = "Oleksash",
                                           FirstName = "Teheran",
                                           FatherName = "Oleksiovic",
                                           BirthDate = new DateTime(2000, 7, 10, 23, 45, 0)
                                       },
                                           new Owners
                                           {
                                               PK_OwnerID = 8,
                                               LastName = "Oleks",
                                               FirstName = "Ahmed",
                                               FatherName = "Oleksiovic",
                                               BirthDate = new DateTime(2001, 7, 10, 23, 45, 0)
                                           },
                                                   new Owners
                                                   {
                                                       PK_OwnerID = 9,
                                                       LastName = "Olegarieva",
                                                       FirstName = "Tasha",
                                                       FatherName = "Vyacheslavivna",
                                                       BirthDate = new DateTime(2002, 7, 10, 23, 45, 0)
                                                   },
                                                           new Owners
                                                           {
                                                               PK_OwnerID = 10,
                                                               LastName = "Oleks",
                                                               FirstName = "Sergiy",
                                                               FatherName = "Oleksiovic",
                                                               BirthDate = new DateTime(2002, 7, 10, 23, 45, 0)
                                                           }

                                                   
                                           
                    );

               modelBuilder.Entity<AutosAndOwners>().HasKey(c => new { c.PK_AutoID, c.PK_OwnerID });

        }
        public DbSet<Autos> Autos { get; set; } 
        public DbSet<Owners> Owners { get; set; }
        public DbSet<AutosAndOwners> AutosAndOwners { get; set; }
    }
}
