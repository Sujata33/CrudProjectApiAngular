﻿// <auto-generated />
using System;
using CrudProject.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace CrudProject.Migrations
{
    [DbContext(typeof(FullStackDbContext))]
    [Migration("20240303043457_forth migration")]
    partial class forthmigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("CrudProject.Models.Banks", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("ref_code")
                        .HasColumnType("text");

                    b.Property<string>("short_name")
                        .HasColumnType("text");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("CrudProject.Models.Branches", b =>
                {
                    b.Property<Guid>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("address")
                        .HasColumnType("text");

                    b.Property<DateTime>("created_at")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ifsc")
                        .HasColumnType("text");

                    b.Property<string>("name")
                        .HasColumnType("text");

                    b.Property<string>("ref_code")
                        .HasColumnType("text");

                    b.Property<DateTime>("updated_at")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("id");

                    b.ToTable("Branches");
                });
#pragma warning restore 612, 618
        }
    }
}
