﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NewApp.API.Data;

namespace NewApp.API.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190920180109_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("NewApp.API.Models.Value", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("MyProperty");

                    b.HasKey("ID");

                    b.ToTable("Values");
                });
#pragma warning restore 612, 618
        }
    }
}
