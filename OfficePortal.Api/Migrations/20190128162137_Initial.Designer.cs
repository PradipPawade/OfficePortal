﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OfficePortal.Api.Data;

namespace OfficePortal.Api.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20190128162137_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028");

            modelBuilder.Entity("OfficePortal.Api.Models.CurrentOpening", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Position");

                    b.HasKey("Id");

                    b.ToTable("CurrentOpenings");
                });
#pragma warning restore 612, 618
        }
    }
}