﻿// <auto-generated />
using System;
using JSanchez_GH_Api.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JSanchez_GH_Api.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230628005948_AddMigrationPerson")]
    partial class AddMigrationPerson
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JSanchez_GH_Api.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_Of_Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("First_Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("First_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Identification")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("Marital_Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Photo")
                        .IsRequired()
                        .HasMaxLength(5000)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Place_Of_Birth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Second_Last_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Second_Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Persons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedDate = new DateTime(2023, 6, 27, 19, 59, 48, 768, DateTimeKind.Local).AddTicks(6071),
                            Date_Of_Birth = new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            First_Last_Name = "Sanchez",
                            First_Name = "Jose",
                            Identification = "0931147284",
                            Marital_Status = "Soltero",
                            Nationality = "Ecuatoriana",
                            Photo = "",
                            Place_Of_Birth = "Guayas",
                            Second_Last_Name = "Baque",
                            Second_Name = "Luis",
                            Sexo = "Masculino",
                            UpdatedDate = new DateTime(2023, 6, 27, 19, 59, 48, 768, DateTimeKind.Local).AddTicks(6072)
                        },
                        new
                        {
                            Id = 2,
                            CreatedDate = new DateTime(2023, 6, 27, 19, 59, 48, 768, DateTimeKind.Local).AddTicks(6075),
                            Date_Of_Birth = new DateTime(2023, 6, 27, 0, 0, 0, 0, DateTimeKind.Local),
                            First_Last_Name = "Ososrio",
                            First_Name = "Karen",
                            Identification = "0931147597",
                            Marital_Status = "Soltero",
                            Nationality = "Ecuatoriana",
                            Photo = "",
                            Place_Of_Birth = "Guayas",
                            Second_Last_Name = "Jimenes",
                            Second_Name = "Anais",
                            Sexo = "Femenimo",
                            UpdatedDate = new DateTime(2023, 6, 27, 19, 59, 48, 768, DateTimeKind.Local).AddTicks(6076)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
