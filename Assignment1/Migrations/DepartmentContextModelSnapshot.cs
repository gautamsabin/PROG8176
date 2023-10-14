﻿// <auto-generated />
using System;
using Assignment1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Assignment1.Migrations
{
    [DbContext(typeof(DepartmentContext))]
    partial class DepartmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment1.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<decimal>("Budget")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<string>("DepartmentName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            DepartmentId = 1,
                            Budget = 50000.00m,
                            DepartmentName = "HR",
                            Description = "Human Resources Department",
                            Location = "New York"
                        },
                        new
                        {
                            DepartmentId = 2,
                            Budget = 75000.00m,
                            DepartmentName = "IT",
                            Description = "Information Technology Department",
                            Location = "San Francisco"
                        },
                        new
                        {
                            DepartmentId = 3,
                            Budget = 60000.00m,
                            DepartmentName = "Marketing",
                            Description = "Marketing Department",
                            Location = "Chicago"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstMidName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeID = 1,
                            DepartmentId = 1,
                            Email = "john.smith@gmail.com",
                            FirstMidName = "John",
                            Gender = 0,
                            LastName = "Smith",
                            PhoneNumber = "555-123-4567"
                        },
                        new
                        {
                            EmployeeID = 2,
                            DepartmentId = 1,
                            Email = "jane.doe@gmail.com",
                            FirstMidName = "Jane",
                            Gender = 1,
                            LastName = "Doe",
                            PhoneNumber = "555-987-6543"
                        },
                        new
                        {
                            EmployeeID = 3,
                            DepartmentId = 2,
                            Email = "robert.johnson@gmail.com",
                            FirstMidName = "Robert",
                            Gender = 0,
                            LastName = "Johnson",
                            PhoneNumber = "555-555-5555"
                        },
                        new
                        {
                            EmployeeID = 4,
                            DepartmentId = 2,
                            Email = "sarah.williams@gmail.com",
                            FirstMidName = "Sarah",
                            Gender = 1,
                            LastName = "Williams",
                            PhoneNumber = "555-222-3333"
                        },
                        new
                        {
                            EmployeeID = 5,
                            DepartmentId = 3,
                            Email = "david.brown@gmail.com",
                            FirstMidName = "David",
                            Gender = 0,
                            LastName = "Brown",
                            PhoneNumber = "555-789-1234"
                        },
                        new
                        {
                            EmployeeID = 6,
                            DepartmentId = 3,
                            Email = "mary.davis@gmail.com",
                            FirstMidName = "Mary",
                            Gender = 1,
                            LastName = "Davis",
                            PhoneNumber = "555-456-7890"
                        },
                        new
                        {
                            EmployeeID = 7,
                            DepartmentId = 1,
                            Email = "michael.miller@gmail.com",
                            FirstMidName = "Michael",
                            Gender = 0,
                            LastName = "Miller",
                            PhoneNumber = "555-111-2222"
                        },
                        new
                        {
                            EmployeeID = 8,
                            DepartmentId = 2,
                            Email = "emily.wilson@gmail.com",
                            FirstMidName = "Emily",
                            Gender = 1,
                            LastName = "Wilson",
                            PhoneNumber = "555-999-8888"
                        },
                        new
                        {
                            EmployeeID = 9,
                            DepartmentId = 3,
                            Email = "christopher.moore@gmail.com",
                            FirstMidName = "Christopher",
                            Gender = 0,
                            LastName = "Moore",
                            PhoneNumber = "555-777-6666"
                        },
                        new
                        {
                            EmployeeID = 10,
                            DepartmentId = 1,
                            Email = "jessica.taylor@gmail.com",
                            FirstMidName = "Jessica",
                            Gender = 1,
                            LastName = "Taylor",
                            PhoneNumber = "555-333-4444"
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Project", b =>
                {
                    b.Property<int>("ProjectID")
                        .HasColumnType("int");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("ProjectID");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            ProjectID = 1,
                            DepartmentId = 1,
                            Description = "Description for Project A",
                            EndDate = new DateTime(2023, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Project A",
                            StartDate = new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectID = 2,
                            DepartmentId = 2,
                            Description = "Description for Project B",
                            EndDate = new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Project B",
                            StartDate = new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectID = 3,
                            DepartmentId = 1,
                            Description = "Description for Project C",
                            EndDate = new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Project C",
                            StartDate = new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectID = 4,
                            DepartmentId = 3,
                            Description = "Description for Project D",
                            EndDate = new DateTime(2023, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Project D",
                            StartDate = new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            ProjectID = 5,
                            DepartmentId = 2,
                            Description = "Description for Project E",
                            EndDate = new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Name = "Project E",
                            StartDate = new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Assignment1.Models.Employee", b =>
                {
                    b.HasOne("Assignment1.Models.Department", "Department")
                        .WithMany("Employees")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Assignment1.Models.Project", b =>
                {
                    b.HasOne("Assignment1.Models.Department", "Department")
                        .WithMany("Projects")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("Assignment1.Models.Department", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("Projects");
                });
#pragma warning restore 612, 618
        }
    }
}
