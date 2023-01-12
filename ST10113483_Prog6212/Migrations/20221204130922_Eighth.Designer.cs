﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ST101113483_Prog6212.Data;

#nullable disable

namespace StudyTracker.Migrations
{
    [DbContext(typeof(ST101113483_Prog6212Context))]
    [Migration("20221204130922_Eighth")]
    partial class Eighth
    {
        /// <inheritdoc />
        protected void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Study_Tracker.Models.Module", b =>
                {
                    b.Property<string>("moduleCode")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<double?>("HoursStudiedThisWeek")
                        .HasColumnType("float");

                    b.Property<double>("classHoursPerWeek")
                        .HasColumnType("float");

                    b.Property<int>("credits")
                        .HasColumnType("int");

                    b.Property<string>("moduleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("semesterNumOfWeeks")
                        .HasColumnType("int");

                    b.Property<DateTime>("semesterStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("username")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("moduleCode");

                    b.HasIndex("username");

                    b.ToTable("Module");
                });

            modelBuilder.Entity("Study_Tracker.Models.StudyDate", b =>
                {
                    b.Property<int>("studyDateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("studyDateID"));

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<double>("hoursStudied")
                        .HasColumnType("float");

                    b.Property<string>("moduleCode")
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("studyDateID");

                    b.HasIndex("moduleCode");

                    b.ToTable("StudyDate");
                });

            modelBuilder.Entity("Study_Tracker.Models.User", b =>
                {
                    b.Property<string>("username")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.HasKey("username");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Study_Tracker.Models.Module", b =>
                {
                    b.HasOne("Study_Tracker.Models.User", "user")
                        .WithMany("modules")
                        .HasForeignKey("username")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("user");
                });

            modelBuilder.Entity("Study_Tracker.Models.StudyDate", b =>
                {
                    b.HasOne("Study_Tracker.Models.Module", "module")
                        .WithMany("studyDates")
                        .HasForeignKey("moduleCode");

                    b.Navigation("module");
                });

            modelBuilder.Entity("Study_Tracker.Models.Module", b =>
                {
                    b.Navigation("studyDates");
                });

            modelBuilder.Entity("Study_Tracker.Models.User", b =>
                {
                    b.Navigation("modules");
                });
#pragma warning restore 612, 618
        }
    }
}
