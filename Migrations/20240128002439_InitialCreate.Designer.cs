﻿// <auto-generated />
using FullStackDevelopmentUsingAspnetCore8MVC.ApplicationDbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FullStackDevelopmentUsingAspnetCore8MVC.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240128002439_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.1");

            modelBuilder.Entity("FullStackDevelopmentUsingAspnetCore8MVC.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Program")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("RollNo")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Section")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Students");
                });
#pragma warning restore 612, 618
        }
    }
}