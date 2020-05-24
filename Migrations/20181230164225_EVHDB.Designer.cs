﻿// <auto-generated />
using System;
using EVH.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EVH.Migrations
{
    [DbContext(typeof(EVHDBContext))]
    [Migration("20181230164225_EVHDB")]
    partial class EVHDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EVH.Models.HealthRecords", b =>
                {
                    b.Property<int>("Id")
                       .ValueGeneratedOnAdd()
                       .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AddedOn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("date")
                        .HasDefaultValueSql("(getdate())");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("LastName")
                       .IsRequired()
                       .HasMaxLength(50)
                       .IsUnicode(false);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);
                    b.Property<string>("Email")
                       .IsRequired()
                       .HasMaxLength(100)
                       .IsUnicode(false);
                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.ToTable("HealthRecords");
                });
#pragma warning restore 612, 618
        }
    }
}