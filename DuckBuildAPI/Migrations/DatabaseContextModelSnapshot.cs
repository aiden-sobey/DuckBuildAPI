﻿// <auto-generated />
using System;
using DuckBuildAPI;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DuckBuildAPI.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("DuckBuildAPI.Quack", b =>
                {
                    b.Property<int>("DuckId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<bool>("QuackStatus")
                        .HasColumnType("INTEGER");

                    b.HasKey("DuckId");

                    b.ToTable("Quacks");
                });
#pragma warning restore 612, 618
        }
    }
}