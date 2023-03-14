﻿// <auto-generated />
using System;
using ITI_Project_MVC.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ITI_Project_MVC.Migrations
{
    [DbContext(typeof(ITIContext))]
    [Migration("20230312113706_init1")]
    partial class init1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ITI_Project_MVC.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<double>("Degree")
                        .HasColumnType("float");

                    b.Property<int?>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<double>("MinDegree")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Dept_Id");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("ITI_Project_MVC.Models.Course_Result", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int>("Degree")
                        .HasColumnType("int");

                    b.Property<int?>("Trainee_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Course_Id");

                    b.HasIndex("Trainee_Id");

                    b.ToTable("Course_Results");
                });

            modelBuilder.Entity("ITI_Project_MVC.Models.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Manager")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("ITI_Project_MVC.Models.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Course_Id")
                        .HasColumnType("int");

                    b.Property<int?>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("Course_Id");

                    b.HasIndex("Dept_Id");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("ITI_Project_MVC.Models.Trainee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Dept_Id")
                        .HasColumnType("int");

                    b.Property<double>("Grade")
                        .HasColumnType("float");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Dept_Id");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("ITI_Project_MVC.Models.Course", b =>
                {
                    b.HasOne("ITI_Project_MVC.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("Dept_Id");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ITI_Project_MVC.Models.Course_Result", b =>
                {
                    b.HasOne("ITI_Project_MVC.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Course_Id");

                    b.HasOne("ITI_Project_MVC.Models.Trainee", "Trainee")
                        .WithMany("Course_Results")
                        .HasForeignKey("Trainee_Id");

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("ITI_Project_MVC.Models.Instructor", b =>
                {
                    b.HasOne("ITI_Project_MVC.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("Course_Id");

                    b.HasOne("ITI_Project_MVC.Models.Department", "Department")
                        .WithMany("Instructors")
                        .HasForeignKey("Dept_Id");

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ITI_Project_MVC.Models.Trainee", b =>
                {
                    b.HasOne("ITI_Project_MVC.Models.Department", "Department")
                        .WithMany("Trainees")
                        .HasForeignKey("Dept_Id");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ITI_Project_MVC.Models.Department", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Instructors");

                    b.Navigation("Trainees");
                });

            modelBuilder.Entity("ITI_Project_MVC.Models.Trainee", b =>
                {
                    b.Navigation("Course_Results");
                });
#pragma warning restore 612, 618
        }
    }
}