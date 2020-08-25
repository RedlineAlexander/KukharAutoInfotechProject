﻿// <auto-generated />
using System;
using KukharAutoInfotechProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KukharAutoInfotechProject.Migrations
{
    [DbContext(typeof(KukharAutoInfotechProjectContext))]
    partial class KukharAutoInfotechProjectContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KukharAutoInfotechProject.Models.Autos", b =>
                {
                    b.Property<int>("AutoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AutoColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AutoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("YearFromPipeline")
                        .HasColumnType("datetime2");

                    b.HasKey("AutoID");

                    b.ToTable("Autos");
                });

            modelBuilder.Entity("KukharAutoInfotechProject.Models.AutosAndOwners", b =>
                {
                    b.Property<int>("AutosAndOwnersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AutoID")
                        .HasColumnType("int");

                    b.Property<int?>("AutosAutoID")
                        .HasColumnType("int");

                    b.Property<int>("OwnerID")
                        .HasColumnType("int");

                    b.Property<int?>("OwnersOwnerID")
                        .HasColumnType("int");

                    b.HasKey("AutosAndOwnersID");

                    b.HasIndex("AutosAutoID");

                    b.HasIndex("OwnersOwnerID");

                    b.ToTable("AutosAndOwners");
                });

            modelBuilder.Entity("KukharAutoInfotechProject.Models.Owners", b =>
                {
                    b.Property<int>("OwnerID")
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

                    b.HasKey("OwnerID");

                    b.ToTable("Owners");
                });

            modelBuilder.Entity("KukharAutoInfotechProject.Models.AutosAndOwners", b =>
                {
                    b.HasOne("KukharAutoInfotechProject.Models.Autos", "Autos")
                        .WithMany("AutoAndOwners")
                        .HasForeignKey("AutosAutoID");

                    b.HasOne("KukharAutoInfotechProject.Models.Owners", "Owners")
                        .WithMany("AutosAndOwners")
                        .HasForeignKey("OwnersOwnerID");
                });
#pragma warning restore 612, 618
        }
    }
}
