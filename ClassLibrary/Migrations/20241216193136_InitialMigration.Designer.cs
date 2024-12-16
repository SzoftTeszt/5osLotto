﻿// <auto-generated />
using ClassLibrary.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassLibrary.Migrations
{
    [DbContext(typeof(AdatbazisKapcsolat))]
    [Migration("20241216193136_InitialMigration")]
    partial class InitialMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassLibrary.Models.Lottoszam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Szam1")
                        .HasColumnType("int");

                    b.Property<int>("Szam2")
                        .HasColumnType("int");

                    b.Property<int>("Szam3")
                        .HasColumnType("int");

                    b.Property<int>("Szam4")
                        .HasColumnType("int");

                    b.Property<int>("Szam5")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Lottoszam");
                });
#pragma warning restore 612, 618
        }
    }
}
