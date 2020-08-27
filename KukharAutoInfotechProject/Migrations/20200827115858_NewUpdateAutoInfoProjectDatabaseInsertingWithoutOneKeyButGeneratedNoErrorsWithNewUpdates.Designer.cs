﻿// <auto-generated />
using System;
using KukharAutoInfotechProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KukharAutoInfotechProject.Migrations
{
    [DbContext(typeof(KukharAutoInfotechProjectContext))]
    [Migration("20200827115858_NewUpdateAutoInfoProjectDatabaseInsertingWithoutOneKeyButGeneratedNoErrorsWithNewUpdates")]
    partial class NewUpdateAutoInfoProjectDatabaseInsertingWithoutOneKeyButGeneratedNoErrorsWithNewUpdates
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KukharAutoInfotechProject.Models.Autos", b =>
                {
                    b.Property<int>("PK_AutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AutoColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AutoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearFromPipeline")
                        .HasColumnType("datetime2");

                    b.HasKey("PK_AutoID");

                    b.ToTable("Autos");

                    b.HasData(
                        new
                        {
                            PK_AutoID = 3,
                            AutoColor = "Red",
                            AutoName = "Mazda",
                            YearFromPipeline = new DateTime(2013, 7, 10, 23, 49, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("KukharAutoInfotechProject.Models.AutosAndOwners", b =>
                {
                    b.Property<int>("PK_AutoID")
                        .HasColumnType("int");

                    b.Property<int>("PK_OwnerID")
                        .HasColumnType("int");

                    b.Property<int?>("AutosFKPK_AutoID")
                        .HasColumnType("int");

                    b.Property<int?>("OwnersFKPK_OwnerID")
                        .HasColumnType("int");

                    b.HasKey("PK_AutoID", "PK_OwnerID");

                    b.HasIndex("AutosFKPK_AutoID");

                    b.HasIndex("OwnersFKPK_OwnerID");

                    b.ToTable("AutosAndOwners");
                });

            modelBuilder.Entity("KukharAutoInfotechProject.Models.Owners", b =>
                {
                    b.Property<int>("PK_OwnerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("FatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PK_OwnerID");

                    b.ToTable("Owners");

                    b.HasData(
                        new
                        {
                            PK_OwnerID = 3,
                            BirthDate = new DateTime(2002, 7, 10, 23, 45, 0, 0, DateTimeKind.Unspecified),
                            FatherName = "Oleksiovic",
                            FirstName = "Tyxy",
                            LastName = "Oleks"
                        });
                });

            modelBuilder.Entity("KukharAutoInfotechProject.Models.AutosAndOwners", b =>
                {
                    b.HasOne("KukharAutoInfotechProject.Models.Autos", "AutosFK")
                        .WithMany("FK_AutoFromOwners")
                        .HasForeignKey("AutosFKPK_AutoID");

                    b.HasOne("KukharAutoInfotechProject.Models.Owners", "OwnersFK")
                        .WithMany("FKOwnersForAutos")
                        .HasForeignKey("OwnersFKPK_OwnerID");
                });
#pragma warning restore 612, 618
        }
    }
}
