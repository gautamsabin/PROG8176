using Microsoft.EntityFrameworkCore;
using Assignment2.Models;
using System;

namespace Assignment2.Data
{
    public class DepartmentContext : DbContext
    {
        public DepartmentContext(DbContextOptions<DepartmentContext> options) : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Project> Projects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Data seeding for departments
            modelBuilder.Entity<Department>().HasData(
                new Department
                {
                    DepartmentId = 1,
                    DepartmentName = "HR",
                    Location = "New York",
                    Budget = 50000.00M,
                    Description = "Human Resources Department"
                },
                new Department
                {
                    DepartmentId = 2,
                    DepartmentName = "IT",
                    Location = "San Francisco",
                    Budget = 75000.00M,
                    Description = "Information Technology Department"
                },
                new Department
                {
                    DepartmentId = 3,
                    DepartmentName = "Marketing",
                    Location = "Chicago",
                    Budget = 60000.00M,
                    Description = "Marketing Department"
                }
            );

            // Data seeding for employees
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    EmployeeID = 1,
                    LastName = "Smith",
                    FirstMidName = "John",
                    Gender = Gender.Male,
                    PhoneNumber = "555-123-4567",
                    Email = "john.smith@gmail.com",
                    DepartmentId = 1
                },
                new Employee
                {
                    EmployeeID = 2,
                    LastName = "Doe",
                    FirstMidName = "Jane",
                    Gender = Gender.Female,
                    PhoneNumber = "555-987-6543",
                    Email = "jane.doe@gmail.com",
                    DepartmentId = 1
                },
                new Employee
                {
                    EmployeeID = 3,
                    LastName = "Johnson",
                    FirstMidName = "Robert",
                    Gender = Gender.Male,
                    PhoneNumber = "555-555-5555",
                    Email = "robert.johnson@gmail.com",
                    DepartmentId = 2
                },
                new Employee
                {
                    EmployeeID = 4,
                    LastName = "Williams",
                    FirstMidName = "Sarah",
                    Gender = Gender.Female,
                    PhoneNumber = "555-222-3333",
                    Email = "sarah.williams@gmail.com",
                    DepartmentId = 2
                },
                new Employee
                {
                    EmployeeID = 5,
                    LastName = "Brown",
                    FirstMidName = "David",
                    Gender = Gender.Male,
                    PhoneNumber = "555-789-1234",
                    Email = "david.brown@gmail.com",
                    DepartmentId = 3
                },
                new Employee
                {
                    EmployeeID = 6,
                    LastName = "Davis",
                    FirstMidName = "Mary",
                    Gender = Gender.Female,
                    PhoneNumber = "555-456-7890",
                    Email = "mary.davis@gmail.com",
                    DepartmentId = 3
                },
                new Employee
                {
                    EmployeeID = 7,
                    LastName = "Miller",
                    FirstMidName = "Michael",
                    Gender = Gender.Male,
                    PhoneNumber = "555-111-2222",
                    Email = "michael.miller@gmail.com",
                    DepartmentId = 1
                },
                new Employee
                {
                    EmployeeID = 8,
                    LastName = "Wilson",
                    FirstMidName = "Emily",
                    Gender = Gender.Female,
                    PhoneNumber = "555-999-8888",
                    Email = "emily.wilson@gmail.com",
                    DepartmentId = 2
                },
                new Employee
                {
                    EmployeeID = 9,
                    LastName = "Moore",
                    FirstMidName = "Christopher",
                    Gender = Gender.Male,
                    PhoneNumber = "555-777-6666",
                    Email = "christopher.moore@gmail.com",
                    DepartmentId = 3
                },
                new Employee
                {
                    EmployeeID = 10,
                    LastName = "Taylor",
                    FirstMidName = "Jessica",
                    Gender = Gender.Female,
                    PhoneNumber = "555-333-4444",
                    Email = "jessica.taylor@gmail.com",
                    DepartmentId = 1
                }
            );

            // Data seeding for projects
            modelBuilder.Entity<Project>().HasData(
                new Project
                {
                    ProjectID = 1,
                    Name = "Project A",
                    Description = "Description for Project A",
                    StartDate = DateTime.Parse("2023-01-15"),
                    EndDate = DateTime.Parse("2023-03-30"),
                    DepartmentId = 1
                },
                new Project
                {
                    ProjectID = 2,
                    Name = "Project B",
                    Description = "Description for Project B",
                    StartDate = DateTime.Parse("2023-02-01"),
                    EndDate = DateTime.Parse("2023-04-15"),
                    DepartmentId = 2
                },
                new Project
                {
                    ProjectID = 3,
                    Name = "Project C",
                    Description = "Description for Project C",
                    StartDate = DateTime.Parse("2023-03-10"),
                    EndDate = DateTime.Parse("2023-06-20"),
                    DepartmentId = 1
                },
                new Project
                {
                    ProjectID = 4,
                    Name = "Project D",
                    Description = "Description for Project D",
                    StartDate = DateTime.Parse("2023-04-05"),
                    EndDate = DateTime.Parse("2023-07-10"),
                    DepartmentId = 3
                },
                new Project
                {
                    ProjectID = 5,
                    Name = "Project E",
                    Description = "Description for Project E",
                    StartDate = DateTime.Parse("2023-05-20"),
                    EndDate = DateTime.Parse("2023-08-30"),
                    DepartmentId = 2
                }
            );
        }
    }
}
