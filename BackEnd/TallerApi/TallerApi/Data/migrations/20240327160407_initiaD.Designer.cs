﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TallerApi.DataAccess;

#nullable disable

namespace TallerApi.Data.migrations
{
    [DbContext(typeof(TallerDbContext))]
    [Migration("20240327160407_initiaD")]
    partial class initiaD
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TallerApi.Models.Country", b =>
                {
                    b.Property<int>("IdCountry")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCountry"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCountry");

                    b.ToTable("Country");

                    b.HasData(
                        new
                        {
                            IdCountry = 1,
                            Name = "Guatemala"
                        },
                        new
                        {
                            IdCountry = 2,
                            Name = "El Salvador"
                        },
                        new
                        {
                            IdCountry = 3,
                            Name = "Velice"
                        });
                });

            modelBuilder.Entity("TallerApi.Models.Department", b =>
                {
                    b.Property<int>("IdDepartment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDepartment"));

                    b.Property<int>("IdCountry")
                        .HasColumnType("int");

                    b.Property<int?>("IdCountryNavigationIdCountry")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDepartment");

                    b.HasIndex("IdCountryNavigationIdCountry");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("TallerApi.Models.Municipality", b =>
                {
                    b.Property<int>("IdMunicipality")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdMunicipality"));

                    b.Property<int>("IdDepartment")
                        .HasColumnType("int");

                    b.Property<int?>("IdDepartmentNavigationIdDepartment")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMunicipality");

                    b.HasIndex("IdDepartmentNavigationIdDepartment");

                    b.ToTable("Municipality");
                });

            modelBuilder.Entity("TallerApi.Models.Department", b =>
                {
                    b.HasOne("TallerApi.Models.Country", "IdCountryNavigation")
                        .WithMany("Departments")
                        .HasForeignKey("IdCountryNavigationIdCountry");

                    b.Navigation("IdCountryNavigation");
                });

            modelBuilder.Entity("TallerApi.Models.Municipality", b =>
                {
                    b.HasOne("TallerApi.Models.Department", "IdDepartmentNavigation")
                        .WithMany()
                        .HasForeignKey("IdDepartmentNavigationIdDepartment");

                    b.Navigation("IdDepartmentNavigation");
                });

            modelBuilder.Entity("TallerApi.Models.Country", b =>
                {
                    b.Navigation("Departments");
                });
#pragma warning restore 612, 618
        }
    }
}